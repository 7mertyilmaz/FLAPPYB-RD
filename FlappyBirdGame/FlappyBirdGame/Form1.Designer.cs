namespace FlappyBirdGame
{
    partial class FLAPPYBİRD
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.boruAlt = new System.Windows.Forms.PictureBox();
            this.boruUst = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(66, 427);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(131, 31);
            this.scoreText.TabIndex = 2;
            this.scoreText.Text = "Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // flappybird
            // 
            this.flappybird.Image = global::FlappyBirdGame.Properties.Resources.flappy_bird_gif;
            this.flappybird.Location = new System.Drawing.Point(58, 50);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(99, 63);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            this.flappybird.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // zemin
            // 
            this.zemin.Image = global::FlappyBirdGame.Properties.Resources.ground;
            this.zemin.Location = new System.Drawing.Point(0, 370);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(799, 50);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 1;
            this.zemin.TabStop = false;
            this.zemin.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // boruAlt
            // 
            this.boruAlt.Image = global::FlappyBirdGame.Properties.Resources.alt_yeşil;
            this.boruAlt.Location = new System.Drawing.Point(550, 279);
            this.boruAlt.Name = "boruAlt";
            this.boruAlt.Size = new System.Drawing.Size(100, 85);
            this.boruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt.TabIndex = 0;
            this.boruAlt.TabStop = false;
            this.boruAlt.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // boruUst
            // 
            this.boruUst.Image = global::FlappyBirdGame.Properties.Resources.üstt1;
            this.boruUst.Location = new System.Drawing.Point(641, 0);
            this.boruUst.Name = "boruUst";
            this.boruUst.Size = new System.Drawing.Size(106, 91);
            this.boruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst.TabIndex = 0;
            this.boruUst.TabStop = false;
            this.boruUst.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FLAPPYBİRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.boruAlt);
            this.Controls.Add(this.boruUst);
            this.Name = "FLAPPYBİRD";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox boruAlt;
        private System.Windows.Forms.PictureBox boruUst;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

