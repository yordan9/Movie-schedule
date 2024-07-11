using Microsoft.EntityFrameworkCore;
using MovieSchedule2.Data;
using MovieSchedule2.Model;
using MovieSchedule2.Service;
using System.Windows.Forms;

namespace MovieSchedule2
{
    public partial class Form1 : Form
    {
        private AddMovie addMovie;
        private Placeholder placeholder;
        private MovieInformation movieInformation;

        public Form1()
        {
            InitializeComponent();
            movieInformation = new MovieInformation();
            movieInformation.InitializeDataGridView(dataGV);
            Show_btn.Click += Show_btn_Click;
            Update_btn.Click += Update_btn_Click;
            search_txtB.TextChanged += Search_txtB_TextChanged;

            Update_btn.Enabled = false;

            placeholder = new Placeholder(search_txtB, "Search a movie ...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            success_lbl.Visible = false;
            fail_lbl.Visible = false;
            deleteSuccess_lbl.Visible = false;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (addMovie == null || addMovie.IsDisposed)
                addMovie = new AddMovie();

            addMovie.Show();

            this.Hide();
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            movieInformation.LoadMovies(dataGV);
            Update_btn.Enabled = true;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            movieInformation.UpdateMovie(dataGV, success_lbl);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            movieInformation.DeleteMovie(dataGV, deleteSuccess_lbl, success_lbl, fail_lbl);
        }

        private void Search_txtB_TextChanged(object sender, EventArgs e)
        {
            string seachText = search_txtB.Text;
            movieInformation.SearchMovies(dataGV, seachText);
        }
    }
}
