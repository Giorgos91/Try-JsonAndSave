using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            people man = new people();
            man.name = nameTextBox.Text;
            man.surname = surnameTextBox.Text;
            man.age = int.Parse(ageTextBox.Text);
            string json = JsonConvert.SerializeObject(man);
            System.IO.File.WriteAllText(@"C:\Users\giorgos\Desktop\tryall.txt",json);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\giorgos\Desktop\tryall.txt");
            people man = JsonConvert.DeserializeObject<people>(json);

            MessageBox.Show($"{man.name} and {man.surname} with age {man.age}");
        }
    }
}
