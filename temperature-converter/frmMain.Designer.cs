namespace temperature_converter
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            lblCentigrade = new Label();
            lblFahrenheit = new Label();
            txtCelsius = new TextBox();
            txtFahrenheit = new TextBox();
            btnAccept = new Button();
            SuspendLayout();
            // 
            // lblCentigrade
            // 
            lblCentigrade.AutoSize = true;
            lblCentigrade.Location = new Point(74, 46);
            lblCentigrade.Name = "lblCentigrade";
            lblCentigrade.Size = new Size(44, 15);
            lblCentigrade.TabIndex = 0;
            lblCentigrade.Text = "Celsius";
            // 
            // lblFahrenheit
            // 
            lblFahrenheit.AutoSize = true;
            lblFahrenheit.Location = new Point(74, 94);
            lblFahrenheit.Name = "lblFahrenheit";
            lblFahrenheit.Size = new Size(63, 15);
            lblFahrenheit.TabIndex = 1;
            lblFahrenheit.Text = "Fahrenheit";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(142, 43);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 23);
            txtCelsius.TabIndex = 2;
            txtCelsius.TextChanged += txtCentigrade_TextChanged;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(142, 86);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(100, 23);
            txtFahrenheit.TabIndex = 3;
            txtFahrenheit.TextChanged += txtFahrenheit_TextChanged;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(151, 126);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(btnAccept);
            Controls.Add(txtFahrenheit);
            Controls.Add(txtCelsius);
            Controls.Add(lblFahrenheit);
            Controls.Add(lblCentigrade);
            Name = "frmMain";
            Text = "Temperature Converter.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCentigrade;
        private Label lblFahrenheit;
        private TextBox txtCelsius;
        private TextBox txtFahrenheit;
        private Button btnAccept;
    }
}
