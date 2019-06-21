using System;
using System.Windows.Forms;

namespace AminatK
{
    class Calculator
    {
        //Жесткость
        public double Hardness { get; set; }
        
        //производительность системы 
        public double Flow { get; set; }


        //вычисляем производительность насоса при введенном пользователе противодавлении

        private double pressure;
        public double Pressure
        {
            get
            {
               
                if (pressure >= 0.1 && pressure <= 1)
                {

                    return 111;
                }

                else if (pressure > 1 && pressure <= 2)
                {

                    return 222;
                }

                else if (pressure > 2 && pressure <= 3)
                {

                    return 333;
                }


                else if (pressure > 3 && pressure <= 4)
                {

                    return 444;
                }

                else if (pressure > 4 && pressure <= 5)
                {

                    return 555;
                }


                else if(pressure > 5 && pressure <= 5.9)
                {

                    return -(20/7) * pressure+ (82/7);
                }

                else
                {
                    MessageBox.Show("Данный насос работает в диапазоне от 0,1 атм до 5,9 атм ", "Давление вне рабочего диапазона");
                    return 0;
                }
            }

            set
            {
                pressure = value ;
            }
        }

    }
}
