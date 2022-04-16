using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFolderSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GG");
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result != DialogResult.OK)
            {
                FileInfo f;

                long size = GetDirectorySize(new DirectoryInfo(folderBrowserDialog1.SelectedPath));
                MessageBox.Show(size.ToString());

                
            }
        }
        private long GetDirectorySize(DirectoryInfo directoryinfo)
        {
            long size = 0;
            FileInfo[] allfiles = directoryinfo.GetFiles();
            for (int i =0; i< allfiles.Length; i++)
            {
                size += allfiles[i].Length;
            }
            return size;
        }
    }
}
