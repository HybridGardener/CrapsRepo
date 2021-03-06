﻿namespace CrapsGame
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
            this.label2 = new System.Windows.Forms.Label();
            this.GamesListBox = new System.Windows.Forms.ListBox();
            this.PlayerListBox = new System.Windows.Forms.ListBox();
            this.PlayerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeletePlayerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPlayerProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPlayersGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCreateUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.CrapsBoard = new System.Windows.Forms.Panel();
            this.lblLossesVal = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblWinsVal = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblPlayerVal = new System.Windows.Forms.Label();
            this.lblGameState = new System.Windows.Forms.Label();
            this.lblPointVal = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnRollEm = new System.Windows.Forms.Button();
            this.GamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlayerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.PlayerPanel.SuspendLayout();
            this.PlayerContextMenu.SuspendLayout();
            this.pnlCreateUser.SuspendLayout();
            this.CrapsBoard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerListBindingSource)).BeginInit();
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(991, 463);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayerPanel.Controls.Add(this.label2);
            this.PlayerPanel.Controls.Add(this.GamesListBox);
            this.PlayerPanel.Controls.Add(this.PlayerListBox);
            this.PlayerPanel.Controls.Add(this.pnlCreateUser);
            this.PlayerPanel.Location = new System.Drawing.Point(3, 3);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(286, 458);
            this.PlayerPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player\'s Game History";
            // 
            // GamesListBox
            // 
            this.GamesListBox.FormattingEnabled = true;
            this.GamesListBox.Location = new System.Drawing.Point(4, 191);
            this.GamesListBox.Name = "GamesListBox";
            this.GamesListBox.Size = new System.Drawing.Size(279, 212);
            this.GamesListBox.TabIndex = 4;
            // 
            // PlayerListBox
            // 
            this.PlayerListBox.ContextMenuStrip = this.PlayerContextMenu;
            this.PlayerListBox.FormattingEnabled = true;
            this.PlayerListBox.Location = new System.Drawing.Point(3, 9);
            this.PlayerListBox.Name = "PlayerListBox";
            this.PlayerListBox.Size = new System.Drawing.Size(280, 160);
            this.PlayerListBox.TabIndex = 0;
            this.PlayerListBox.SelectedValueChanged += new System.EventHandler(this.PlayerListBox_SelectedValueChanged);
            // 
            // PlayerContextMenu
            // 
            this.PlayerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeletePlayerMenuItem,
            this.EditPlayerProfileMenuItem,
            this.clearPlayersGamesToolStripMenuItem});
            this.PlayerContextMenu.Name = "PlayerContextMenu";
            this.PlayerContextMenu.Size = new System.Drawing.Size(184, 70);
            // 
            // DeletePlayerMenuItem
            // 
            this.DeletePlayerMenuItem.Name = "DeletePlayerMenuItem";
            this.DeletePlayerMenuItem.Size = new System.Drawing.Size(183, 22);
            this.DeletePlayerMenuItem.Text = "Delete Player";
            this.DeletePlayerMenuItem.Click += new System.EventHandler(this.DeletePlayerMenuItem_Click);
            // 
            // EditPlayerProfileMenuItem
            // 
            this.EditPlayerProfileMenuItem.Name = "EditPlayerProfileMenuItem";
            this.EditPlayerProfileMenuItem.Size = new System.Drawing.Size(183, 22);
            this.EditPlayerProfileMenuItem.Text = "Edit Player Profile";
            this.EditPlayerProfileMenuItem.Click += new System.EventHandler(this.EditPlayerProfileMenuItem_Click);
            // 
            // clearPlayersGamesToolStripMenuItem
            // 
            this.clearPlayersGamesToolStripMenuItem.Name = "clearPlayersGamesToolStripMenuItem";
            this.clearPlayersGamesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clearPlayersGamesToolStripMenuItem.Text = "Clear Player\'s Games";
            this.clearPlayersGamesToolStripMenuItem.Click += new System.EventHandler(this.clearPlayersGamesToolStripMenuItem_Click);
            // 
            // pnlCreateUser
            // 
            this.pnlCreateUser.Controls.Add(this.label1);
            this.pnlCreateUser.Controls.Add(this.btnAddUser);
            this.pnlCreateUser.Controls.Add(this.txtNewUserName);
            this.pnlCreateUser.Location = new System.Drawing.Point(3, 411);
            this.pnlCreateUser.Name = "pnlCreateUser";
            this.pnlCreateUser.Size = new System.Drawing.Size(280, 47);
            this.pnlCreateUser.TabIndex = 2;
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
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(7, 20);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(116, 20);
            this.txtNewUserName.TabIndex = 0;
            this.txtNewUserName.TextChanged += new System.EventHandler(this.txtNewUserName_TextChanged);
            // 
            // CrapsBoard
            // 
            this.CrapsBoard.BackColor = System.Drawing.Color.Green;
            this.CrapsBoard.Controls.Add(this.lblLossesVal);
            this.CrapsBoard.Controls.Add(this.lblLosses);
            this.CrapsBoard.Controls.Add(this.lblWinsVal);
            this.CrapsBoard.Controls.Add(this.lblWins);
            this.CrapsBoard.Controls.Add(this.panel2);
            this.CrapsBoard.Controls.Add(this.panel1);
            this.CrapsBoard.Controls.Add(this.lblPlayerVal);
            this.CrapsBoard.Controls.Add(this.lblGameState);
            this.CrapsBoard.Controls.Add(this.lblPointVal);
            this.CrapsBoard.Controls.Add(this.lblPoint);
            this.CrapsBoard.Controls.Add(this.btnRollEm);
            this.CrapsBoard.Location = new System.Drawing.Point(295, 3);
            this.CrapsBoard.Name = "CrapsBoard";
            this.CrapsBoard.Size = new System.Drawing.Size(532, 458);
            this.CrapsBoard.TabIndex = 2;
            // 
            // lblLossesVal
            // 
            this.lblLossesVal.AutoSize = true;
            this.lblLossesVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossesVal.Location = new System.Drawing.Point(79, 431);
            this.lblLossesVal.Name = "lblLossesVal";
            this.lblLossesVal.Size = new System.Drawing.Size(18, 20);
            this.lblLossesVal.TabIndex = 13;
            this.lblLossesVal.Text = "0";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.Location = new System.Drawing.Point(13, 431);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(64, 20);
            this.lblLosses.TabIndex = 12;
            this.lblLosses.Text = "Losses:";
            // 
            // lblWinsVal
            // 
            this.lblWinsVal.AutoSize = true;
            this.lblWinsVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinsVal.Location = new System.Drawing.Point(79, 401);
            this.lblWinsVal.Name = "lblWinsVal";
            this.lblWinsVal.Size = new System.Drawing.Size(18, 20);
            this.lblWinsVal.TabIndex = 11;
            this.lblWinsVal.Text = "0";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(13, 401);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(48, 20);
            this.lblWins.TabIndex = 10;
            this.lblWins.Text = "Wins:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDie2);
            this.panel2.Location = new System.Drawing.Point(285, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 107);
            this.panel2.TabIndex = 9;
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.BackColor = System.Drawing.Color.FloralWhite;
            this.lblDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2.Location = new System.Drawing.Point(15, 37);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(76, 29);
            this.lblDie2.TabIndex = 4;
            this.lblDie2.Text = "Die#2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDie1);
            this.panel1.Location = new System.Drawing.Point(108, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 107);
            this.panel1.TabIndex = 8;
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1.Location = new System.Drawing.Point(16, 37);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(76, 29);
            this.lblDie1.TabIndex = 3;
            this.lblDie1.Text = "Die#1";
            // 
            // lblPlayerVal
            // 
            this.lblPlayerVal.AutoSize = true;
            this.lblPlayerVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerVal.Location = new System.Drawing.Point(240, 9);
            this.lblPlayerVal.Name = "lblPlayerVal";
            this.lblPlayerVal.Size = new System.Drawing.Size(27, 29);
            this.lblPlayerVal.TabIndex = 7;
            this.lblPlayerVal.Text = "p";
            // 
            // lblGameState
            // 
            this.lblGameState.AutoSize = true;
            this.lblGameState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameState.Location = new System.Drawing.Point(186, 112);
            this.lblGameState.Name = "lblGameState";
            this.lblGameState.Size = new System.Drawing.Size(134, 29);
            this.lblGameState.TabIndex = 5;
            this.lblGameState.Text = "New Game";
            // 
            // lblPointVal
            // 
            this.lblPointVal.AutoSize = true;
            this.lblPointVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointVal.Location = new System.Drawing.Point(103, 9);
            this.lblPointVal.Name = "lblPointVal";
            this.lblPointVal.Size = new System.Drawing.Size(26, 29);
            this.lblPointVal.TabIndex = 2;
            this.lblPointVal.Text = "0";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(23, 9);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(74, 29);
            this.lblPoint.TabIndex = 1;
            this.lblPoint.Text = "Point:";
            // 
            // btnRollEm
            // 
            this.btnRollEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollEm.Location = new System.Drawing.Point(205, 362);
            this.btnRollEm.Name = "btnRollEm";
            this.btnRollEm.Size = new System.Drawing.Size(90, 41);
            this.btnRollEm.TabIndex = 0;
            this.btnRollEm.Text = "Roll\'Em";
            this.btnRollEm.UseVisualStyleBackColor = true;
            this.btnRollEm.Click += new System.EventHandler(this.btnRollEm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 461);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(842, 500);
            this.MinimumSize = new System.Drawing.Size(842, 500);
            this.Name = "Form1";
            this.Text = "Craps";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PlayerPanel.ResumeLayout(false);
            this.PlayerPanel.PerformLayout();
            this.PlayerContextMenu.ResumeLayout(false);
            this.pnlCreateUser.ResumeLayout(false);
            this.pnlCreateUser.PerformLayout();
            this.CrapsBoard.ResumeLayout(false);
            this.CrapsBoard.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerListBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblGameState;
        private System.Windows.Forms.Label lblPlayerVal;
        private System.Windows.Forms.ToolStripMenuItem clearPlayersGamesToolStripMenuItem;
        private System.Windows.Forms.Label lblLossesVal;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblWinsVal;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox GamesListBox;
        private System.Windows.Forms.Label label2;
    }
}

