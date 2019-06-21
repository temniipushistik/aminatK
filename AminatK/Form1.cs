using System;
using System.Windows.Forms;

namespace AminatK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Calculator Calculator = new Calculator();

        private void Button_Click(object sender, EventArgs e)
        {
            Calculator.Hardness = Convert.ToDouble(hardTextBox.Text);

            Calculator.Pressure = Convert.ToDouble(pressureTextBox.Text);

            //Calculator.Flow = Convert.ToDouble(flowTextBox.Text);

            mixOut.Text = (Calculator.Hardness + 10).ToString();

            nCount.Text = Calculator.Pressure.ToString();




        }

        //вспрыск зависит от противодавления
        //сделать класс под рассчеты

        
    }
}
