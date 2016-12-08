using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpUpdate;

namespace TestUpdater
{
    public partial class Form1 : Form, ISharpUpdateable
    {
        private SharpUpdater updater;
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = this.ApplicationAssembly.GetName().Version.ToString();
            updater = new SharpUpdater(this);
        }

        public Assembly ApplicationAssembly
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }

        public Icon ApplicationIcon
        {
            get
            {
                return this.Icon;
            }
        }

        public string ApplicationID
        {
            get
            {
                return "TestUpdater";
            }
        }

        public string ApplicationName
        {
            get
            {
                return "TestUpdater";
            }
        }

        public Form Context
        {
            get
            {
                return this;
            }
        }

        public Uri UpdateXmlLocation
        {
            get
            {
                return new Uri("https://github.com/CaptainAllergy/Sharp-Updater/blob/master/bin/Debug/TestUpdater.exe");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }
    }
}
