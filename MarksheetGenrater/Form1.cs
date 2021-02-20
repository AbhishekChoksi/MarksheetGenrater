using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksheetGenrater
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void bttn_calculate_Click(object sender, EventArgs e)
        {
            int m1, m2, m3, m4, m5, total = 0;
            double percentage;
            char grade = '\0';

            m1 = Convert.ToInt32(txt_gui.Text);
            m2 = Convert.ToInt32(txt_java.Text);
            m3 = Convert.ToInt32(txt_linux.Text);
            m4 = Convert.ToInt32(txt_oose.Text);
            m5 = Convert.ToInt32(txt_cs.Text);

            total = m1 + m2 + m3 + m4 + m5;

            percentage = total * 100f / 500;

            if (m1 < 35 || m2 < 35 || m3 < 35 || m4 < 35 || m5 < 35)
            {
                grade = 'F';
            }
            else if (percentage > 90)
            {
                grade = 'A';
            }
            else if (percentage <= 90 && percentage > 75)
            {
                grade = 'B';
            }
            else if (percentage <= 75 && percentage > 50)
            {
                grade = 'C';
            }
            else if (percentage <= 50 && percentage >= 35)
            {
                grade = 'D';
            }

            lbl_totalshow.Text = total.ToString();
            lbl_pershow.Text = percentage.ToString() + " %";
            lbl_gradeshow.Text = grade.ToString();

            lbl_totalshow.Visible = lbl_pershow.Visible = lbl_gradeshow.Visible = true;
        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            txt_enrolment.Text = "";
            txt_name.Text = "";
            txt_gui.Text = "";
            txt_java.Text = "";
            txt_linux.Text = "";
            txt_oose.Text = "";
            txt_cs.Text = "";
            lbl_totalshow.Text = "";
            lbl_pershow.Text = "";
            lbl_gradeshow.Text = "";

            lbl_totalshow.Visible = lbl_pershow.Visible = lbl_gradeshow.Visible = false;
        }
    }
}
