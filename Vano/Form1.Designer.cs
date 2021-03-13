
namespace Vano
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.platform = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.door = new System.Windows.Forms.PictureBox();
            this.coin = new System.Windows.Forms.PictureBox();
            this.Scoretxt = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.Horizontaal = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontaal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.SeaGreen;
            this.platform.Location = new System.Drawing.Point(-16, 568);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(519, 50);
            this.platform.TabIndex = 0;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(610, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Red;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.InitialImage = ((System.Drawing.Image)(resources.GetObject("player.InitialImage")));
            this.player.Location = new System.Drawing.Point(51, 518);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 50);
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Magenta;
            this.door.Location = new System.Drawing.Point(2, 79);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(46, 71);
            this.door.TabIndex = 3;
            this.door.TabStop = false;
            this.door.Click += new System.EventHandler(this.door_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Red;
            this.coin.Location = new System.Drawing.Point(406, 198);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(20, 20);
            this.coin.TabIndex = 4;
            this.coin.TabStop = false;
            this.coin.Tag = "coin";
            this.coin.Click += new System.EventHandler(this.coin_Click);
            // 
            // Scoretxt
            // 
            this.Scoretxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretxt.Location = new System.Drawing.Point(283, 9);
            this.Scoretxt.Name = "Scoretxt";
            this.Scoretxt.Size = new System.Drawing.Size(200, 23);
            this.Scoretxt.TabIndex = 5;
            this.Scoretxt.Text = "Score:0";
            this.Scoretxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Location = new System.Drawing.Point(302, 360);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 31);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox3.Location = new System.Drawing.Point(165, 274);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 31);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox4.Location = new System.Drawing.Point(19, 187);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(147, 31);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(245, 499);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "spike";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox6.Location = new System.Drawing.Point(146, 518);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(147, 31);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(245, 260);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "spike";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Location = new System.Drawing.Point(364, 343);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "spike";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.Location = new System.Drawing.Point(235, 260);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 20);
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "spike";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.White;
            this.pictureBox11.Location = new System.Drawing.Point(235, 260);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 20);
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "spike";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Red;
            this.pictureBox12.Location = new System.Drawing.Point(406, 529);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.TabIndex = 4;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "coin";
            this.pictureBox12.Click += new System.EventHandler(this.coin_Click);
            // 
            // Horizontaal
            // 
            this.Horizontaal.BackColor = System.Drawing.Color.DarkOrange;
            this.Horizontaal.Location = new System.Drawing.Point(12, 428);
            this.Horizontaal.Name = "Horizontaal";
            this.Horizontaal.Size = new System.Drawing.Size(147, 31);
            this.Horizontaal.TabIndex = 6;
            this.Horizontaal.TabStop = false;
            this.Horizontaal.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Sienna;
            this.pictureBox7.Location = new System.Drawing.Point(165, 286);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(147, 31);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "floor";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Horizontaal);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Scoretxt);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.door);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontaal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label Scoretxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox Horizontaal;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

