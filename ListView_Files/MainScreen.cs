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

namespace ListView_Files
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            int cont = 0;
            using (OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = true })
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in fileDialog.FileNames)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        ListViewItem itens = new ListViewItem(Convert.ToString(cont++));
                        itens.SubItems.Add(fileInfo.Name);
                        itens.SubItems.Add(fileInfo.FullName);
                        listView_files.Items.Add(itens);
                    }
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if ((listView_files.Items.Count > 0) && (listView_files.SelectedIndices[0] != 0))
            {
                listView_files.Items.Remove(listView_files.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Não e possível remover pois não há itens na lista!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
