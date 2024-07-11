namespace MovieSchedule2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Show_btn = new Button();
            Add_btn = new Button();
            Update_btn = new Button();
            Delete_btn = new Button();
            exit_btn = new Button();
            title_lbl = new Label();
            dataGV = new DataGridView();
            fail_lbl = new Label();
            success_lbl = new Label();
            search_txtB = new TextBox();
            deleteSuccess_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGV).BeginInit();
            SuspendLayout();
            // 
            // Show_btn
            // 
            Show_btn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            Show_btn.Image = (Image)resources.GetObject("Show_btn.Image");
            Show_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Show_btn.Location = new Point(1201, 1000);
            Show_btn.Name = "Show_btn";
            Show_btn.Size = new Size(142, 56);
            Show_btn.TabIndex = 0;
            Show_btn.Text = "Show";
            Show_btn.TextAlign = ContentAlignment.MiddleRight;
            Show_btn.UseVisualStyleBackColor = true;
            Show_btn.Click += Show_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            Add_btn.Image = (Image)resources.GetObject("Add_btn.Image");
            Add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Add_btn.Location = new Point(1381, 1000);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(142, 56);
            Add_btn.TabIndex = 1;
            Add_btn.Text = "Add";
            Add_btn.TextAlign = ContentAlignment.MiddleRight;
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // Update_btn
            // 
            Update_btn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            Update_btn.Image = (Image)resources.GetObject("Update_btn.Image");
            Update_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Update_btn.Location = new Point(1563, 1000);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(142, 56);
            Update_btn.TabIndex = 2;
            Update_btn.Text = "Update";
            Update_btn.TextAlign = ContentAlignment.MiddleRight;
            Update_btn.UseVisualStyleBackColor = true;
            Update_btn.Click += Update_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            Delete_btn.Image = (Image)resources.GetObject("Delete_btn.Image");
            Delete_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Delete_btn.Location = new Point(1744, 1000);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(142, 56);
            Delete_btn.TabIndex = 3;
            Delete_btn.Text = "Delete";
            Delete_btn.TextAlign = ContentAlignment.MiddleRight;
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.BackgroundImage = (Image)resources.GetObject("exit_btn.BackgroundImage");
            exit_btn.Location = new Point(1871, -1);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(49, 49);
            exit_btn.TabIndex = 4;
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.BackColor = Color.Transparent;
            title_lbl.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_lbl.ForeColor = Color.Coral;
            title_lbl.Location = new Point(37, 33);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(525, 96);
            title_lbl.TabIndex = 5;
            title_lbl.Text = "Movie schedule";
            // 
            // dataGV
            // 
            dataGV.AllowUserToResizeColumns = false;
            dataGV.AllowUserToResizeRows = false;
            dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGV.BackgroundColor = Color.Coral;
            dataGV.CausesValidation = false;
            dataGV.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Coral;
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Coral;
            dataGridViewCellStyle2.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGV.DefaultCellStyle = dataGridViewCellStyle2;
            dataGV.EnableHeadersVisualStyles = false;
            dataGV.Location = new Point(37, 141);
            dataGV.MultiSelect = false;
            dataGV.Name = "dataGV";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Coral;
            dataGridViewCellStyle3.Font = new Font("Sitka Subheading", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGV.RowHeadersVisible = false;
            dataGV.RowHeadersWidth = 51;
            dataGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGV.Size = new Size(1849, 806);
            dataGV.TabIndex = 7;
            dataGV.TabStop = false;
            // 
            // fail_lbl
            // 
            fail_lbl.AutoSize = true;
            fail_lbl.BackColor = Color.Transparent;
            fail_lbl.Font = new Font("Algerian", 24F, FontStyle.Bold);
            fail_lbl.ForeColor = Color.Red;
            fail_lbl.Location = new Point(358, 1003);
            fail_lbl.Name = "fail_lbl";
            fail_lbl.Size = new Size(608, 45);
            fail_lbl.TabIndex = 16;
            fail_lbl.Text = "Failded update! Try again!";
            // 
            // success_lbl
            // 
            success_lbl.AutoSize = true;
            success_lbl.BackColor = Color.Transparent;
            success_lbl.Font = new Font("Algerian", 24F, FontStyle.Bold);
            success_lbl.ForeColor = Color.LimeGreen;
            success_lbl.Location = new Point(216, 1003);
            success_lbl.Name = "success_lbl";
            success_lbl.Size = new Size(875, 45);
            success_lbl.TabIndex = 15;
            success_lbl.Text = "You successfully update the schedule!";
            // 
            // search_txtB
            // 
            search_txtB.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_txtB.Location = new Point(594, 72);
            search_txtB.Name = "search_txtB";
            search_txtB.Size = new Size(344, 38);
            search_txtB.TabIndex = 17;
            // 
            // deleteSuccess_lbl
            // 
            deleteSuccess_lbl.AutoSize = true;
            deleteSuccess_lbl.BackColor = Color.Transparent;
            deleteSuccess_lbl.Font = new Font("Algerian", 24F, FontStyle.Bold);
            deleteSuccess_lbl.ForeColor = Color.PaleGreen;
            deleteSuccess_lbl.Location = new Point(254, 1003);
            deleteSuccess_lbl.Name = "deleteSuccess_lbl";
            deleteSuccess_lbl.Size = new Size(792, 45);
            deleteSuccess_lbl.TabIndex = 18;
            deleteSuccess_lbl.Text = "You successfully delete the movie!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1080);
            Controls.Add(deleteSuccess_lbl);
            Controls.Add(search_txtB);
            Controls.Add(fail_lbl);
            Controls.Add(success_lbl);
            Controls.Add(dataGV);
            Controls.Add(title_lbl);
            Controls.Add(exit_btn);
            Controls.Add(Delete_btn);
            Controls.Add(Update_btn);
            Controls.Add(Add_btn);
            Controls.Add(Show_btn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Show_btn;
        private Button Add_btn;
        private Button Update_btn;
        private Button Delete_btn;
        private Button exit_btn;
        private Label title_lbl;
        private DataGridView dataGV;
        private Label fail_lbl;
        private Label success_lbl;
        private TextBox search_txtB;
        private Label deleteSuccess_lbl;
    }
}
