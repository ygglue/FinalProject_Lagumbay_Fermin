namespace SlotMachine
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.betBox = new System.Windows.Forms.TextBox();
            this.bet = new System.Windows.Forms.Label();
            this.bal = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.defaultRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jewelRadio = new System.Windows.Forms.RadioButton();
            this.animalRadio = new System.Windows.Forms.RadioButton();
            this.lever = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bg_pic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lever)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // betBox
            // 
            this.betBox.BackColor = System.Drawing.SystemColors.Window;
            this.betBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betBox.Font = new System.Drawing.Font("DePixel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betBox.ForeColor = System.Drawing.Color.White;
            this.betBox.Location = new System.Drawing.Point(160, 568);
            this.betBox.Name = "betBox";
            this.betBox.Size = new System.Drawing.Size(105, 36);
            this.betBox.TabIndex = 3;
            this.betBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bet
            // 
            this.bet.AutoSize = true;
            this.bet.BackColor = System.Drawing.Color.Transparent;
            this.bet.Font = new System.Drawing.Font("DePixel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet.ForeColor = System.Drawing.Color.White;
            this.bet.Location = new System.Drawing.Point(77, 568);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(74, 37);
            this.bet.TabIndex = 4;
            this.bet.Text = "BET:";
            // 
            // bal
            // 
            this.bal.AutoSize = true;
            this.bal.BackColor = System.Drawing.Color.Transparent;
            this.bal.Font = new System.Drawing.Font("DePixel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bal.ForeColor = System.Drawing.Color.White;
            this.bal.Location = new System.Drawing.Point(280, 568);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(83, 37);
            this.bal.TabIndex = 4;
            this.bal.Text = "BAL: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("DePixel", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(114, 82);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(66, 37);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "       ";
            // 
            // defaultRadio
            // 
            this.defaultRadio.AutoSize = true;
            this.defaultRadio.BackColor = System.Drawing.Color.Transparent;
            this.defaultRadio.ForeColor = System.Drawing.Color.White;
            this.defaultRadio.Location = new System.Drawing.Point(7, 19);
            this.defaultRadio.Name = "defaultRadio";
            this.defaultRadio.Size = new System.Drawing.Size(95, 17);
            this.defaultRadio.TabIndex = 5;
            this.defaultRadio.TabStop = true;
            this.defaultRadio.Text = "Default Theme";
            this.defaultRadio.UseVisualStyleBackColor = false;
            this.defaultRadio.CheckedChanged += new System.EventHandler(this.fruitRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.jewelRadio);
            this.groupBox1.Controls.Add(this.animalRadio);
            this.groupBox1.Controls.Add(this.defaultRadio);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(564, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theme";
            // 
            // jewelRadio
            // 
            this.jewelRadio.AutoSize = true;
            this.jewelRadio.Location = new System.Drawing.Point(7, 65);
            this.jewelRadio.Name = "jewelRadio";
            this.jewelRadio.Size = new System.Drawing.Size(88, 17);
            this.jewelRadio.TabIndex = 6;
            this.jewelRadio.TabStop = true;
            this.jewelRadio.Text = "Jewel Theme";
            this.jewelRadio.UseVisualStyleBackColor = true;
            this.jewelRadio.CheckedChanged += new System.EventHandler(this.jewelRadio_CheckedChanged);
            // 
            // animalRadio
            // 
            this.animalRadio.AutoSize = true;
            this.animalRadio.Location = new System.Drawing.Point(7, 42);
            this.animalRadio.Name = "animalRadio";
            this.animalRadio.Size = new System.Drawing.Size(92, 17);
            this.animalRadio.TabIndex = 6;
            this.animalRadio.TabStop = true;
            this.animalRadio.Text = "Animal Theme";
            this.animalRadio.UseVisualStyleBackColor = true;
            this.animalRadio.CheckedChanged += new System.EventHandler(this.animalRadio_CheckedChanged);
            // 
            // lever
            // 
            this.lever.Image = global::SlotMachine.Properties.Resources.slot_machine2;
            this.lever.Location = new System.Drawing.Point(532, 283);
            this.lever.Name = "lever";
            this.lever.Size = new System.Drawing.Size(100, 324);
            this.lever.TabIndex = 2;
            this.lever.TabStop = false;
            this.lever.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SlotMachine.Properties.Resources.slot_symbol1;
            this.pictureBox3.Location = new System.Drawing.Point(352, 281);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 106);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SlotMachine.Properties.Resources.slot_symbol1;
            this.pictureBox2.Location = new System.Drawing.Point(222, 281);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 106);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlotMachine.Properties.Resources.slot_symbol1;
            this.pictureBox1.Location = new System.Drawing.Point(92, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 106);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bg_pic
            // 
            this.bg_pic.BackgroundImage = global::SlotMachine.Properties.Resources.slot_machine1;
            this.bg_pic.Location = new System.Drawing.Point(-138, -12);
            this.bg_pic.Name = "bg_pic";
            this.bg_pic.Size = new System.Drawing.Size(761, 619);
            this.bg_pic.TabIndex = 0;
            this.bg_pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(681, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.betBox);
            this.Controls.Add(this.lever);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bg_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lever)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg_pic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox lever;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox betBox;
        private System.Windows.Forms.Label bet;
        private System.Windows.Forms.Label bal;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton defaultRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton animalRadio;
        private System.Windows.Forms.RadioButton jewelRadio;
    }
}

