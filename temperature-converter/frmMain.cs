namespace temperature_converter
{
    public partial class frmMain : Form
    {
        #region 


        /// <summary>
        /// Object that handles temperature conversion between Celsius and Fahrenheit.
        /// </summary>
        
        Converter converter = new Converter();

        /// <summary>
        /// Flag to prevent recursion in text change events.
        /// </summary
        
        private bool activate = false;
        #endregion

        /// <summary>
        /// Main From to manage texbox
        /// </summary>
    
        public frmMain()
        {
            InitializeComponent();
            txtCelsius.Text = "0"; //initial Value
            txtFahrenheit.Text = "32"; //initial value
            txtCelsius.MaxLength = 4; // max input control
            txtFahrenheit.MaxLength = 4;// max input control

        }

        #region methods

        /// <summary>
        /// Convert string number to float number
        /// </summary>
        /// /// <param name="data">The string to validate</param>

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

        /// <summary>
        /// TextChanged event that belongs to the Celsius textbox.
        /// </summary>
        /// 
        private void txtCentigrade_TextChanged(object sender, EventArgs e)
        {
            if (activate) return; 
            activate = true; 
            converter.ConvertCelsiusToFahrenheit(NumberValidation(txtCelsius.Text));
            txtFahrenheit.Text = converter.Fahrenheit.ToString();
            activate = false; 

        }

        /// <summary>
        /// TextChanged event that belongs to the Fahrenheit textbox.
        /// </summary>

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (activate) return; 
            activate = true; 
            converter.ConvertFahrenheitToCelsius(NumberValidation(txtFahrenheit.Text));
            txtCelsius.Text = converter.Celsius.ToString();
            activate = false; 
        }

        /// <summary>
        /// Event for close form.
        /// </summary>
        
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        
    }
}
