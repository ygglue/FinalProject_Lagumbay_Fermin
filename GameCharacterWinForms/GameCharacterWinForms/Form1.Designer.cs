namespace GameCharacterWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelMana = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.cmbCharacterType = new System.Windows.Forms.ComboBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.listBoxCharacters = new System.Windows.Forms.ListBox();
            this.btnSelectCharacter = new System.Windows.Forms.Button();
            this.txtCharacterDetails = new System.Windows.Forms.TextBox();
            this.battleLog = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.playerPic = new System.Windows.Forms.PictureBox();
            this.enemyPic = new System.Windows.Forms.PictureBox();
            this.bg = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(116, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 12);
            this.txtName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(44, 87);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 12);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.ForeColor = System.Drawing.Color.White;
            this.txtLevel.Location = new System.Drawing.Point(116, 106);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(139, 12);
            this.txtLevel.TabIndex = 2;
            // 
            // txtHealth
            // 
            this.txtHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.txtHealth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHealth.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealth.ForeColor = System.Drawing.Color.White;
            this.txtHealth.Location = new System.Drawing.Point(116, 125);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(139, 12);
            this.txtHealth.TabIndex = 3;
            // 
            // txtStrength
            // 
            this.txtStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrength.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrength.ForeColor = System.Drawing.Color.White;
            this.txtStrength.Location = new System.Drawing.Point(116, 144);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(139, 12);
            this.txtStrength.TabIndex = 4;
            // 
            // txtMana
            // 
            this.txtMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.txtMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMana.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMana.ForeColor = System.Drawing.Color.White;
            this.txtMana.Location = new System.Drawing.Point(116, 163);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(139, 12);
            this.txtMana.TabIndex = 5;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.White;
            this.labelLevel.Location = new System.Drawing.Point(44, 106);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(31, 12);
            this.labelLevel.TabIndex = 6;
            this.labelLevel.Text = "Level";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.ForeColor = System.Drawing.Color.White;
            this.labelHealth.Location = new System.Drawing.Point(44, 125);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(37, 12);
            this.labelHealth.TabIndex = 7;
            this.labelHealth.Text = "Health";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrength.ForeColor = System.Drawing.Color.White;
            this.labelStrength.Location = new System.Drawing.Point(44, 144);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(50, 12);
            this.labelStrength.TabIndex = 8;
            this.labelStrength.Text = "Strength";
            // 
            // labelMana
            // 
            this.labelMana.AutoSize = true;
            this.labelMana.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMana.ForeColor = System.Drawing.Color.White;
            this.labelMana.Location = new System.Drawing.Point(44, 163);
            this.labelMana.Name = "labelMana";
            this.labelMana.Size = new System.Drawing.Size(33, 12);
            this.labelMana.TabIndex = 9;
            this.labelMana.Text = "Mana";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntelligence.ForeColor = System.Drawing.Color.White;
            this.labelIntelligence.Location = new System.Drawing.Point(44, 182);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(65, 12);
            this.labelIntelligence.TabIndex = 10;
            this.labelIntelligence.Text = "Intelligence";
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.txtIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntelligence.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntelligence.ForeColor = System.Drawing.Color.White;
            this.txtIntelligence.Location = new System.Drawing.Point(116, 182);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(139, 12);
            this.txtIntelligence.TabIndex = 11;
            // 
            // cmbCharacterType
            // 
            this.cmbCharacterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.cmbCharacterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacterType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCharacterType.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCharacterType.FormattingEnabled = true;
            this.cmbCharacterType.Items.AddRange(new object[] {
            "--Select Type--",
            "Mage",
            "Warrior"});
            this.cmbCharacterType.Location = new System.Drawing.Point(47, 51);
            this.cmbCharacterType.Name = "cmbCharacterType";
            this.cmbCharacterType.Size = new System.Drawing.Size(208, 20);
            this.cmbCharacterType.TabIndex = 12;
            this.cmbCharacterType.SelectedIndexChanged += new System.EventHandler(this.cmbCharacterType_SelectedIndexChanged);
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btnAddCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCharacter.Font = new System.Drawing.Font("DePixel", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCharacter.ForeColor = System.Drawing.Color.White;
            this.btnAddCharacter.Location = new System.Drawing.Point(47, 237);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(208, 30);
            this.btnAddCharacter.TabIndex = 13;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = false;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // listBoxCharacters
            // 
            this.listBoxCharacters.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCharacters.FormattingEnabled = true;
            this.listBoxCharacters.ItemHeight = 12;
            this.listBoxCharacters.Location = new System.Drawing.Point(47, 319);
            this.listBoxCharacters.Name = "listBoxCharacters";
            this.listBoxCharacters.Size = new System.Drawing.Size(208, 220);
            this.listBoxCharacters.TabIndex = 14;
            // 
            // btnSelectCharacter
            // 
            this.btnSelectCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btnSelectCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectCharacter.Font = new System.Drawing.Font("DePixel", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCharacter.ForeColor = System.Drawing.Color.White;
            this.btnSelectCharacter.Location = new System.Drawing.Point(47, 536);
            this.btnSelectCharacter.Name = "btnSelectCharacter";
            this.btnSelectCharacter.Size = new System.Drawing.Size(208, 30);
            this.btnSelectCharacter.TabIndex = 15;
            this.btnSelectCharacter.Text = "Select Character";
            this.btnSelectCharacter.UseVisualStyleBackColor = false;
            this.btnSelectCharacter.Click += new System.EventHandler(this.btnSelectCharacter_Click);
            // 
            // txtCharacterDetails
            // 
            this.txtCharacterDetails.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterDetails.Location = new System.Drawing.Point(281, 51);
            this.txtCharacterDetails.Multiline = true;
            this.txtCharacterDetails.Name = "txtCharacterDetails";
            this.txtCharacterDetails.ReadOnly = true;
            this.txtCharacterDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCharacterDetails.Size = new System.Drawing.Size(176, 464);
            this.txtCharacterDetails.TabIndex = 16;
            // 
            // battleLog
            // 
            this.battleLog.Font = new System.Drawing.Font("DePixel", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleLog.FormattingEnabled = true;
            this.battleLog.ItemHeight = 12;
            this.battleLog.Location = new System.Drawing.Point(463, 51);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(174, 448);
            this.battleLog.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnLevelUp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDefend, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAttack, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(277, 498);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 72);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btnLevelUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLevelUp.Font = new System.Drawing.Font("DePixel", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelUp.ForeColor = System.Drawing.Color.White;
            this.btnLevelUp.Location = new System.Drawing.Point(245, 3);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(116, 66);
            this.btnLevelUp.TabIndex = 2;
            this.btnLevelUp.Text = "Level Up";
            this.btnLevelUp.UseVisualStyleBackColor = false;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btnDefend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDefend.Font = new System.Drawing.Font("DePixel", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefend.ForeColor = System.Drawing.Color.White;
            this.btnDefend.Location = new System.Drawing.Point(124, 3);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(115, 66);
            this.btnDefend.TabIndex = 1;
            this.btnDefend.Text = "Defend";
            this.btnDefend.UseVisualStyleBackColor = false;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttack.Font = new System.Drawing.Font("DePixel", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.Color.White;
            this.btnAttack.Location = new System.Drawing.Point(3, 3);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(115, 66);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // playerPic
            // 
            this.playerPic.Image = global::GameCharacterWinForms.Properties.Resources.priest1_v1_1;
            this.playerPic.Location = new System.Drawing.Point(795, 291);
            this.playerPic.Name = "playerPic";
            this.playerPic.Size = new System.Drawing.Size(64, 64);
            this.playerPic.TabIndex = 21;
            this.playerPic.TabStop = false;
            // 
            // enemyPic
            // 
            this.enemyPic.BackColor = System.Drawing.Color.Transparent;
            this.enemyPic.Image = ((System.Drawing.Image)(resources.GetObject("enemyPic.Image")));
            this.enemyPic.Location = new System.Drawing.Point(859, 291);
            this.enemyPic.Name = "enemyPic";
            this.enemyPic.Size = new System.Drawing.Size(64, 64);
            this.enemyPic.TabIndex = 20;
            this.enemyPic.TabStop = false;
            // 
            // bg
            // 
            this.bg.BackColor = System.Drawing.Color.Transparent;
            this.bg.Image = global::GameCharacterWinForms.Properties.Resources.bg1;
            this.bg.Location = new System.Drawing.Point(668, 163);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(383, 320);
            this.bg.TabIndex = 19;
            this.bg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(19)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1099, 610);
            this.Controls.Add(this.playerPic);
            this.Controls.Add(this.enemyPic);
            this.Controls.Add(this.bg);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.txtCharacterDetails);
            this.Controls.Add(this.btnSelectCharacter);
            this.Controls.Add(this.listBoxCharacters);
            this.Controls.Add(this.btnAddCharacter);
            this.Controls.Add(this.cmbCharacterType);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.labelIntelligence);
            this.Controls.Add(this.labelMana);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game Character";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelMana;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.ComboBox cmbCharacterType;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.ListBox listBoxCharacters;
        private System.Windows.Forms.Button btnSelectCharacter;
        private System.Windows.Forms.TextBox txtCharacterDetails;
        private System.Windows.Forms.ListBox battleLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.PictureBox enemyPic;
        private System.Windows.Forms.PictureBox playerPic;
    }
}

