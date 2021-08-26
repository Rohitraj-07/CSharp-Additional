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

namespace WindowsFormsApp_FileUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "File Upload";
            lblDetail.Visible = false;
           

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
            txtUpload.Text = fileDialog.FileName;
            FileInfo fi = new FileInfo(txtUpload.Text);
            File.Copy(txtUpload.Text, Application.StartupPath.Replace(@"bin\Debug","") + "/Uploads/" + DateTime.Now.ToString("ddMMyyyyhhmmss") + fi.Extension);
            pictureBox1.Image = Image.FromFile(txtUpload.Text);
        }
    }
}
