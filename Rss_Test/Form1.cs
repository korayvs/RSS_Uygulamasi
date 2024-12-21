using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rss_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string link;

        public void habergetir()
        {
            XmlTextReader xmloku = new XmlTextReader(" " + link);
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            link = "http://mix.chimpfeedr.com/07479-Hurriyet-Gazetesi";
            habergetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            link = "https://www.milliyet.com.tr/rss/rssnew/gundem.xml";
            habergetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            link = "https://www.fotomac.com.tr/rss/anasayfa.xml";
            habergetir();
        }
    }
}
