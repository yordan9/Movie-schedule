namespace MovieSchedule2
{
    partial class AddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            Back_btn = new Button();
            Add_btn = new Button();
            Name_txtB = new TextBox();
            Actor_txtB = new TextBox();
            Director_txtB = new TextBox();
            info_lbl = new Label();
            success_lbl = new Label();
            fail_lbl = new Label();
            Genre_txtB = new TextBox();
            Country_txtB = new TextBox();
            releaseDate_txtB = new TextBox();
            SuspendLayout();
            // 
            // Back_btn
            // 
            Back_btn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Back_btn.Image = (Image)resources.GetObject("Back_btn.Image");
            Back_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Back_btn.Location = new Point(12, 503);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(136, 47);
            Back_btn.TabIndex = 6;
            Back_btn.Text = "Back";
            Back_btn.TextAlign = ContentAlignment.MiddleRight;
            Back_btn.UseVisualStyleBackColor = true;
            Back_btn.Click += Back_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            Add_btn.Image = (Image)resources.GetObject("Add_btn.Image");
            Add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Add_btn.Location = new Point(852, 503);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(136, 47);
            Add_btn.TabIndex = 7;
            Add_btn.Text = "Add";
            Add_btn.TextAlign = ContentAlignment.MiddleRight;
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // Name_txtB
            // 
            Name_txtB.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            Name_txtB.Location = new Point(402, 171);
            Name_txtB.Name = "Name_txtB";
            Name_txtB.Size = new Size(200, 30);
            Name_txtB.TabIndex = 8;
            // 
            // Actor_txtB
            // 
            Actor_txtB.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            Actor_txtB.Location = new Point(402, 207);
            Actor_txtB.Name = "Actor_txtB";
            Actor_txtB.Size = new Size(200, 30);
            Actor_txtB.TabIndex = 9;
            // 
            // Director_txtB
            // 
            Director_txtB.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            Director_txtB.Location = new Point(402, 242);
            Director_txtB.Name = "Director_txtB";
            Director_txtB.Size = new Size(200, 30);
            Director_txtB.TabIndex = 10;
            // 
            // info_lbl
            // 
            info_lbl.AutoSize = true;
            info_lbl.BackColor = Color.Transparent;
            info_lbl.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            info_lbl.ForeColor = Color.DarkGray;
            info_lbl.Location = new Point(173, 24);
            info_lbl.Name = "info_lbl";
            info_lbl.Size = new Size(657, 45);
            info_lbl.TabIndex = 12;
            info_lbl.Text = "Information about the movie:";
            // 
            // success_lbl
            // 
            success_lbl.AutoSize = true;
            success_lbl.BackColor = Color.Transparent;
            success_lbl.Font = new Font("Algerian", 18F, FontStyle.Bold);
            success_lbl.ForeColor = Color.LimeGreen;
            success_lbl.Location = new Point(184, 463);
            success_lbl.Name = "success_lbl";
            success_lbl.Size = new Size(632, 68);
            success_lbl.TabIndex = 13;
            success_lbl.Text = "You successfully added information \r\n                  about the movie!";
            // 
            // fail_lbl
            // 
            fail_lbl.AutoSize = true;
            fail_lbl.BackColor = Color.Transparent;
            fail_lbl.Font = new Font("Algerian", 18F, FontStyle.Bold);
            fail_lbl.ForeColor = Color.Red;
            fail_lbl.Location = new Point(290, 463);
            fail_lbl.Name = "fail_lbl";
            fail_lbl.Size = new Size(409, 34);
            fail_lbl.TabIndex = 14;
            fail_lbl.Text = "Failded add! Try again!";
            // 
            // Genre_txtB
            // 
            Genre_txtB.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Genre_txtB.Location = new Point(402, 314);
            Genre_txtB.Name = "Genre_txtB";
            Genre_txtB.Size = new Size(200, 30);
            Genre_txtB.TabIndex = 15;
            // 
            // Country_txtB
            // 
            Country_txtB.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Country_txtB.Location = new Point(402, 350);
            Country_txtB.Name = "Country_txtB";
            Country_txtB.Size = new Size(200, 30);
            Country_txtB.TabIndex = 16;
            // 
            // releaseDate_txtB
            // 
            releaseDate_txtB.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            releaseDate_txtB.Location = new Point(402, 278);
            releaseDate_txtB.Name = "releaseDate_txtB";
            releaseDate_txtB.Size = new Size(200, 30);
            releaseDate_txtB.TabIndex = 17;
            // 
            // AddMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 562);
            Controls.Add(releaseDate_txtB);
            Controls.Add(Country_txtB);
            Controls.Add(Genre_txtB);
            Controls.Add(fail_lbl);
            Controls.Add(success_lbl);
            Controls.Add(info_lbl);
            Controls.Add(Director_txtB);
            Controls.Add(Actor_txtB);
            Controls.Add(Name_txtB);
            Controls.Add(Add_btn);
            Controls.Add(Back_btn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMovie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Back_btn;
        private Button Add_btn;
        private TextBox Name_txtB;
        private TextBox Actor_txtB;
        private TextBox Director_txtB;
        private Label info_lbl;
        private Label success_lbl;
        private Label fail_lbl;
        private TextBox Genre_txtB;
        private TextBox Country_txtB;
        private TextBox releaseDate_txtB;
    }
}