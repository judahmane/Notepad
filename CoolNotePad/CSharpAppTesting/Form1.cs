using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace CSharpAppTesting
{

    

public partial class Form1 : Form
{

        string pathment;
        

     public Form1()
        {
            InitializeComponent();
        }

      

        public void button1_Click(object sender, EventArgs e)
        {

            string filer = ".txt";

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(fbd.SelectedPath) + (filer), true)) 
                    {
                        pathment = fbd.SelectedPath;
                      
                        outputFile.WriteLine(textBox1.Text);
                        
                    }
                    string message = "Created txt File";
                    string title = "Alert";
                    MessageBox.Show(message, title);
                    // System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
         
           
        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/judahmane");
        }
    }
}
