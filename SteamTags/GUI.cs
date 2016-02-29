using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamTags
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            
        }
        public void button1_Click(object sender, EventArgs e)
        {
            TagFiltering cat = new TagFiltering();
            cat.run(checkedListBox1, webBrowser1);
            label3.Text = "Browsing " + checkedListBox1.SelectedItem.ToString();
        }

        public void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.SelectedIndex != i)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
