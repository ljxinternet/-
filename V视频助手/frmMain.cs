using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;


namespace V视频助手
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        #region 定义变量



        #endregion


        private void textBox_SiteUrl_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("http://v.ranks.xin");
        }

        private void Btn_ChiceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "选择下载器文件";
            //file.InitialDirectory = @"C:\";
            file.Filter = "可执行文件(*.exe)|*.exe";
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox_DownLoaderPath.Text = file.FileName;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
