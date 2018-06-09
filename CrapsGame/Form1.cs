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
            ReloadPlayers();
            mainController.SelectedPlayer = mainController.Players.FirstOrDefault(p=>p.Id == playerId);
            PlayerListBox.DataSource = mainController.Players;
            PlayerListBox.DisplayMember = "Name";
          
        }

        private void ReloadPlayers()
        {
            mainController.LoadPlayers();
        }

        private void RebindGames()
        {

            txtNewUserName.DataBindings.Clear();
            cmbGames.DataSource = mainController.SelectedPlayer?.Games;
            cmbGames.DisplayMember = "Id";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            mainController.CreateNewUser();
            txtNewUserName.Text = string.Empty;
            txtNewUserName.DataBindings.Clear();
            txtNewUserName.DataBindings.Add("Text", mainController.NewPlayer, "Name", false, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            RebindPlayers();
            Application.DoEvents();
        }

        private void btnRollEm_Click(object sender, EventArgs e)
        {
            mainController.CurrentGame.Shoot();
            mainController.SaveGame(mainController.CurrentGame);
            RebindDice();
        }

        private void DeletePlayerMenuItem_Click(object sender, EventArgs e)
        {
            mainController.DeletePlayer();
            RebindPlayers();
            Application.DoEvents();
        }
    }
}
