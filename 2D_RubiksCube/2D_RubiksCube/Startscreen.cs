using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_RubiksCube
{
    public partial class Startscreen : Form
    {
        private string imagePath = "";
        private int gridsize = 2;
        private int size = 300;
        public Startscreen()
        {
            InitializeComponent();
        }

        private void OnChoosePicture(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files (*PNG)|*.png|Image Files(*JPG)|*jpg|All Files(*.*)|*.*";
            if (dlg.ShowDialog().Equals(DialogResult.OK))
            {
                imagePath = dlg.FileName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        public int GRIDSIZE
        {
            get => gridsize;
        }
        public string ImagePath
        {
            get => imagePath;
        }

        private void OnGridSizeChange(object sender, EventArgs e)
        {
            gridsize = (int)upDownBox.Value;
        }

        private void SizeValueChanged(object sender, EventArgs e)
        {
            size = (int)SizeUpDown.Value;
        }
    }
}
