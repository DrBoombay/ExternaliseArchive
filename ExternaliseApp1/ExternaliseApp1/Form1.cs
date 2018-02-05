using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternaliseApp1
{
    public partial class Form1 : Form
    {
        private string nameFile;
        private string path;
        private string pathfile;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog
            {
                Title = "Choix du fichier",
                Filter = "fichier(*.xls , *.xlsx )|*.xls; *.xlsx;"
            };

            opfd.ShowDialog();        
           

            
        }
    }
}
