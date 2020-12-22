using System;

namespace PrackticumCL
{
    public class Task1
    {
        /// <summary>
        /// Число результата задачи - свойство.
        /// </summary>
        public bool ResultTaskFactors { get; set; }
       /// <summary>
       /// Стандартный конструктор класса Task1
       /// </summary>
       public Task1()
       {
           
        }
        /// <summary>
        /// Констурктор класса Task1
        /// </summary>
        /// <param name="NumberYear">На вход подаётся номер года проверяемого на високостность.</param>
        public Task1(int NumberYear)
       {
            DivisionFactors(NumberYear);
       }
        /// <summary>
        /// Метод, занимающийся проверкой делимости на 4 без остатка номера поданного на вход.
        /// </summary>
        /// <param name="NumberYear">На вход подаётся номер года проверяемого на високостность.</param>
        private void
        DivisionFactors(int NumberYear)
        {
            double DCNumberYear = 0.0;
            DCNumberYear = Convert.ToDouble(NumberYear);
            if ((DCNumberYear % 4 == 0 && !(DCNumberYear % 100 == 0)) | DCNumberYear % 400 == 0)
            {
                ResultTaskFactors = true;
            }
            else
            {
                ResultTaskFactors = false;
            }
        }
    }
}

