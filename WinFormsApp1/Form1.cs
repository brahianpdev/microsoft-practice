namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            string listaEmpleados = Empleado.MostrarEmpleados();

            outputTextBox.Text = listaEmpleados;
            outputTextBox.Visible = true;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string nombre = nombreTextBox.Text;
            string apellido = apellidoTextBox.Text;
            float sueldoNeto;

            if (!float.TryParse(sueldoNetoTextBox.Text, out sueldoNeto))
            {
                MessageBox.Show("Ingrese un sueldo neto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Empleado.AgregarEmpleado(nombre, apellido, sueldoNeto);

            outputLabel.Text = $"Se ha agregado el siguiente empleado, nombre: {nombre} apellido: {apellido}, sueldo neto: {sueldoNeto}";

            // Limpia los campos de entrada
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            sueldoNetoTextBox.Text = "";
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado.EliminarEmpleado(int.Parse(identificadorTextBox.Text));
            outputLabel.Text = $"Se ha eliminado el empleado con identificador: {identificadorTextBox.Text}";
        }

        private void btnOrdenarEmpleados_Click(object sender, EventArgs e)
        {
            string orden = ordenTextBox.Text; 

            Empleado.OrdenarSalarios(orden);
        }


    }
}