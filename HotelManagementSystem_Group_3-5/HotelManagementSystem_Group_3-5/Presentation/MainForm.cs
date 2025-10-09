using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // name is not changing, but button1_Click is makeBookingButton // changed name now from button1 to makeBookingButton
        private void makeBookingButton_Click(object sender, EventArgs e)
        {
            LoadForm(new MakeBookingForm());

        }

        private void LoadForm(Form form)
        {

            panel1.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

       

        private void cancelButton_Click(object sender, EventArgs e)
        {
            LoadForm(new CancelBookingForm());

        }

        private void enquiryButton_Click(object sender, EventArgs e)
        {
            LoadForm(new EnquiryForm());

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            LoadForm(new ReportsForm());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeBookingButton_Click_1(object sender, EventArgs e)
        {
            LoadForm(new ChangeBookingForm());

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
