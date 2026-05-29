using Ejercicio1_VentanaSimple.Services;

namespace Ejercicio1_VentanaSimple
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private NumericService servicio = new NumericService();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            servicio.Registrar(Convert.ToInt32(tbValor.Text));
            tbValor.Text = "";
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            lbResultado.Text = servicio.CalcularPromedio().ToString("0.00");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int Valor = Convert.ToInt32(tbValor.Text);
            int idx = servicio.Buscar(Valor);
            if (idx == -1)
            {
                lbResultado.Text = "NO encontrado";
            }
            else
            {
                lbResultado.Text=idx.ToString();
            }
        }
    }
}
