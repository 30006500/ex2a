using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        List<Deets> people = new List<Deets>();
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deets newperson = new Deets();
            newperson.fname = txtFirstName.Text;
            newperson.lname = txtLastName.Text;
            newperson.age = int.Parse(txtAge.Text);
            people.Add(newperson);
            txtAge.Text = null;
            txtFirstName.Text = null;
            txtLastName.Text = null;
            Outlbl.Text = "Record Created";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Outlbl.Text = "Displaying All Records";

            foreach (var x in people)
            {
                listBox1.Items.Add(x.DisplayName());
                listBox1.Items.Add("Age: " + x.age);
                listBox1.Items.Add("~");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAge.Text = null;
            txtFirstName.Text = null;
            txtLastName.Text = null;
            listBox1.Items.Clear();
            Outlbl.Text = "All Data Cleared";
        }
    }
    public class Deets
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public int age { get; set; }

        public string DisplayName()
        {
            return fname + lname;
        }
    }
}
