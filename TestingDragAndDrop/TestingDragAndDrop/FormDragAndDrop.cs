using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingDragAndDrop
{
    public partial class FormDragAndDrop : Form
    {
        public FormDragAndDrop()
        {
            InitializeComponent();
        }

        private void FormDragAndDrop_Load(object sender, EventArgs e)
        {
            DragDropPictureBox.AllowDrop = true;
        }

        private void DragDropPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    DragDropPictureBox.Image = Image.FromFile(fileNames[0]);
                }
            }
        }

        private void DragDropPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
