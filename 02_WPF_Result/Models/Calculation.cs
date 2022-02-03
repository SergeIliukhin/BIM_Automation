using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace _02_WPF_Result.Models
{
    public static class Calculation
    {
        public static string result = "";

        public static string GetResult(string firstNumberText, string secondNumberText, string resultTextBox, string calcSymbol, bool calculatedCompleted)
        {
            //Преобразование введенного выражения в числа
            bool firstNumberBool = double.TryParse(firstNumberText, out double firstNumberDouble);
            bool secondNumberBool = double.TryParse(secondNumberText, out double secondNumberDouble);
            bool resultTextBoxBool = double.TryParse(resultTextBox, out double resultTextBoxDouble);
            int resultIntForDivision;
            double resultDoubleForDivision;

            //Если кнопка = нажимается первый раз поссле введения выравжения
            if (calculatedCompleted == false)
            {
                switch (calcSymbol)
                {
                    case "+":
                        result = (firstNumberDouble + secondNumberDouble).ToString();
                        break;

                    case "-":
                        result = (firstNumberDouble - secondNumberDouble).ToString();
                        break;

                    case "×":
                        result = (firstNumberDouble * secondNumberDouble).ToString();
                        break;

                    case "÷":
                        try
                        {
                            resultIntForDivision = (int)firstNumberDouble / (int)secondNumberDouble;
                        }
                        catch (DivideByZeroException)
                        {
                            result = "Деление на \"0\"";
                            break;
                        }
                        result = (firstNumberDouble / secondNumberDouble).ToString();
                        break;

                   default:
                        break;
                }
            }

            //Если необходимо продолжить нажимать кнопку =, получая последовательные результаты 
            if (calculatedCompleted == true)
            {
                switch (calcSymbol)
                {
                    case "+":
                        result = (resultTextBoxDouble + secondNumberDouble).ToString();
                        break;

                    case "-":
                        result = (resultTextBoxDouble - secondNumberDouble).ToString();
                        break;

                    case "×":
                        result = (resultTextBoxDouble * secondNumberDouble).ToString();
                        break;

                    case "÷":
                        result = (resultTextBoxDouble / secondNumberDouble).ToString();
                        break;

                    default:
                        break;
                }
            }
            return result;
        }
    }
}
