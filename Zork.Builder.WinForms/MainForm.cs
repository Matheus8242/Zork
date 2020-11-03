using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using InventoryManager.Data;
using Zork.Builder.WinForms.ViewModels;

namespace Zork.Builder.WinForms
{
    public partial class MainForm : Form
    {
        private WorldViewModel ViewModel
        {
            get => mViewModel;
            set => mViewModel = value;
        }
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
            }
        }

        private WorldViewModel mViewModel;
    }
}
