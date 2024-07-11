using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using MovieSchedule2.Data;
using MovieSchedule2.Model;
using MovieSchedule2.Service;

namespace MovieSchedule2
{
    public partial class AddMovie : Form
    {
        Form1 mainForm;
        private Placeholder placeholder;
        MovieInformation movieInformation;
        public AddMovie()
        {
            InitializeComponent();

            success_lbl.Visible = false;
            fail_lbl.Visible = false;

            placeholder = new Placeholder(Name_txtB, "Enter name");
            placeholder = new Placeholder(Actor_txtB, "Enter main actor");
            placeholder = new Placeholder(Director_txtB, "Enter director");
            placeholder = new Placeholder(Genre_txtB, "Enter genre");
            placeholder = new Placeholder(releaseDate_txtB, "Enter release date");
            placeholder = new Placeholder(Country_txtB, "Enter film set(country)");
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm = new Form1();
            mainForm.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            movieInformation = new MovieInformation();
           movieInformation.AddMovieToDB(Name_txtB, Actor_txtB, Director_txtB, Genre_txtB, 
               releaseDate_txtB, Country_txtB, success_lbl, fail_lbl);
        }

    }
}
