using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using _02_WPF_Result.Models;


namespace _02_WPF_Result.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        //Поле с введенным пользователем выражением
        private string inputTextBox;
        public string InputTextBox
        {
            get => inputTextBox;
            set
            {
                inputTextBox = value;
                OnPropertyChanged();
            }
        }

        //Поле с первым числом до оператора вычисления
        private string firstNumberText;
        public string FirstNumberText
        {
            get => firstNumberText;
            set
            {
                firstNumberText = value;
            }
        }

        //Поле со вторым числом после оператора вычисления
        private string secondNumberText;
        public string SecondNumberText
        {
            get => secondNumberText;
            set
            {
                secondNumberText = value;
            }
        }

        //Переменная, контролирующая, вводится ли число до оператора вычисления или после оператора
        private bool firstNumberInputBool = true;
        public bool FirstNumberInputBool
        {
            get => firstNumberInputBool;
            set
            {
                firstNumberInputBool = value;
            }
        }

        //Переменная для проверки, закончено ли вычисление
        private bool calculationCompleted = false;
        public bool CalculationCompleted
        {
            get => calculationCompleted;
            set
            {
                calculationCompleted = value;
            }
        }

        //Поле с введенным пользователем оператором вычисления
        private string calcSymbol;
        public string CalcSymbol
        {
            get => calcSymbol;
            set
            {
                calcSymbol = value;
                OnPropertyChanged();
            }
        }

        //Основное поле с вводимым выражением и результатом после нажатия кнопки =
        private string resultTextBox;
        public string ResultTextBox
        {
            get => resultTextBox;
            set
            {
                resultTextBox = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; }

        private void OnAddCommandNumberExecute(object p)
        {
            #region Метод, описывающий нажатие кнопок с цифрами
            void ClickNumberButton()
            {
                //Если произведено вычисление. Стираем предыдущие результаты. начинаем новое вычисление
                if (calculationCompleted == true)
                {
                    FirstNumberText = null;
                    SecondNumberText = null;
                    CalcSymbol = null;
                    InputTextBox = null;
                    ResultTextBox = null;
                    FirstNumberInputBool = true;
                    Calculation.result = null;
                    CalculationCompleted = false;
                    ResultTextBox += p.ToString();
                    FirstNumberText += p.ToString();
                }
                //Если вводим первое из чисел, до знака действия
                else if (FirstNumberInputBool == true)
                {
                    ResultTextBox += p.ToString();
                    FirstNumberText += p.ToString();
                }
                //Если вводим второе из чисел, после знака действия
                else if (FirstNumberInputBool == false)
                {
                    ResultTextBox += p.ToString();
                    SecondNumberText += p.ToString();
                }
            }
            #endregion


            switch (p.ToString())
            {
                #region Кнопки цифр
                case "0":
                    ClickNumberButton();
                    break;
                case "1":
                    ClickNumberButton();
                    break;
                case "2":
                    ClickNumberButton();
                    break;
                case "3":
                    ClickNumberButton();
                    break;
                case "4":
                    ClickNumberButton();
                    break;
                case "5":
                    ClickNumberButton();
                    break;
                case "6":
                    ClickNumberButton();
                    break;
                case "7":
                    ClickNumberButton();
                    break;
                case "8":
                    ClickNumberButton();
                    break;
                case "9":
                    ClickNumberButton();
                    break;


                #endregion

                #region Кнопки арифметических действий

                #region Кнопка +
                case "+":
                    if (ResultTextBox != null && !ResultTextBox.Contains("+") && CalcSymbol == null && CalculationCompleted == false)
                    {
                        ResultTextBox += p.ToString();
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    //Если продолжается расчет после нажатия кнопки = и надо  сохранить предыдущий результат
                    else if (CalcSymbol != null && CalculationCompleted == true)
                    {
                        CalculationCompleted = false;
                        FirstNumberText = ResultTextBox;
                        SecondNumberText = null;
                        ResultTextBox += p.ToString();
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    //Если необходимо поменять введенный ранее знак действия перед нажатием кнопки =
                    else if (CalcSymbol != null)
                    {
                        string changeCalcSymbol = ResultTextBox.Replace(char.Parse(CalcSymbol), char.Parse(p.ToString()));
                        ResultTextBox = changeCalcSymbol;
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    break;
                #endregion

                #region Кнопка -
                case "-":
                    if (ResultTextBox != null && !ResultTextBox.Contains("+") && CalcSymbol == null && CalculationCompleted == false)
                    {
                        ResultTextBox += p.ToString();
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    //Если продолжается расчет после нажатия кнопки = и надо  сохранить предыдущий результат
                    else if (CalcSymbol != null && CalculationCompleted == true)
                    {
                        CalculationCompleted = false;
                        FirstNumberText = ResultTextBox;
                        SecondNumberText = null;
                        ResultTextBox += p.ToString();
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    //Если необходимо поменять введенный ранее знак действия перед нажатием кнопки =
                    else if (CalcSymbol != null)
                    {
                        string changeCalcSymbol = ResultTextBox.Replace(char.Parse(CalcSymbol), char.Parse(p.ToString()));
                        ResultTextBox = changeCalcSymbol;
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    break;
                #endregion

                #region Кнопка ×
                case "×":
                    if (ResultTextBox != null && !ResultTextBox.Contains("×") && CalcSymbol == null && CalculationCompleted == false)
                    {
                        ResultTextBox += p.ToString();
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    //Если продолжается расчет после нажатия кнопки = и надо  сохранить предыдущий результат
                    else if (CalcSymbol != null && CalculationCompleted == true)
                    {
                        CalculationCompleted = false;
                        FirstNumberText = ResultTextBox;
                        SecondNumberText = null;
                        ResultTextBox += p.ToString();
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    //Если необходимо поменять введенный ранее знак действия перед нажатием кнопки =
                    else if (CalcSymbol != null)
                    {
                        string changeCalcSymbol = ResultTextBox.Replace(char.Parse(CalcSymbol), char.Parse(p.ToString()));
                        ResultTextBox = changeCalcSymbol;
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    break;
                #endregion

                #region Кнопка ÷
                case "÷":
                    if (ResultTextBox != null && !ResultTextBox.Contains("÷") && CalcSymbol == null && CalculationCompleted == false)
                    {
                        ResultTextBox += p.ToString();
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    //Если продолжается расчет после нажатия кнопки = и надо  сохранить предыдущий результат
                    else if (CalcSymbol != null && CalculationCompleted == true)
                    {
                        CalculationCompleted = false;
                        FirstNumberText = ResultTextBox;
                        SecondNumberText = null;
                        ResultTextBox += p.ToString();
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    //Если необходимо поменять введенный ранее знак действия перед нажатием кнопки =
                    else if (CalcSymbol != null)
                    {
                        string changeCalcSymbol = ResultTextBox.Replace(char.Parse(CalcSymbol), char.Parse(p.ToString()));
                        ResultTextBox = changeCalcSymbol;
                        CalcSymbol = p.ToString();
                        FirstNumberInputBool = false;
                    }
                    break;
                #endregion

                #endregion

                #region Конпка ,
                case ",":
                    if (FirstNumberInputBool == true && FirstNumberText != null && !FirstNumberText.Contains(","))
                    {
                        ResultTextBox += p.ToString();
                        FirstNumberText += p.ToString();
                    }
                    else if (FirstNumberInputBool == false && SecondNumberText != null && !SecondNumberText.Contains(","))
                    {
                        ResultTextBox += p.ToString();
                        SecondNumberText += p.ToString();
                    }
                    else
                        break;
                    break;
                #endregion

                #region Кнопка C
                case "C":
                    FirstNumberText = null;
                    SecondNumberText = null;
                    CalcSymbol = null;
                    InputTextBox = null;
                    ResultTextBox = null;
                    FirstNumberInputBool = true;
                    Calculation.result = null;
                    CalculationCompleted = false;
                    break;
                #endregion

                #region Кнопка CE
                case "CE":
                    if (FirstNumberInputBool == true && CalculationCompleted == false)
                    {
                        FirstNumberText = null;
                        InputTextBox = null;
                        ResultTextBox = null;
                        CalculationCompleted = false;
                    }
                    else if (FirstNumberInputBool == false && CalculationCompleted == false)
                    {
                        string[] resultTextBoxSplitted = resultTextBox.Split(new char[] { char.Parse(CalcSymbol) });

                        SecondNumberText = null;
                        ResultTextBox = resultTextBoxSplitted[0] + CalcSymbol;
                        CalculationCompleted = false;
                    }
                    else if (CalculationCompleted == true)
                    {
                        FirstNumberText = null;
                        SecondNumberText = null;
                        CalcSymbol = null;
                        InputTextBox = null;
                        ResultTextBox = null;
                        FirstNumberInputBool = true;
                        Calculation.result = null;
                        CalculationCompleted = false;
                    }
                    break;
                #endregion

                #region Кнопка ±
                case "±":
                    string resultTextBoxChangeSign;
                    string firstNumberChangeSign;
                    string secondNumberChangeSign;

                    if (FirstNumberInputBool == true && ResultTextBox != null && !ResultTextBox.StartsWith("-") && CalculationCompleted == false)
                    {
                        resultTextBoxChangeSign = "-" + ResultTextBox;
                        firstNumberChangeSign = "-" + FirstNumberText;
                        ResultTextBox = resultTextBoxChangeSign;
                        FirstNumberText = firstNumberChangeSign;
                    }
                    else if (FirstNumberInputBool == true && ResultTextBox != null && ResultTextBox.StartsWith("-") && CalculationCompleted == false)
                    {
                        resultTextBoxChangeSign = ResultTextBox.Remove(0, 1);
                        firstNumberChangeSign = FirstNumberText.Remove(0, 1);
                        ResultTextBox = resultTextBoxChangeSign;
                        FirstNumberText = firstNumberChangeSign;
                    }
                    else if (FirstNumberInputBool == false && SecondNumberText != null && !SecondNumberText.StartsWith("-") && CalculationCompleted == false)
                    {
                        string[] resultTextBoxSplitted = resultTextBox.Split(new char[] { char.Parse(CalcSymbol) });

                        secondNumberChangeSign = "-" + resultTextBoxSplitted[1];
                        SecondNumberText = secondNumberChangeSign;
                        ResultTextBox = FirstNumberText + CalcSymbol + SecondNumberText;
                    }
                    else if (FirstNumberInputBool == false && SecondNumberText != null && SecondNumberText.StartsWith("-") && CalculationCompleted == false)
                    {
                        string[] resultTextBoxSplitted = resultTextBox.Split(new char[] {char.Parse(CalcSymbol)});

                        secondNumberChangeSign = resultTextBoxSplitted[1].Remove(0, 1);
                        SecondNumberText = secondNumberChangeSign;
                        ResultTextBox = FirstNumberText + CalcSymbol + SecondNumberText;
                    }
                    else if (!ResultTextBox.StartsWith("-") && CalculationCompleted == true)
                    {
                        resultTextBoxChangeSign = "-" + ResultTextBox;
                        ResultTextBox = resultTextBoxChangeSign;
                    }
                    else if (ResultTextBox.StartsWith("-") && CalculationCompleted == true)
                    {
                        string[] resultTextBoxSplitted = resultTextBox.Split(new char[] { char.Parse(CalcSymbol) });
                        resultTextBoxChangeSign = ResultTextBox.Remove(0, 1);
                        ResultTextBox = resultTextBoxChangeSign;
                    }
                    else
                        break;
                    break;
                #endregion

                #region Кнопка =
                case "=":
                    if (CalculationCompleted == false)
                    {
                        try
                        {
                            InputTextBox = ResultTextBox + p.ToString();
                            ResultTextBox = Calculation.GetResult(FirstNumberText, SecondNumberText, ResultTextBox, CalcSymbol, CalculationCompleted);
                            CalculationCompleted = true;
                        }
                        finally
                        {

                        }
                    }
                    else if (CalculationCompleted == true)
                    {
                        try
                        {
                            InputTextBox = ResultTextBox + CalcSymbol + SecondNumberText + p.ToString();
                            ResultTextBox = Calculation.GetResult(FirstNumberText, SecondNumberText, ResultTextBox, CalcSymbol, CalculationCompleted);
                        }
                        finally
                        {

                        }
                    }
                    break;
                #endregion

                #region Кнопка ←
                case "←":
                    string resultTextBoxDel;
                    string firstNumberDel;
                    string secondNumberDel;




                    //Менять

                    if (ResultTextBox == "")
                    {
                        break;
                    }
                    else if (CalculationCompleted == true)
                    {
                        break;
                    }
                    else if (FirstNumberInputBool == true && FirstNumberText != null && CalculationCompleted == false)
                    {
                        resultTextBoxDel = ResultTextBox.Remove(ResultTextBox.Length - 1);
                        ResultTextBox = resultTextBoxDel;
                        firstNumberDel = FirstNumberText.Remove(FirstNumberText.Length - 1);
                        FirstNumberText = firstNumberDel;
                        break;
                    }
                    else if ((ResultTextBox.EndsWith("+") || ResultTextBox.EndsWith("-") || ResultTextBox.EndsWith("×") || ResultTextBox.EndsWith("÷")) && CalculationCompleted == false)
                    {
                        resultTextBoxDel = ResultTextBox.Remove(ResultTextBox.Length - 1);
                        ResultTextBox = resultTextBoxDel;
                        CalcSymbol = null;
                        SecondNumberText = null;
                        FirstNumberInputBool = true;
                        break;
                    }
                    else if (FirstNumberInputBool == false && SecondNumberText != null && CalculationCompleted == false)
                    {
                        resultTextBoxDel = ResultTextBox.Remove(ResultTextBox.Length - 1);
                        ResultTextBox = resultTextBoxDel;
                        secondNumberDel = SecondNumberText.Remove(SecondNumberText.Length - 1);
                        SecondNumberText = secondNumberDel;
                        break;
                    }
                    else
                    {
                        break;
                    }
                    break;

                #endregion

                default:
                    break;
            }

        }

        private bool CanAddCommandNumberExecuted(object p)
        {
            return true;
        }

        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandNumberExecute, CanAddCommandNumberExecuted);
        }

    }
}
