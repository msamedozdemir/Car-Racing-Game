namespace araba_yarisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hit = new System.Windows.Forms.PictureBox();
            this.mycar = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.road = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_startAgain = new System.Windows.Forms.Button();
            this.lbl_highScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mycar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.hit);
            this.panel1.Controls.Add(this.mycar);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.road);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // hit
            // 
            this.hit.Image = global::araba_yarisi.Properties.Resources.explosion;
            this.hit.Location = new System.Drawing.Point(268, 362);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(52, 45);
            this.hit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hit.TabIndex = 3;
            this.hit.TabStop = false;
            // 
            // mycar
            // 
            this.mycar.Image = global::araba_yarisi.Properties.Resources.araba9;
            this.mycar.Location = new System.Drawing.Point(227, 386);
            this.mycar.Name = "mycar";
            this.mycar.Size = new System.Drawing.Size(69, 134);
            this.mycar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mycar.TabIndex = 2;
            this.mycar.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = global::araba_yarisi.Properties.Resources.araba3;
            this.car1.Location = new System.Drawing.Point(121, 63);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(69, 134);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 1;
            this.car1.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = global::araba_yarisi.Properties.Resources.araba4;
            this.car2.Location = new System.Drawing.Point(363, 63);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(69, 134);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 1;
            this.car2.TabStop = false;
            // 
            // road
            // 
            this.road.Image = global::araba_yarisi.Properties.Resources.yol;
            this.road.Location = new System.Drawing.Point(0, -252);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(513, 775);
            this.road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road.TabIndex = 0;
            this.road.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "High Score :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_startAgain
            // 
            this.btn_startAgain.BackgroundImage = global::araba_yarisi.Properties.Resources.basla;
            this.btn_startAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_startAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_startAgain.Location = new System.Drawing.Point(16, 608);
            this.btn_startAgain.Name = "btn_startAgain";
            this.btn_startAgain.Size = new System.Drawing.Size(486, 42);
            this.btn_startAgain.TabIndex = 3;
            this.btn_startAgain.Text = "Start Again";
            this.btn_startAgain.UseVisualStyleBackColor = true;
            this.btn_startAgain.Click += new System.EventHandler(this.btn_startAgain_Click);
            // 
            // lbl_highScore
            // 
            this.lbl_highScore.AutoSize = true;
            this.lbl_highScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_highScore.Location = new System.Drawing.Point(176, 542);
            this.lbl_highScore.Name = "lbl_highScore";
            this.lbl_highScore.Size = new System.Drawing.Size(27, 29);
            this.lbl_highScore.TabIndex = 1;
            this.lbl_highScore.Text = "0";
            this.lbl_highScore.Click += new System.EventHandler(this.lbl_highScore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(327, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Score :";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.Location = new System.Drawing.Point(418, 542);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(27, 29);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 745);
            this.Controls.Add(this.btn_startAgain);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_highScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mycar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.PictureBox mycar;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_startAgain;
        private System.Windows.Forms.Label lbl_highScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.PictureBox hit;
        private System.Windows.Forms.Timer timer1;
    }
}

