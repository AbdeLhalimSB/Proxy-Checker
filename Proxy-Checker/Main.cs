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

namespace Proxy_Checker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        List<string> ProxyList = new List<string>();
        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    file_path_tx.Text = selectedFilePath;

                    string[] lines = File.ReadAllLines(selectedFilePath);

                    ProxyList.Clear(); // Clear the list before adding new lines.
                    ProxyList.AddRange(lines); // Add the lines to the emailList.

                }
            }
        }
    }
}
