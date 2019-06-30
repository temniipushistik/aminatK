using System;
using System.Windows.Forms;

namespace AminatK
{
    class Calculator
    {
        //Жесткость
        public double ImputHardness { get; set; }

        //производительность системы 
        public double InputFlowM3PerHour { get; set; }


        //вычисляем производительность насоса при введенном пользователе противодавлении, л/час

        private double pressureToFlow;
        public double PressureToFLow
        {
            get
            {
                //работает

                return pressureToFlow;



            }

            set
            {
                if (value >= 0.1 && value <= 2)
                {
                    pressureToFlow = -0.9 * value + 5.8;
                }
                //работает

                else if (value > 2 && value <= 3)
                {

                    pressureToFlow = -0.6 * value + 5.2;
                }
                // работает

                else if (value > 3 && value <= 4)
                {

                    pressureToFlow = -0.45 * value + 4.75;
                }
                // работает
                else if (value > 4 && value <= 5)
                {

                    pressureToFlow = -0.6 * value + 5.35;
                }

                // работает
                else if (value > 5 && value <= 5.9)
                {

                    pressureToFlow = -0.35 * value + 4.1;
                }
                else
                    MessageBox.Show("Данный насос работает в диапазоне от 0,1 атм до 5,9 атм ", "Давление вне рабочего диапазона");
            }
        }

        /// <summary>
        ///  Считаем дозировку 100%го амината К взависимости от исходной жесткости. Значения получаем в мл/м3
        /// </summary>


        public double AminatK100PercentConc

        {
            get
            {
                if (ImputHardness <= 3)
                {
                    return 8;
                }
                else if (ImputHardness > 3 & ImputHardness <= 10)
                {
                    return 10;
                }
                else if (ImputHardness > 10 & ImputHardness <= 15)
                {
                    return 15;
                }

                else return 20;


            }


            set

            {

                if (ImputHardness > 0 & ImputHardness < 35)
                {

                    value = ImputHardness;
                }


                else if (ImputHardness < 0)
                {

                    MessageBox.Show("Отрицательной жесткости не бывает");

                }
                else
                {
                    MessageBox.Show("Такая высокая жесткость может непредсказуемо отразиться на мембранах, обратитесь к инженеру ");

                }
            }

        }


        /// <summary>
        /// получаем объем исмпульса 
        /// </summary>
        /// <returns></returns>


        /// Необходимыя 100% доза антискаланта на часовой расход воды, л/час
        ///
        public double Request100AminatFlowM3PerHour()
        {

            return InputFlowM3PerHour * AminatK100PercentConc / 1000;
        }

        /// <summary>
        /// в каком соотношении можно дозировать 1 к ххх-1
        /// </summary>
        /// <returns></returns>
        /* public double percentDosingFrom;
         public double PercentDosingFrom()

         {
             return percentDosingFrom = Math.Round((pressureToFlow / Request100AminatFlowM3PerHour()) - 1, 0);
             }
       */

        public struct DosingValues
        {
            public int potenciometr; // значение потенциометра от 10 до 100%

            public int mixProportion;

            public string messageToConsole;

            public string notice; // примечания, будут выноситься в панель уведомлений


        }

        //минималный рекомендуемый объем по активному веществу того, сколько мы можем выжать из насоса при данных вводных параметрах, л/час
        public double thelowestBorderLegalDosing;

        //маесимальный рекомендуемый объем по активному веществу того, сколько мы можем выжать из насоса при данных вводных параметрах, л/час
        public double theHighestBorderLegalDosing;

       private double impulsePerMinute;
        public double ImpulsePerMinute
            {
            get
                 {
                
                return impulsePerMinute* Percent / 6000;
                 }
            set 
                {
                impulsePerMinute = value;
                }

        }


        public void CalculateLowAndHighLegalBorders()
        {
            //делим на 21 (т.к максимальное разбавление - 1 к 20) и делим на 10 (10% - минимальный рабочий режим дозации), л/час
            thelowestBorderLegalDosing = pressureToFlow / 210;
            //делим на 5 (т.к. минимально рекомендуемое значение разбавление - 1к4), а насос итак работает на 100%, л/час
            theHighestBorderLegalDosing = pressureToFlow / 5;
        }

        // создаем экземпляр стуктуры характеристик насоса

        public DosingValues Pkx = new DosingValues();


        
        public int Percent { get; set; }
        /// <summary>
        /// В каком соотношении нужно смешивать раствор
        /// 1 к х
        /// </summary>
        private int valueMix;
        public int ValueMix
        {
            
            get
            {
                valueMix = Convert.ToInt32( (pressureToFlow * Percent) / (Request100AminatFlowM3PerHour()*100));
                return valueMix-1;   
            }
            set
            {
                Percent = value ;
            }
        }

        /// <summary>
        /// Минимально возможное разбавление. Перебираем с шагом в 5 единиц разбавление 
        /// </summary>
        /// <returns></returns>
       /* public DosingValues TotalMix()
        {
            //округляем до целого и конвертим в инт
            int primaryMix = Convert.ToInt32(Math.Round(percentDosingFrom, 0));




            if (primaryMix >= 4 && primaryMix < 20)


            {
                Pkx.potenciometr = 4; // значение 0 на вывод
                Pkx.mixProportion = 100; // значение 1 на вывод
                Pkx.messageToConsole = "Дозация 1к {0}, значение потенциометра {1}%";
                Pkx.notice = "";

                MessageBox.Show("");

                return Pkx;
            }
            else if (primaryMix / 10 > 20)

            {
                Pkx.potenciometr = (primaryMix / 10); // значение 0 на вывод
                Pkx.mixProportion = 10; // значение 1 на вывод
                Pkx.messageToConsole = "Дозация 1к {0}, значение потенциометра {1}%";
                Pkx.notice = "Разбавление выше заявленного даже при минимальной производительности насоса.\n Производитель реагента рекомендует разбавлять раствор не более чем в 20 раз";
                MessageBox.Show("");
                // Console.WriteLine("Дозация 1к {0}, разбавление выше заявленного, потенциометр на 10%", test / 10);
                return Pkx;
            }

            else if (primaryMix < 4)
            {
                Pkx.potenciometr = (primaryMix); // значение 0 на вывод
                Pkx.mixProportion = 100; // значение 1 на вывод
                Pkx.messageToConsole = "Дозация 1к {0}, значение потенциометра {1}%";
                MessageBox.Show("");

                Pkx.notice = "Разбавление меньше заявленного при максимальной производительности насоса.\n Производитель реагента рекомендует разбавлять раствор не менее чем в 4 раза ";
                return Pkx;
            }
            else
            {

                int potenciometr = 0;
                int constant;
                do
                {
                    constant = primaryMix;
                    potenciometr = potenciometr + 5;
                    primaryMix = primaryMix - (constant * potenciometr) / 100;

                }

                while (primaryMix > 20);
                Pkx.potenciometr = primaryMix; // значение 0 на вывод
                Pkx.mixProportion = 100 - potenciometr; // значение 1 на вывод
                Pkx.messageToConsole = "Дозация 1к {0}, значение потенциометра {1}%";
                // Console.WriteLine("Дозация 1к {0}, попали в уменьшение настроек насоса потенциометр выставить на {1}", test, 100 - potenciometr);
                return Pkx;
            }
        }
        */
    }

            }






    






