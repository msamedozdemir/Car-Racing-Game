namespace araba_yarisi
{
    partial class Homepage
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
            this.dataGridViewHomapage = new System.Windows.Forms.DataGridView();
            this.rankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_homestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHomapage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHomapage
            // 
            this.dataGridViewHomapage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHomapage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rankColumn,
            this.p_name,
            this.score_column,
            this.date_column});
            this.dataGridViewHomapage.Location = new System.Drawing.Point(70, 405);
            this.dataGridViewHomapage.Name = "dataGridViewHomapage";
            this.dataGridViewHomapage.RowHeadersWidth = 51;
            this.dataGridViewHomapage.RowTemplate.Height = 24;
            this.dataGridViewHomapage.Size = new System.Drawing.Size(1017, 137);
            this.dataGridViewHomapage.TabIndex = 1;
            // 
            // rankColumn
            // 
            this.rankColumn.HeaderText = "Rank";
            this.rankColumn.MinimumWidth = 6;
            this.rankColumn.Name = "rankColumn";
            this.rankColumn.Width = 60;
            // 
            // p_name
            // 
            this.p_name.HeaderText = "Player Name";
            this.p_name.MinimumWidth = 6;
            this.p_name.Name = "p_name";
            this.p_name.Width = 300;
            // 
            // score_column
            // 
            this.score_column.HeaderText = "High Score";
            this.score_column.MinimumWidth = 6;
            this.score_column.Name = "score_column";
            this.score_column.Width = 150;
            // 
            // date_column
            // 
            this.date_column.HeaderText = "Date";
            this.date_column.MinimumWidth = 6;
            this.date_column.Name = "date_column";
            this.date_column.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::araba_yarisi.Properties.Resources.race;
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1017, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_homestart
            // 
            this.btn_homestart.BackgroundImage = global::araba_yarisi.Properties.Resources.basla;
            this.btn_homestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_homestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_homestart.ForeColor = System.Drawing.Color.Gray;
            this.btn_homestart.Location = new System.Drawing.Point(70, 344);
            this.btn_homestart.Name = "btn_homestart";
            this.btn_homestart.Size = new System.Drawing.Size(1017, 55);
            this.btn_homestart.TabIndex = 2;
            this.btn_homestart.Text = "Start Game";
            this.btn_homestart.UseVisualStyleBackColor = true;
            this.btn_homestart.Click += new System.EventHandler(this.btn_homestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1093, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_homestart);
            this.Controls.Add(this.dataGridViewHomapage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHomapage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_homestart;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn score_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_column;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewHomapage;
    }
}