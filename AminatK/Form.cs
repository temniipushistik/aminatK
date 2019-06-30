using System;
using System.Windows.Forms;

namespace AminatK
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)

        {
            PotenciometrBar.Value = Calculator.Percent= Convert.ToInt32(Potenciometr.Text);
        }

        Calculator Calculator = new Calculator();

        
        private void Button_Click(object sender, EventArgs e)
        {

            Calculator.ImputHardness = Convert.ToDouble(hardTextBox.Text);

            Calculator.PressureToFLow = Convert.ToDouble(pressureTextBox.Text);

            flowLpH.Text = Calculator.PressureToFLow.ToString();

            Calculator.InputFlowM3PerHour = Convert.ToDouble(flowTextBox.Text);

            
            Calculator.Request100AminatFlowM3PerHour();
            
            // MessageBox.Show(Calculator.Request100AminatFlowM3PerHour().ToString(),"л в час 100% расхода Амината К");
            // Potenci.Text = Calculator.Pkx.mixProportion.ToString();
            comments.Text = Calculator.Pkx.notice;
            valueLabel.Text = Calculator.ValueMix.ToString();



        }

        private void PotenciometrBar_Scroll(object sender, EventArgs e)
        {
            Calculator.ValueMix = PotenciometrBar.Value;
            valueLabel.Text = Calculator.ValueMix.ToString();
            Potenciometr.Text = PotenciometrBar.Value.ToString();
        }

       
    }
}
