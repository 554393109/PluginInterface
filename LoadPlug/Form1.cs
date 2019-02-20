using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace PluginInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        void PlugComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.toolTip1.Show(((ComboBox)sender).SelectedText, this.PlugComb);

            this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
            this.toolTip1.UseAnimation = true;
            this.toolTip1.AutoPopDelay = 50;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            path = System.IO.Path.Combine(path, "plugs");

            foreach (string _file in System.IO.Directory.GetFiles(path, "*.dll"))
            {
                this.PlugComb.Items.Add(_file);
            }
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string asmFile = this.PlugComb.Text;
                //Type _type = System.IO.Path.GetFileNameWithoutExtension(asmFile).GetType();
                string asmName = System.IO.Path.GetFileNameWithoutExtension(asmFile);

                if (asmFile != string.Empty)
                {
                    System.Reflection.Assembly asm = System.Reflection.Assembly.LoadFrom(asmFile);
                    //System.Reflection.Assembly asm = System.Reflection.Assembly.LoadFile(asmFile);

                    System.Type[] types = asm.GetTypes();
                    foreach (Type type in types)
                    {
                        //搜索接口，查看是否有与接口匹配的项
                        if (types[0].GetInterface("IShow") != null)
                        {
                            if (type.GetCustomAttributes(typeof(PluginInterface.PlugDescriptionAttribute), false).Length != 1)
                                throw new PluginInterface.PlugNotValidException(type, "PlugNotValidException Is Not Supptored");

                            PluginInterface.IShow iShow = (PluginInterface.IShow)System.Activator.CreateInstance(asm.GetType(types[0].FullName));

                            this.PlugTxt.Text = iShow.Show();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                PlugTxt.Text = ex.Message + "||" + ex.Source;
            }
        }
    }
}