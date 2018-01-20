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

        string _downLoaderPath = null;

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
                _downLoaderPath = file.FileName;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                _downLoaderPath = config.AppSettings.Settings["DownLoader"].Value;

                textBox_DownLoaderPath.Text = _downLoaderPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            

        }

        private void Btn_SaveFiePath_Click(object sender, EventArgs e)
        {
            if (textBox_DownLoaderPath.Text == string.Empty || textBox_DownLoaderPath.Text == null)
            {
                return;
            }
            try
            {
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["DownLoader"].Value = textBox_DownLoaderPath.Text;
                config.Save(ConfigurationSaveMode.Modified);
                System.Configuration.ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show("保存成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            

            
        }

        private void Btn_Paste_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Clipboard.ContainsText())
                {
                    return;
                }
                
                TextBox_Url.Text = Clipboard.GetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
        }

        private void Btn_JieXi_Click(object sender, EventArgs e)
        {

        }

        private void Btn_StartDownLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
