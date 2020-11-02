namespace WinFormUI
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
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.monstersLabel = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.moveNorthButton = new System.Windows.Forms.Button();
            this.moveEastButton = new System.Windows.Forms.Button();
            this.moveWestButton = new System.Windows.Forms.Button();
            this.moveSouthButton = new System.Windows.Forms.Button();
            this.roomDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.monsterRichTextBox = new System.Windows.Forms.RichTextBox();
            this.playerInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.inventoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.equipedWeaponLabel = new System.Windows.Forms.Label();
            this.equipedWeaponComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(104, 9);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(48, 13);
            this.roomDescriptionLabel.TabIndex = 0;
            this.roomDescriptionLabel.Text = "Location";
            // 
            // monstersLabel
            // 
            this.monstersLabel.AutoSize = true;
            this.monstersLabel.Location = new System.Drawing.Point(516, 9);
            this.monstersLabel.Name = "monstersLabel";
            this.monstersLabel.Size = new System.Drawing.Size(50, 13);
            this.monstersLabel.TabIndex = 1;
            this.monstersLabel.Text = "Monsters";
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(500, 127);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 4;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // moveNorthButton
            // 
            this.moveNorthButton.Location = new System.Drawing.Point(92, 199);
            this.moveNorthButton.Name = "moveNorthButton";
            this.moveNorthButton.Size = new System.Drawing.Size(75, 23);
            this.moveNorthButton.TabIndex = 5;
            this.moveNorthButton.Text = "Move North";
            this.moveNorthButton.UseVisualStyleBackColor = true;
            this.moveNorthButton.Click += new System.EventHandler(this.moveNorthButton_Click);
            // 
            // moveEastButton
            // 
            this.moveEastButton.Location = new System.Drawing.Point(162, 251);
            this.moveEastButton.Name = "moveEastButton";
            this.moveEastButton.Size = new System.Drawing.Size(75, 23);
            this.moveEastButton.TabIndex = 6;
            this.moveEastButton.Text = "Move East";
            this.moveEastButton.UseVisualStyleBackColor = true;
            this.moveEastButton.Click += new System.EventHandler(this.moveEastButton_Click);
            // 
            // moveWestButton
            // 
            this.moveWestButton.Location = new System.Drawing.Point(12, 251);
            this.moveWestButton.Name = "moveWestButton";
            this.moveWestButton.Size = new System.Drawing.Size(75, 23);
            this.moveWestButton.TabIndex = 7;
            this.moveWestButton.Text = "Move West";
            this.moveWestButton.UseVisualStyleBackColor = true;
            this.moveWestButton.Click += new System.EventHandler(this.moveWestButton_Click);
            // 
            // moveSouthButton
            // 
            this.moveSouthButton.Location = new System.Drawing.Point(92, 311);
            this.moveSouthButton.Name = "moveSouthButton";
            this.moveSouthButton.Size = new System.Drawing.Size(75, 23);
            this.moveSouthButton.TabIndex = 8;
            this.moveSouthButton.Text = "Move South";
            this.moveSouthButton.UseVisualStyleBackColor = true;
            this.moveSouthButton.Click += new System.EventHandler(this.moveSouthButton_Click);
            // 
            // roomDescriptionBox
            // 
            this.roomDescriptionBox.Location = new System.Drawing.Point(16, 31);
            this.roomDescriptionBox.Name = "roomDescriptionBox";
            this.roomDescriptionBox.Size = new System.Drawing.Size(227, 69);
            this.roomDescriptionBox.TabIndex = 9;
            this.roomDescriptionBox.Text = "";
            // 
            // monsterRichTextBox
            // 
            this.monsterRichTextBox.Location = new System.Drawing.Point(450, 31);
            this.monsterRichTextBox.Name = "monsterRichTextBox";
            this.monsterRichTextBox.Size = new System.Drawing.Size(173, 69);
            this.monsterRichTextBox.TabIndex = 10;
            this.monsterRichTextBox.Text = "";
            // 
            // playerInfoRichTextBox
            // 
            this.playerInfoRichTextBox.Location = new System.Drawing.Point(357, 265);
            this.playerInfoRichTextBox.Name = "playerInfoRichTextBox";
            this.playerInfoRichTextBox.Size = new System.Drawing.Size(266, 115);
            this.playerInfoRichTextBox.TabIndex = 11;
            this.playerInfoRichTextBox.Text = "";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(443, 246);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(91, 13);
            this.playerLabel.TabIndex = 12;
            this.playerLabel.Text = "Player Information";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(463, 433);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 13;
            this.inventoryLabel.Text = "Inventory";
            // 
            // inventoryRichTextBox
            // 
            this.inventoryRichTextBox.Location = new System.Drawing.Point(357, 449);
            this.inventoryRichTextBox.Name = "inventoryRichTextBox";
            this.inventoryRichTextBox.Size = new System.Drawing.Size(266, 115);
            this.inventoryRichTextBox.TabIndex = 14;
            this.inventoryRichTextBox.Text = "";
            // 
            // equipedWeaponLabel
            // 
            this.equipedWeaponLabel.AutoSize = true;
            this.equipedWeaponLabel.Location = new System.Drawing.Point(375, 111);
            this.equipedWeaponLabel.Name = "equipedWeaponLabel";
            this.equipedWeaponLabel.Size = new System.Drawing.Size(90, 13);
            this.equipedWeaponLabel.TabIndex = 15;
            this.equipedWeaponLabel.Text = "Equiped Weapon";
            // 
            // equipedWeaponComboBox
            // 
            this.equipedWeaponComboBox.FormattingEnabled = true;
            this.equipedWeaponComboBox.Location = new System.Drawing.Point(357, 128);
            this.equipedWeaponComboBox.Name = "equipedWeaponComboBox";
            this.equipedWeaponComboBox.Size = new System.Drawing.Size(121, 21);
            this.equipedWeaponComboBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 674);
            this.Controls.Add(this.equipedWeaponComboBox);
            this.Controls.Add(this.equipedWeaponLabel);
            this.Controls.Add(this.inventoryRichTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.playerInfoRichTextBox);
            this.Controls.Add(this.monsterRichTextBox);
            this.Controls.Add(this.roomDescriptionBox);
            this.Controls.Add(this.moveSouthButton);
            this.Controls.Add(this.moveWestButton);
            this.Controls.Add(this.moveEastButton);
            this.Controls.Add(this.moveNorthButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.monstersLabel);
            this.Controls.Add(this.roomDescriptionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.Label monstersLabel;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button moveNorthButton;
        private System.Windows.Forms.Button moveEastButton;
        private System.Windows.Forms.Button moveWestButton;
        private System.Windows.Forms.Button moveSouthButton;
        private System.Windows.Forms.RichTextBox roomDescriptionBox;
        private System.Windows.Forms.RichTextBox monsterRichTextBox;
        private System.Windows.Forms.RichTextBox playerInfoRichTextBox;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.RichTextBox inventoryRichTextBox;
        private System.Windows.Forms.Label equipedWeaponLabel;
        private System.Windows.Forms.ComboBox equipedWeaponComboBox;
    }
}

