using System;

namespace PrackticumCL
{
    public class Task4
    {
        /// <summary>
        /// Число результата задачи - свойство.
        /// </summary>
        public string ResultTaskFactors { get; set; }
        /// <summary>
        /// Стандартный конструктор класса Task4
        /// </summary>
        public Task4()
        { 
        }
        /// <summary>
        /// Констурктор класса Task4
        /// </summary>
        /// <param name="S1data">На вход подаётся первая строка исходного файла.</param>
        /// <param name="S2data">На вход подаётся вторая строка исходного файла.</param>
        public Task4(string[] S1data, string[] S2data)
        {
            CalculationQuantityDaysFactors(S1data, S2data);
        }
        /// <summary>
        /// Метод, занимающийся вычислением количества дней оставшихся до дня рождения с учетом високстных годов.
        /// </summary>
        /// <param name="S1data">На вход подаётся первая строка исходного файла для расчёта количества дней до дня рождения.</param>
        /// <param name="S2data">На вход подаётся вторая строка исходного файла для расчёта количества дней до дня рождения.</param>
        private void
        CalculationQuantityDaysFactors(string[] S1data, string[] S2data)
        {
            bool BreakCheck = false;
            int AddYears = 0;
            int DaysCounterBirthday = 0;
            int DaysCounterNewTime = 0;
            int[] ArrMonths = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (S1data[0][0] == '0')
            {
                S1data[0] = S1data[0][1].ToString();
            }
            if (S1data[1][0] == '0')
            {
                S1data[1] = S1data[1][1].ToString();
            }
            if (S2data[0][0] == '0')
            {
                S2data[0] = S2data[0][1].ToString();
            }
            if (S2data[1][0] == '0')
            {
                S2data[1] = S2data[1][1].ToString();
            }
            int Bdays = int.Parse(S1data[0]);
            int Bmonths = int.Parse(S1data[1]);
            int days = int.Parse(S2data[0]);
            int months = int.Parse(S2data[1]);
            int years = int.Parse(S2data[2]);
            if ((years % 4 == 0 && !(years % 100 == 0)) | years % 400 == 0)
            {
                ArrMonths[1] = 29;
            }
            if (2 == Bmonths && 29 == Bdays)
            {
                for (int g = 0; g < 5; g++)
                {
                    AddYears++;
                    if (((years + AddYears) % 4 == 0 && !((years + AddYears) % 100 == 0)) | (years + AddYears) % 400 == 0)
                    {
                        break;
                    }
                }
                for (int q = 0; q < 12; q++)
                {
                    for (int w = 0; w < ArrMonths[q]; w++)
                    {
                        DaysCounterNewTime++;
                        if (q == (months - 1) && w == days)
                        {
                            BreakCheck = true;
                            break;
                        }
                    }
                    if (BreakCheck == true)
                    {
                        break;
                    }
                }
                ResultTaskFactors = (365 - DaysCounterNewTime + 365 * AddYears + 1).ToString();
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int k = 0; k < ArrMonths[i]; k++)
                    {
                        if (i == (Bmonths - 1) && k == Bdays)
                        {
                            BreakCheck = true;
                            break;
                        }
                        DaysCounterBirthday++;
                    }
                    if (BreakCheck == true)
                    {
                        BreakCheck = false;
                        break;
                    }
                }
                for (int j = 0; j < 12; j++)
                {
                    for (int s = 0; s < ArrMonths[j]; s++)
                    {
                        if (j == (months - 1) && s == days)
                        {
                            BreakCheck = true;
                            break;
                        }
                        DaysCounterNewTime++;
                    }
                    if (BreakCheck == true)
                    {
                        break;
                    }
                }
                if (DaysCounterNewTime <= DaysCounterBirthday)
                {
                    ResultTaskFactors = (DaysCounterBirthday - DaysCounterNewTime).ToString();
                }
                else
                {
                    ResultTaskFactors = (365 - DaysCounterNewTime + DaysCounterBirthday).ToString();
                }
            }
        }
    }
}

