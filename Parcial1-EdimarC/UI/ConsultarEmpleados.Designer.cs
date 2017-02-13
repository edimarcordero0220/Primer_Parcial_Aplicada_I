namespace Parcial1_EdimarC.UI
{
    partial class ConsultarEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.EmpleadocomboBox = new System.Windows.Forms.ComboBox();
            this.filtrardataGridView1 = new System.Windows.Forms.DataGridView();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.desdedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hastadateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.filtrardataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(391, 20);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // EmpleadocomboBox
            // 
            this.EmpleadocomboBox.FormattingEnabled = true;
            this.EmpleadocomboBox.Location = new System.Drawing.Point(74, 20);
            this.EmpleadocomboBox.Name = "EmpleadocomboBox";
            this.EmpleadocomboBox.Size = new System.Drawing.Size(121, 21);
            this.EmpleadocomboBox.TabIndex = 1;
            // 
            // filtrardataGridView1
            // 
            this.filtrardataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filtrardataGridView1.Location = new System.Drawing.Point(12, 149);
            this.filtrardataGridView1.Name = "filtrardataGridView1";
            this.filtrardataGridView1.Size = new System.Drawing.Size(566, 150);
            this.filtrardataGridView1.TabIndex = 2;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(12, 305);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 23);
            this.Imprimirbutton.TabIndex = 3;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // desdedateTimePicker1
            // 
            this.desdedateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdedateTimePicker1.Location = new System.Drawing.Point(86, 83);
            this.desdedateTimePicker1.Name = "desdedateTimePicker1";
            this.desdedateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.desdedateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtra";
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(201, 20);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(100, 20);
            this.BuscartextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desde";
            // 
            // hastadateTimePicker2
            // 
            this.hastadateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastadateTimePicker2.Location = new System.Drawing.Point(322, 83);
            this.hastadateTimePicker2.Name = "hastadateTimePicker2";
            this.hastadateTimePicker2.Size = new System.Drawing.Size(89, 20);
            this.hastadateTimePicker2.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConsultarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 340);
            this.Controls.Add(this.hastadateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desdedateTimePicker1);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.filtrardataGridView1);
            this.Controls.Add(this.EmpleadocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "ConsultarEmpleados";
            this.Text = "ConsultarEmpleados";
            this.Load += new System.EventHandler(this.ConsultarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filtrardataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox EmpleadocomboBox;
        private System.Windows.Forms.DataGridView filtrardataGridView1;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.DateTimePicker desdedateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker hastadateTimePicker2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}