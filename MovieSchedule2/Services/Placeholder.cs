using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSchedule2.Service
{
    public class Placeholder
    {
        private TextBox txtB;
        private readonly string placeholderText;

        public Placeholder(TextBox textBox, string plhText)
        {
            txtB = textBox;
            placeholderText = plhText;

            txtB.Text = placeholderText;
            txtB.ForeColor = Color.Gray;

            txtB.Enter += RemovePlaceholder;
            txtB.Leave += ShowPlaceholder;
        }

        private void ShowPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtB.Text))
            {
                txtB.Text = placeholderText;
                txtB.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtB.Text == placeholderText)
            {
                txtB.Text = "";
                txtB.ForeColor = Color.Black;
            }
        }
    }
}
