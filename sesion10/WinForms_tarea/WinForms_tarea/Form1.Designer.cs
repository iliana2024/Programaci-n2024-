namespace WinForms_tarea
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "WinFormsApp1";

            // Define los controles de la interfaz aquí
            this.Controls.Add(new System.Windows.Forms.TextBox()
            {
                Name = "txt1",
                Width = 200,
                Location = new System.Drawing.Point(50, 50),
                BackColor = System.Drawing.Color.AliceBlue,
                Text = "Hola Mundo"
            });

            this.Controls.Add(new System.Windows.Forms.ListBox()
            {
                Name = "listBox1",
                Height = 100,
                Width = 100,
                Location = new System.Drawing.Point(50, 100),
                Items = { "Item 1", "Item 2", "Item 3" }
            });

            this.Controls.Add(new System.Windows.Forms.Button()
            {
                Name = "button1",
                Text = "Clic aquí",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 16F),
                Height = 50,
                Width = 150,
                Location = new System.Drawing.Point(50, 210),
            });

            this.Controls.Add(new System.Windows.Forms.Label()
            {
                Name = "label1",
                Text = "Label",
                Location = new System.Drawing.Point(200, 300),
            });
        }
    }
}