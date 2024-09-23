namespace Tic_Tac_Toe_game
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
            this.lblRestGame = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestGame
            // 
            this.lblRestGame.BackColor = System.Drawing.Color.Lime;
            this.lblRestGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestGame.ForeColor = System.Drawing.Color.Red;
            this.lblRestGame.Location = new System.Drawing.Point(36, 363);
            this.lblRestGame.Name = "lblRestGame";
            this.lblRestGame.Size = new System.Drawing.Size(190, 80);
            this.lblRestGame.TabIndex = 0;
            this.lblRestGame.Text = "Restart Game";
            this.lblRestGame.UseVisualStyleBackColor = false;
            this.lblRestGame.Click += new System.EventHandler(this.lblRestGame_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Red;
            this.lblTurn.Location = new System.Drawing.Point(12, 134);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(88, 38);
            this.lblTurn.TabIndex = 12;
            this.lblTurn.Text = "Turn";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Sylfaen", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer.Location = new System.Drawing.Point(51, 172);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(135, 52);
            this.lblPlayer.TabIndex = 13;
            this.lblPlayer.Text = "Player";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(42, 299);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(184, 38);
            this.lblWinner.TabIndex = 14;
            this.lblWinner.Text = "inProgress";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblstatus.Location = new System.Drawing.Point(3, 238);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(165, 51);
            this.lblstatus.TabIndex = 15;
            this.lblstatus.Text = "Winner";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(318, 9);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(535, 81);
            this.lblHead.TabIndex = 16;
            this.lblHead.Text = "Tic-Tac-Toe Game";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 460);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe_game.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(692, 381);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 93);
            this.button10.TabIndex = 9;
            this.button10.Tag = "?";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(525, 382);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 93);
            this.button9.TabIndex = 8;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(354, 382);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 93);
            this.button8.TabIndex = 7;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(692, 260);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 93);
            this.button7.TabIndex = 6;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(513, 260);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 93);
            this.button6.TabIndex = 5;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(692, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 93);
            this.button5.TabIndex = 4;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(513, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 93);
            this.button4.TabIndex = 3;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(354, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 93);
            this.button3.TabIndex = 2;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Tic_Tac_Toe_game.Properties.Resources.question2;
            this.button2.Location = new System.Drawing.Point(354, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 93);
            this.button2.TabIndex = 1;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(939, 576);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblRestGame);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Teo Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblRestGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblHead;
    }
}

