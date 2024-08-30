namespace temperature_converter
{
    public partial class frmMain : Form
    {
        #region 

        Converter converter = new Converter();
        private bool activate = false;
        #endregion

        /// <summary>
        /// Convierte una temperatura de Celsius a Fahrenheit.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            txtCelsius.Text = "0";
            txtFahrenheit.Text = "32";
            txtCelsius.MaxLength = 4;
            txtFahrenheit.MaxLength = 4;

        }

        #region methods
        public float NumberValidation(string data)
        {
            if (!float.TryParse(data, out float dataDouble))
            {

                return 0;
            }
            else
            {
                return dataDouble;
            }
        }
        #endregion

        #region events
        private void txtCentigrade_TextChanged(object sender, EventArgs e)
        {
            if (activate) return; 
            activate = true; 
            converter.ConvertCelsiusToFahrenheit(NumberValidation(txtCelsius.Text));
            txtFahrenheit.Text = converter.Fahrenheit.ToString();
            activate = false; 

        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (activate) return; // Evitar recursividad

            activate = true; // Marcar el inicio de la actualización
            converter.ConvertFahrenheitToCelsius(NumberValidation(txtFahrenheit.Text));
            txtCelsius.Text = converter.Celsius.ToString();
            activate = false; // Marcar el fin de la actualización
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        
    }
}
