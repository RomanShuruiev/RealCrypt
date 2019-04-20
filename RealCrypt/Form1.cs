using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;


namespace RealCrypt
{
     [Serializable]
    public partial class Form1 : Form
    {

        public string nameFolder;
        public string nameFile;
        public string nameDirectory;
        public string nameEncrypt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                nameFolder = folderBrowserDialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameDirectory = nameDir.Text;
            nameEncrypt = nameEn.Text;
            Directory.CreateDirectory(nameDirectory);
            using (FileStream output = File.Create(Path.Combine(nameDirectory, nameEncrypt)))
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                Formatter.Serialize(output, Directory.GetFiles(nameFolder));
            }
            
            File.Encrypt(Path.Combine(nameDirectory, nameEncrypt));  //??
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nameFile = openFileDialog.FileName;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nameDirectory = nameDir.Text;
            nameEncrypt = nameEn.Text;
            string ResultName;
        
            using (Stream input = File.OpenRead(Path.Combine(nameDirectory, nameFile)))
            {
                BinaryFormatter Unformatter = new BinaryFormatter();
                Directory.CreateDirectory(nameDirectory);
                using (FileStream output = File.Create(Path.Combine(nameDirectory, nameEncrypt)))
               
                using (StreamWriter writer = new StreamWriter(output))
                {
                    writer.Write((string)Unformatter.Deserialize(output));
                }

               File.Decrypt(Path.Combine(nameDirectory, nameEncrypt));

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
