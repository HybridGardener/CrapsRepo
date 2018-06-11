using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsGame
{
    public partial class Form1 : Form
    {
        public MainController mainController;
        public Form1()
        {
            InitializeComponent();
            mainController = new MainController();
            InitializeDataBindings();

        }
       

        private void InitializeDataBindings()
        {
            PlayerListBindingSource.DataSource = mainController.Players;
            PlayerListBox.DataSource = mainController.Players;
            PlayerListBox.DisplayMember = "Name";

            txtNewUserName.DataBindings.Add("Text", mainController.NewPlayer,"Name",false, DataSourceUpdateMode.OnPropertyChanged);
          
            cmbGames.DataSource = mainController.SelectedPlayer?.Games;
            cmbGames.DisplayMember = "Id";
            cmbGames.SelectedValueChanged += CmbGames_SelectedValueChanged;

            lblDie1.DataBindings.Add("Text", mainController.CurrentGame.RollInProgress, "DieOne", false, DataSourceUpdateMode.OnPropertyChanged, 0);
            lblDie2.DataBindings.Add("Text", mainController.CurrentGame.RollInProgress, "DieTwo", false, DataSourceUpdateMode.OnPropertyChanged, 0);
            lblGameState.DataBindings.Add("Text", mainController, "GameState", false, DataSourceUpdateMode.OnPropertyChanged);

            lblPlayerVal.DataBindings.Add("Text", mainController.SelectedPlayer, "Name", false, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
        }

        private void CmbGames_SelectedValueChanged(object sender, EventArgs e)
        {
            var cmb = (sender as ComboBox);
            var value = cmb.SelectedItem;
            mainController.SetSelectedGame(value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNewUserName_TextChanged(object sender, EventArgs e)
        {
            var tb = (sender as TextBox);
            btnAddUser.Enabled = !string.IsNullOrEmpty(tb.Text);
          
        }
        private void RebindDice()
        {
            lblDie1.DataBindings.Clear();
            lblDie1.DataBindings.Add("Text", mainController.CurrentGame.RollInProgress, "DieOne", false, DataSourceUpdateMode.OnPropertyChanged, 0);

            lblDie2.DataBindings.Clear();
            lblDie2.DataBindings.Add("Text", mainController.CurrentGame.RollInProgress, "DieTwo", false, DataSourceUpdateMode.OnPropertyChanged, 0);

            lblPointVal.DataBindings.Clear();
            lblPointVal.DataBindings.Add("Text", mainController.CurrentGame, "Point", false, DataSourceUpdateMode.OnPropertyChanged, 0);
        }

        private void RebindPlayers()
        {
            var playerId = mainController.SelectedPlayer?.Id;
            PlayerListBindingSource.Clear();
            mainController.LoadPlayers_Dev();
            PlayerListBindingSource.DataSource = mainController.Players;
            mainController.SelectedPlayer = mainController.Players.FirstOrDefault(p=>p.Id == playerId);
            PlayerListBox.DataSource = mainController.Players;
            PlayerListBox.DisplayMember = "Name";
          
        }
        private void UpdateGameState()
        {
            lblGameState.DataBindings.Clear();
            lblGameState.DataBindings.Add("Text", mainController, "GameState", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void UpdatePlayerBinding()
        {
            lblPlayerVal.DataBindings.Clear();
            lblPlayerVal.DataBindings.Add("Text", mainController.SelectedPlayer, "Name", false, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
        }
        private void RebindGames()
        {

            txtNewUserName.DataBindings.Clear();
            cmbGames.DataSource = mainController.SelectedPlayer?.Games;
            cmbGames.DisplayMember = "Id";
        }
        private void RebindNewUserText()
        {
            txtNewUserName.DataBindings.Clear();
            txtNewUserName.Text = string.Empty;
            txtNewUserName.DataBindings.Add("Text", mainController.NewPlayer, "Name", false, DataSourceUpdateMode.OnPropertyChanged, string.Empty);

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            mainController.CreateNewUser();
            RebindNewUserText();
            //mainController.SelectedPlayer = mainController.Players.LastOrDefault();
            Application.DoEvents();
        }

        private void btnRollEm_Click(object sender, EventArgs e)
        {
            mainController.Shoot();
            RebindDice();
            UpdateGameState();


        }

        private void DeletePlayerMenuItem_Click(object sender, EventArgs e)
        {
            mainController.DeletePlayer();
            RebindPlayers();
            Application.DoEvents();
        }

        private void PlayerListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var val = (sender as ListBox);
            if (val == null) return;
            var player = val.SelectedItem;
            if (player == null) return;
            mainController.SetSelectedPlayer(player);
        }
    }
}
