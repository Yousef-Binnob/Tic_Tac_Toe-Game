
namespace Tic_Tac_Toe
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
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBox9 = new System.Windows.Forms.Button();
            this.btnBox8 = new System.Windows.Forms.Button();
            this.btnBox6 = new System.Windows.Forms.Button();
            this.btnBox5 = new System.Windows.Forms.Button();
            this.btnBox7 = new System.Windows.Forms.Button();
            this.btnBox3 = new System.Windows.Forms.Button();
            this.btnBox4 = new System.Windows.Forms.Button();
            this.btnBox2 = new System.Windows.Forms.Button();
            this.btnBox1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Font = new System.Drawing.Font("Bauhaus 93", 20F);
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(32, 417);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(279, 70);
            this.btnRestartGame.TabIndex = 7;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(74, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 59);
            this.label3.TabIndex = 3;
            this.label3.Text = "Winner";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Bauhaus 93", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Green;
            this.lblWinner.Location = new System.Drawing.Point(30, 308);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(272, 59);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Bauhaus 93", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(58, 150);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(217, 59);
            this.lblTurn.TabIndex = 5;
            this.lblTurn.Tag = "1";
            this.lblTurn.Text = "Player 1";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(104, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 59);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // btnBox9
            // 
            this.btnBox9.BackColor = System.Drawing.Color.Transparent;
            this.btnBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox9.BackgroundImage")));
            this.btnBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox9.ForeColor = System.Drawing.Color.Black;
            this.btnBox9.Image = ((System.Drawing.Image)(resources.GetObject("btnBox9.Image")));
            this.btnBox9.Location = new System.Drawing.Point(783, 451);
            this.btnBox9.Name = "btnBox9";
            this.btnBox9.Size = new System.Drawing.Size(75, 75);
            this.btnBox9.TabIndex = 9;
            this.btnBox9.Tag = "?";
            this.btnBox9.UseVisualStyleBackColor = false;
            this.btnBox9.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnBox8
            // 
            this.btnBox8.BackColor = System.Drawing.Color.Transparent;
            this.btnBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox8.BackgroundImage")));
            this.btnBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox8.ForeColor = System.Drawing.Color.Black;
            this.btnBox8.Image = ((System.Drawing.Image)(resources.GetObject("btnBox8.Image")));
            this.btnBox8.Location = new System.Drawing.Point(626, 451);
            this.btnBox8.Name = "btnBox8";
            this.btnBox8.Size = new System.Drawing.Size(75, 75);
            this.btnBox8.TabIndex = 9;
            this.btnBox8.Tag = "?";
            this.btnBox8.UseVisualStyleBackColor = false;
            this.btnBox8.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnBox6
            // 
            this.btnBox6.BackColor = System.Drawing.Color.Transparent;
            this.btnBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox6.BackgroundImage")));
            this.btnBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox6.ForeColor = System.Drawing.Color.Black;
            this.btnBox6.Image = ((System.Drawing.Image)(resources.GetObject("btnBox6.Image")));
            this.btnBox6.Location = new System.Drawing.Point(783, 316);
            this.btnBox6.Name = "btnBox6";
            this.btnBox6.Size = new System.Drawing.Size(75, 75);
            this.btnBox6.TabIndex = 9;
            this.btnBox6.Tag = "?";
            this.btnBox6.UseVisualStyleBackColor = false;
            this.btnBox6.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnBox5
            // 
            this.btnBox5.BackColor = System.Drawing.Color.Transparent;
            this.btnBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox5.BackgroundImage")));
            this.btnBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox5.ForeColor = System.Drawing.Color.Black;
            this.btnBox5.Image = ((System.Drawing.Image)(resources.GetObject("btnBox5.Image")));
            this.btnBox5.Location = new System.Drawing.Point(626, 316);
            this.btnBox5.Name = "btnBox5";
            this.btnBox5.Size = new System.Drawing.Size(75, 75);
            this.btnBox5.TabIndex = 9;
            this.btnBox5.Tag = "?";
            this.btnBox5.UseVisualStyleBackColor = false;
            this.btnBox5.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnBox7
            // 
            this.btnBox7.BackColor = System.Drawing.Color.Transparent;
            this.btnBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox7.BackgroundImage")));
            this.btnBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox7.ForeColor = System.Drawing.Color.Black;
            this.btnBox7.Image = ((System.Drawing.Image)(resources.GetObject("btnBox7.Image")));
            this.btnBox7.Location = new System.Drawing.Point(464, 451);
            this.btnBox7.Name = "btnBox7";
            this.btnBox7.Size = new System.Drawing.Size(75, 75);
            this.btnBox7.TabIndex = 9;
            this.btnBox7.Tag = "?";
            this.btnBox7.UseVisualStyleBackColor = false;
            this.btnBox7.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnBox3
            // 
            this.btnBox3.BackColor = System.Drawing.Color.Transparent;
            this.btnBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox3.BackgroundImage")));
            this.btnBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox3.ForeColor = System.Drawing.Color.Black;
            this.btnBox3.Location = new System.Drawing.Point(783, 181);
            this.btnBox3.Name = "btnBox3";
            this.btnBox3.Size = new System.Drawing.Size(75, 75);
            this.btnBox3.TabIndex = 9;
            this.btnBox3.Tag = "?";
            this.btnBox3.UseVisualStyleBackColor = false;
            this.btnBox3.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnBox4
            // 
            this.btnBox4.BackColor = System.Drawing.Color.Transparent;
            this.btnBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox4.BackgroundImage")));
            this.btnBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox4.ForeColor = System.Drawing.Color.Black;
            this.btnBox4.Image = ((System.Drawing.Image)(resources.GetObject("btnBox4.Image")));
            this.btnBox4.Location = new System.Drawing.Point(464, 316);
            this.btnBox4.Name = "btnBox4";
            this.btnBox4.Size = new System.Drawing.Size(75, 75);
            this.btnBox4.TabIndex = 9;
            this.btnBox4.Tag = "?";
            this.btnBox4.UseVisualStyleBackColor = false;
            this.btnBox4.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnBox2
            // 
            this.btnBox2.BackColor = System.Drawing.Color.Transparent;
            this.btnBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox2.BackgroundImage")));
            this.btnBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox2.ForeColor = System.Drawing.Color.Black;
            this.btnBox2.Location = new System.Drawing.Point(626, 181);
            this.btnBox2.Name = "btnBox2";
            this.btnBox2.Size = new System.Drawing.Size(75, 75);
            this.btnBox2.TabIndex = 9;
            this.btnBox2.Tag = "?";
            this.btnBox2.UseVisualStyleBackColor = false;
            this.btnBox2.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnBox1
            // 
            this.btnBox1.BackColor = System.Drawing.Color.Transparent;
            this.btnBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBox1.BackgroundImage")));
            this.btnBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox1.ForeColor = System.Drawing.Color.Black;
            this.btnBox1.Location = new System.Drawing.Point(464, 181);
            this.btnBox1.Name = "btnBox1";
            this.btnBox1.Size = new System.Drawing.Size(75, 75);
            this.btnBox1.TabIndex = 9;
            this.btnBox1.Tag = "?";
            this.btnBox1.UseVisualStyleBackColor = false;
            this.btnBox1.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(993, 607);
            this.Controls.Add(this.btnBox9);
            this.Controls.Add(this.btnBox8);
            this.Controls.Add(this.btnBox6);
            this.Controls.Add(this.btnBox5);
            this.Controls.Add(this.btnBox7);
            this.Controls.Add(this.btnBox3);
            this.Controls.Add(this.btnBox4);
            this.Controls.Add(this.btnBox2);
            this.Controls.Add(this.btnBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ti-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBox1;
        private System.Windows.Forms.Button btnBox2;
        private System.Windows.Forms.Button btnBox3;
        private System.Windows.Forms.Button btnBox4;
        private System.Windows.Forms.Button btnBox5;
        private System.Windows.Forms.Button btnBox6;
        private System.Windows.Forms.Button btnBox7;
        private System.Windows.Forms.Button btnBox8;
        private System.Windows.Forms.Button btnBox9;
    }
}

