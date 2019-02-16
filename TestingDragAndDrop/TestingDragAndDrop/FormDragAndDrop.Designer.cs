namespace TestingDragAndDrop
{
    partial class FormDragAndDrop
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DragDropPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DragDropPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DragDropPictureBox
            // 
            this.DragDropPictureBox.BackColor = System.Drawing.Color.White;
            this.DragDropPictureBox.Location = new System.Drawing.Point(13, 13);
            this.DragDropPictureBox.Name = "DragDropPictureBox";
            this.DragDropPictureBox.Size = new System.Drawing.Size(775, 425);
            this.DragDropPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DragDropPictureBox.TabIndex = 0;
            this.DragDropPictureBox.TabStop = false;
            this.DragDropPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropPictureBox_DragDrop);
            this.DragDropPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragDropPictureBox_DragEnter);
            // 
            // FormDragAndDrop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DragDropPictureBox);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDragAndDrop";
            this.Text = "Drag and Drop Images Demo";
            this.Load += new System.EventHandler(this.FormDragAndDrop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DragDropPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DragDropPictureBox;
    }
}

