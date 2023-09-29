using System.Text;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private List<int> salaryList = new List<int>();
        private System.Windows.Forms.Button listEmploymentsButton;
        private System.Windows.Forms.Button addEmploymentButton;
        private System.Windows.Forms.Button removeEmploymentButton;
        private System.Windows.Forms.Button orderEmploymentsSalaryButton;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox sueldoNetoTextBox;
        private System.Windows.Forms.TextBox ordenTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputLabel;
        private TextBox identificadorTextBox;
        int distanciaHorizontal = 10; 
        int distanciaVertical = 10;
        private Control cleanButton;

        public bool AscOrder { get; private set; }

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            // Agregar TextBox para el identificador
            this.identificadorTextBox = new System.Windows.Forms.TextBox();
            this.identificadorTextBox.Location = new System.Drawing.Point(15, 180); // Ajusta la posición según tu diseño
            this.identificadorTextBox.Size = new System.Drawing.Size(100, 20);
            this.identificadorTextBox.Text = "Identificador";
            this.identificadorTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.identificadorTextBox.TextAlign = HorizontalAlignment.Left;
            this.identificadorTextBox.Enter += new System.EventHandler(this.identificadorTextBox_Enter);
            this.identificadorTextBox.Leave += new System.EventHandler(this.identificadorTextBox_Leave);
            this.Controls.Add(this.identificadorTextBox);

            // TextBox para el nombre
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox.Location = new System.Drawing.Point(15, 60);
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.Text = "Nombre";
            this.nombreTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.nombreTextBox.TextAlign = HorizontalAlignment.Left; // Alinea el texto a la izquierda
            this.nombreTextBox.Enter += new System.EventHandler(this.nombreTextBox_Enter);
            this.nombreTextBox.Leave += new System.EventHandler(this.nombreTextBox_Leave);
            this.Controls.Add(this.nombreTextBox);

            // TextBox para el apellido
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox.Location = new System.Drawing.Point(15, 90);
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.Text = "Apellido";
            this.apellidoTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.apellidoTextBox.TextAlign = HorizontalAlignment.Left; // Alinea el texto a la izquierda
            this.apellidoTextBox.Enter += new System.EventHandler(this.apellidoTextBox_Enter);
            this.apellidoTextBox.Leave += new System.EventHandler(this.apellidoTextBox_Leave);
            this.Controls.Add(this.apellidoTextBox);

            // TextBox para el sueldo neto
            this.sueldoNetoTextBox = new System.Windows.Forms.TextBox();
            this.sueldoNetoTextBox.Location = new System.Drawing.Point(15, 120);
            this.sueldoNetoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sueldoNetoTextBox.Text = "Sueldo Neto";
            this.sueldoNetoTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.sueldoNetoTextBox.TextAlign = HorizontalAlignment.Left; // Alinea el texto a la izquierda
            this.sueldoNetoTextBox.Enter += new System.EventHandler(this.sueldoNetoTextBox_Enter);
            this.sueldoNetoTextBox.Leave += new System.EventHandler(this.sueldoNetoTextBox_Leave);
            this.Controls.Add(this.sueldoNetoTextBox);

            // TextBox para el el orden
            this.ordenTextBox = new System.Windows.Forms.TextBox();
            this.ordenTextBox.Location = new System.Drawing.Point(15, sueldoNetoTextBox.Bottom + 10); // Alinea debajo del sueldoNetoTextBox
            this.ordenTextBox.Size = new System.Drawing.Size(150, 20);
            this.ordenTextBox.Text = "Orden";
            this.ordenTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ordenTextBox.TextAlign = HorizontalAlignment.Left; // Alinea el texto a la izquierda
            this.ordenTextBox.Enter += new System.EventHandler(this.ordenTextBox_Enter);
            this.ordenTextBox.Leave += new System.EventHandler(this.ordenTextBox_Leave);
            this.Controls.Add(this.ordenTextBox);

            // Botón "listEmployments"
            this.listEmploymentsButton = new System.Windows.Forms.Button();
            this.listEmploymentsButton.Size = new System.Drawing.Size(100, 30);
            this.listEmploymentsButton.Text = "ListEmployments";
            this.listEmploymentsButton.Location = new Point((this.ClientSize.Width - this.listEmploymentsButton.Width) / 4, 10);
            this.listEmploymentsButton.Click += new System.EventHandler(this.listEmploymentsButton_Click);
            this.Controls.Add(this.listEmploymentsButton);

            // Botón "AddEmployment"
            this.addEmploymentButton = new System.Windows.Forms.Button();
            this.addEmploymentButton.Size = new System.Drawing.Size(100, 30);
            this.addEmploymentButton.Text = "AddEmployment";
            this.addEmploymentButton.Location = new Point(this.listEmploymentsButton.Right + 10, 10);
            this.addEmploymentButton.Click += new System.EventHandler(this.addEmploymentButton_Click);
            this.Controls.Add(this.addEmploymentButton);

            // Botón "RemoveEmployment"
            this.removeEmploymentButton = new System.Windows.Forms.Button();
            this.removeEmploymentButton.Size = new System.Drawing.Size(100, 30);
            this.removeEmploymentButton.Text = "RemoveEmployment";
            this.removeEmploymentButton.Location = new Point(this.addEmploymentButton.Right + 10, 10);
            this.removeEmploymentButton.Click += new System.EventHandler(this.removeEmploymentButton_Click);
            this.Controls.Add(this.removeEmploymentButton);

            // Botón "OrderEmploymentsSalary"
            this.orderEmploymentsSalaryButton = new System.Windows.Forms.Button();
            this.orderEmploymentsSalaryButton.Size = new System.Drawing.Size(100, 30);
            this.orderEmploymentsSalaryButton.Text = "OrderSalary";
            this.orderEmploymentsSalaryButton.Location = new Point(this.removeEmploymentButton.Right + 10, 10);
            this.orderEmploymentsSalaryButton.Click += new System.EventHandler(this.orderEmploymentsSalaryButton_Click);
            this.Controls.Add(this.orderEmploymentsSalaryButton);

            // Botón "Clean" para borrar el contenido de outputTextBox
            this.cleanButton = new System.Windows.Forms.Button();
            this.cleanButton.Size = new System.Drawing.Size(100, 30);
            this.cleanButton.Text = "Clean";
            this.cleanButton.Location = new Point(this.orderEmploymentsSalaryButton.Right + 10, 10);
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            this.Controls.Add(this.cleanButton);

            // TextBox para mostrar el resultado de los sueldos ordenados (asc/desc)
            this.outputTextBox = new System.Windows.Forms.TextBox();
            int distanciaCm = 3; // Distancia deseada en centímetros
            int distanciaPixels = (int)(distanciaCm * 20.8);
            this.outputTextBox.Location = new System.Drawing.Point(10, 150 + distanciaPixels);
            this.outputTextBox.Size = new System.Drawing.Size(400, 200);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.ReadOnly = true;
            this.Controls.Add(this.outputTextBox);

            // Label para mostrar el resultado
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputLabel.Location = new System.Drawing.Point(250, 150);
            this.outputLabel.Size = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.outputLabel);
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "";
            outputLabel.Text = "";
        }

        // Eventos Enter y Leave para los TextBox 

        private void ordenTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ordenTextBox.Text))
            {
                ordenTextBox.Text = "Orden";
                ordenTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void ordenTextBox_Enter(object sender, EventArgs e)
        {
            if (ordenTextBox.Text == "Orden")
            {
                ordenTextBox.Text = "";
                ordenTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void identificadorTextBox_Enter(object sender, EventArgs e)
        {
            if (identificadorTextBox.Text == "Identificador")
            {
                identificadorTextBox.Text = "";
                identificadorTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void identificadorTextBox_Leave(object sender, EventArgs e)
        {
           if (string.IsNullOrWhiteSpace(identificadorTextBox.Text))
            {
                identificadorTextBox.Text = "Identificador";
                identificadorTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void nombreTextBox_Enter(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == "Nombre")
            {
                nombreTextBox.Text = "";
                nombreTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void nombreTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                nombreTextBox.Text = "Nombre";
                nombreTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void apellidoTextBox_Enter(object sender, EventArgs e)
        {
            if (apellidoTextBox.Text == "Apellido")
            {
                apellidoTextBox.Text = "";
                apellidoTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void apellidoTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(apellidoTextBox.Text))
            {
                apellidoTextBox.Text = "Apellido";
                apellidoTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void sueldoNetoTextBox_Enter(object sender, EventArgs e)
        {
            if (sueldoNetoTextBox.Text == "Sueldo Neto")
            {
                sueldoNetoTextBox.Text = "";
                sueldoNetoTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void sueldoNetoTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sueldoNetoTextBox.Text))
            {
                sueldoNetoTextBox.Text = "Sueldo Neto";
                sueldoNetoTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void addEmploymentButton_Click(object sender, EventArgs e)
        {
            string nombre = nombreTextBox.Text;
            string apellido = apellidoTextBox.Text;
            float sueldoNeto;

            if (!float.TryParse(sueldoNetoTextBox.Text, out sueldoNeto))
            {
                MessageBox.Show("Ingrese un sueldo neto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llama al método AgregarEmpleado de la clase Empleado para agregar un empleado
            Empleado.AgregarEmpleado(nombre, apellido, sueldoNeto);

            outputLabel.Text = $"Se ha agregado el siguiente empleado, nombre: {nombre} apellido: {apellido}, sueldo neto: {sueldoNeto}";

            // Limpia los campos de entrada
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            sueldoNetoTextBox.Text = "";
           
        }

        private void listEmploymentsButton_Click(object sender, EventArgs e)
        {
            string listaEmpleados = Empleado.MostrarEmpleados();

            outputTextBox.Text = listaEmpleados;
        }

        private void removeEmploymentButton_Click(object sender, EventArgs e)
        {
            Empleado.EliminarEmpleado(int.Parse(identificadorTextBox.Text));
        }

        private void orderEmploymentsSalaryButton_Click(object sender, EventArgs e)
        {
            Empleado.OrdenarSalarios(ordenTextBox.Text);
           
            // Recorrer todos los empleados, mostrarlos por outPutTextBox 
            foreach (Empleado empleado in Empleado.listaEmpleados)
            {
                outputTextBox.Text += $"Identificador: {empleado.Identificador}, Nombre: {empleado.Nombre}, Apellido: {empleado.Apellido}, Sueldo Neto: {empleado.SueldoNeto}\n";
            }
        }

    }

    #endregion
}