namespace CrapsGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.PlayerListBox = new System.Windows.Forms.ListBox();
            this.pnlCreateUser = new System.Windows.Forms.Panel();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGames = new System.Windows.Forms.ComboBox();
            this.GamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlayerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CrapsBoard = new System.Windows.Forms.Panel();
            this.btnRollEm = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblPointVal = new System.Windows.Forms.Label();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.PlayerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeletePlayerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPlayerProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.PlayerPanel.SuspendLayout();
            this.pnlCreateUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerListBindingSource)).BeginInit();
            this.CrapsBoard.SuspendLayout();
            this.PlayerContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.PlayerPanel);
            this.flowLayoutPanel1.Controls.Add(this.CrapsBoard);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 467);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayerPanel.Controls.Add(this.cmbGames);
            this.PlayerPanel.Controls.Add(this.PlayerListBox);
            this.PlayerPanel.Controls.Add(this.pnlCreateUser);
            this.PlayerPanel.Location = new System.Drawing.Point(3, 3);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(203, 458);
            this.PlayerPanel.TabIndex = 1;
            // 
            // PlayerListBox
            // 
            this.PlayerListBox.ContextMenuStrip = this.PlayerContextMenu;
            this.PlayerListBox.FormattingEnabled = true;
            this.PlayerListBox.Location = new System.Drawing.Point(3, 9);
            this.PlayerListBox.Name = "PlayerListBox";
            this.PlayerListBox.Size = new System.Drawing.Size(191, 147);
            this.PlayerListBox.TabIndex = 0;
            // 
            // pnlCreateUser
            // 
            this.pnlCreateUser.Controls.Add(this.label1);
            this.pnlCreateUser.Controls.Add(this.btnAddUser);
            this.pnlCreateUser.Controls.Add(this.txtNewUserName);
            this.pnlCreateUser.Location = new System.Drawing.Point(3, 411);
            this.pnlCreateUser.Name = "pnlCreateUser";
            this.pnlCreateUser.Size = new System.Drawing.Size(200, 47);
            this.pnlCreateUser.TabIndex = 2;
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(7, 20);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(116, 20);
            this.txtNewUserName.TabIndex = 0;
            this.txtNewUserName.TextChanged += new System.EventHandler(this.txtNewUserName_TextChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(129, 17);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(68, 23);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Create";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player\'s Name";
            // 
            // cmbGames
            // 
            this.cmbGames.FormattingEnabled = true;
            this.cmbGames.Location = new System.Drawing.Point(4, 163);
            this.cmbGames.Name = "cmbGames";
            this.cmbGames.Size = new System.Drawing.Size(190, 21);
            this.cmbGames.TabIndex = 3;
            // 
            // CrapsBoard
            // 
            this.CrapsBoard.BackColor = System.Drawing.Color.Green;
            this.CrapsBoard.Controls.Add(this.lblDie2);
            this.CrapsBoard.Controls.Add(this.lblDie1);
            this.CrapsBoard.Controls.Add(this.lblPointVal);
            this.CrapsBoard.Controls.Add(this.lblPoint);
            this.CrapsBoard.Controls.Add(this.btnRollEm);
            this.CrapsBoard.Location = new System.Drawing.Point(212, 3);
            this.CrapsBoard.Name = "CrapsBoard";
            this.CrapsBoard.Size = new System.Drawing.Size(576, 458);
            this.CrapsBoard.TabIndex = 2;
            // 
            // btnRollEm
            // 
            this.btnRollEm.Location = new System.Drawing.Point(59, 428);
            this.btnRollEm.Name = "btnRollEm";
            this.btnRollEm.Size = new System.Drawing.Size(75, 23);
            this.btnRollEm.TabIndex = 0;
            this.btnRollEm.Text = "Roll\'Em";
            this.btnRollEm.UseVisualStyleBackColor = true;
            this.btnRollEm.Click += new System.EventHandler(this.btnRollEm_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(6, 15);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(74, 29);
            this.lblPoint.TabIndex = 1;
            this.lblPoint.Text = "Point:";
            // 
            // lblPointVal
            // 
            this.lblPointVal.AutoSize = true;
            this.lblPointVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointVal.Location = new System.Drawing.Point(80, 15);
            this.lblPointVal.Name = "lblPointVal";
            this.lblPointVal.Size = new System.Drawing.Size(26, 29);
            this.lblPointVal.TabIndex = 2;
            this.lblPointVal.Text = "0";
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1.Location = new System.Drawing.Point(58, 337);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(76, 29);
            this.lblDie1.TabIndex = 3;
            this.lblDie1.Text = "Die#1";
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2.Location = new System.Drawing.Point(183, 337);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(76, 29);
            this.lblDie2.TabIndex = 4;
            this.lblDie2.Text = "Die#2";
            // 
            // PlayerContextMenu
            // 
            this.PlayerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeletePlayerMenuItem,
            this.EditPlayerProfileMenuItem});
            this.PlayerContextMenu.Name = "PlayerContextMenu";
            this.PlayerContextMenu.Size = new System.Drawing.Size(167, 48);
            // 
            // DeletePlayerMenuItem
            // 
            this.DeletePlayerMenuItem.Name = "DeletePlayerMenuItem";
            this.DeletePlayerMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeletePlayerMenuItem.Text = "Delete Player";
            this.DeletePlayerMenuItem.Click += new System.EventHandler(this.DeletePlayerMenuItem_Click);
            // 
            // EditPlayerProfileMenuItem
            // 
            this.EditPlayerProfileMenuItem.Name = "EditPlayerProfileMenuItem";
            this.EditPlayerProfileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditPlayerProfileMenuItem.Text = "Edit Player Profile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PlayerPanel.ResumeLayout(false);
            this.pnlCreateUser.ResumeLayout(false);
            this.pnlCreateUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerListBindingSource)).EndInit();
            this.CrapsBoard.ResumeLayout(false);
            this.CrapsBoard.PerformLayout();
            this.PlayerContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PlayerPanel;
        private System.Windows.Forms.ListBox PlayerListBox;
        private System.Windows.Forms.Panel pnlCreateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.ComboBox cmbGames;
        private System.Windows.Forms.BindingSource GamesBindingSource;
        private System.Windows.Forms.BindingSource PlayerListBindingSource;
        private System.Windows.Forms.Panel CrapsBoard;
        private System.Windows.Forms.Button btnRollEm;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblPointVal;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.ContextMenuStrip PlayerContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeletePlayerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditPlayerProfileMenuItem;
    }
}

