using System;

namespace PrackticumCL
{
    public class Task3
    {
       /// <summary>
       /// Число результата задачи - свойство.
       /// </summary>
       public string ResultTaskFactors { get; set; }
       /// <summary>
       /// Стандартный конструктор класса Task1
       /// </summary>
       public Task3()
       {

       }
        /// <summary>
        /// Констурктор класса Task1
        /// </summary>
        /// <param name="Odds">На вход подаются коэффициенты для квадратного уравнения.</param>
        public Task3(string Odds)
        {
            EquationFactors(Odds);
        }
        /// <summary>
        /// Констурктор класса Task1
        /// </summary>
        /// <param name="Odds">На вход подаются коэффициенты для постраения фигур.</param>
        /// /// <param name="fig">На вход подается true для выбора перегрузки.</param>
        public Task3(string Odds, bool fig)
        {
            FiguresFactors(Odds, fig);
        }
        /// <summary>
        /// Метод, занимающийся решением квадратного уравнения с коэффициентами поданными на вход.</param>
        /// </summary>
        /// <param name="Odds">На вход подаются коэффициенты для вычисления корней квадратного уравнения.</param>
        private void
        EquationFactors(string Odds)
        {
            string[] Buf = Odds.Split(' ');
            double a = double.Parse(Buf[0]);
            double b = double.Parse(Buf[1]);
            double c = double.Parse(Buf[2]);
            ResultTaskFactors = Math.Round((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a), 3).ToString() + " " + Math.Round((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a), 3).ToString();
        }
        /// <summary>
        /// Метод, занимающийся построением фигур.
        /// </summary>
        /// <param name="Odds">На вход подаются коэффициенты для постраения фигур.</param>
        private void
        FiguresFactors(string Odds, bool fig)
        {
            string[] Buf = Odds.Split(' ');
            string[] FigursBuilding = new string[int.Parse(Buf[0])];
            for (int i = 0; i < int.Parse(Buf[0]); i++)
            {
                if ((i == 0) | (i == int.Parse(Buf[0]) - 1))
                {
                   for (int j = 0; j < int.Parse(Buf[2]); j++)
                   {
                        for (int h = 0; h < int.Parse(Buf[1]); h++)
                        {
                            FigursBuilding[i] += "*";
                        }
                        FigursBuilding[i] += " ";
                   }
                }
                else
                {
                    int naber = 0;
                    for (int k = 0; k < (int.Parse(Buf[2]) + int.Parse(Buf[2]) - 1); k++)
                    {
                        if (naber == int.Parse(Buf[1]))
                        {
                            FigursBuilding[i] += " ";
                            naber = 0;
                        }
                        else
                        {
                            for (int g = 0; g < int.Parse(Buf[1]); g++)
                            {
                                naber++;
                                if ((g == 0) | (g == (int.Parse(Buf[1]) - 1)))
                                {
                                    FigursBuilding[i] += "*";
                                }
                                else
                                {
                                    FigursBuilding[i] += " ";
                                }
                            }
                        }
                    }
                }

            }
            for (int s = 0; s < FigursBuilding.Length; s++)
            {
                ResultTaskFactors += FigursBuilding[s] + "!";
            }
        }
    }
}

