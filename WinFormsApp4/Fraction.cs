using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public string Verbose()
        {
            if (Math.Abs(this.numerator) >= Math.Abs(this.denominator))
            {
                int wholeNumber = Math.Abs(this.numerator / this.denominator); // целая часть
                int newNumerator = Math.Abs(this.numerator % this.denominator); // числитель дробной части
                if (this.numerator > 0 && this.denominator > 0 || this.numerator < 0 && this.denominator < 0)
                {
                    if (newNumerator == 0) // если дробь является целым числом
                    {
                        return wholeNumber.ToString();
                    }
               
                else // если дробь является несократимым
                {
                    int reduce = gcd(this.denominator, newNumerator);
                    return string.Format("{0} {1}/{2}", wholeNumber, newNumerator / reduce, this.denominator / reduce);
                } 
                }
                else
                {
                    if (newNumerator == 0) // если дробь является целым числом
                    {
                        return "-"+ Math.Abs(wholeNumber).ToString();
                    }

                    else // если дробь является несократимым
                    {
                        int reduce = gcd(this.denominator, newNumerator);
                        return string.Format("-{0} {1}/{2}", Math.Abs(wholeNumber), Math.Abs(newNumerator / reduce), Math.Abs(this.denominator / reduce));
                    }
                }
            }
            else
            {
                if (this.numerator > 0 && this.denominator > 0 || this.numerator < 0 && this.denominator < 0)
                {
                    return String.Format("{0}/{1}", Math.Abs(this.numerator), Math.Abs(this.denominator));
                }
                else
                {
                    return String.Format("-{0}/{1}", Math.Abs(this.numerator), Math.Abs(this.denominator));
                }
            }

        }

        static int gcd(int a, int b)//сокращение
        {
            if (b == 0)
            {
                return a;
            }
            return gcd(b, a % b);
        }
        public static Fraction operator +(Fraction instance, Fraction second)
        {
            // расчитываем новую значение
            int newValue_denominator;
            int newValue_numerator;
            if (instance.denominator == second.denominator)
            {
                newValue_numerator = instance.numerator + second.numerator;
                newValue_denominator = instance.denominator;
            }
            else
            {
                newValue_denominator = instance.denominator * second.denominator;
                newValue_numerator = instance.numerator * second.denominator + second.numerator + instance.denominator;
            }

            int reduction = gcd(newValue_denominator, newValue_numerator);
            newValue_denominator /= reduction;
            newValue_numerator /= reduction;

            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var fraction = new Fraction(newValue_numerator, newValue_denominator);

            // возвращаем результат
            return fraction;
        }
        public static Fraction operator -(Fraction instance, Fraction second)
        {
            // расчитываем новую значение
            int newValue_denominator;
            int newValue_numerator;

            if (instance.denominator == second.denominator)
            {
                newValue_numerator = instance.numerator - second.numerator;
                newValue_denominator = instance.denominator;
            }
            else
            {
                newValue_denominator = instance.denominator * second.denominator;
                newValue_numerator = instance.numerator * second.denominator - second.numerator + instance.denominator;
            }

            
                int reduction = gcd(newValue_denominator, newValue_numerator);
                newValue_denominator /= reduction;
                newValue_numerator /= reduction;
          
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var fraction = new Fraction(newValue_numerator, newValue_denominator);

            // возвращаем результат
            return fraction;
        }
        public static Fraction operator *(Fraction instance, Fraction second)
        {
            // расчитываем новую значение
            int newValue_denominator;
            int newValue_numerator;
            newValue_denominator= instance.denominator*second.denominator;
            newValue_numerator = instance.numerator * second.numerator;
            int reduction = gcd(newValue_denominator, newValue_numerator);
            newValue_denominator /= reduction;
            newValue_numerator /= reduction;
            var fraction = new Fraction(newValue_numerator, newValue_denominator);
            return fraction;
        }
        public static Fraction operator /(Fraction instance, Fraction second)
        {
            // расчитываем новую значение
            int newValue_denominator;
            int newValue_numerator;
            int temp=second.numerator;
            second.numerator=second.denominator;
            second.denominator=temp;
            newValue_denominator = instance.denominator * second.denominator;
            newValue_numerator = instance.numerator * second.numerator;
            int reduction = gcd(newValue_denominator, newValue_numerator);
            newValue_denominator /= reduction;
            newValue_numerator /= reduction;
            var fraction = new Fraction(newValue_numerator, newValue_denominator);
            return fraction;
        }
        public static bool operator >(Fraction instance, Fraction second)
        {
            // расчитываем новую значение
            int newValue_denominator;
            int newValue_numerator;
            int temp = second.numerator;
            second.numerator = second.denominator;
            second.denominator = temp;
            newValue_denominator = instance.denominator * second.denominator;
            newValue_numerator = instance.numerator * second.numerator;
            int reduction = gcd(newValue_denominator, newValue_numerator);
            newValue_denominator /= reduction;
            newValue_numerator /= reduction;
            var fraction = new Fraction(newValue_numerator, newValue_denominator);
            return fraction;
        }
        public static bool operator >=(Fraction instance, Fraction second)
        {
            // расчитываем новую значение
            int newValue_denominator;
            int newValue_numerator;
            int temp = second.numerator;
            second.numerator = second.denominator;
            second.denominator = temp;
            newValue_denominator = instance.denominator * second.denominator;
            newValue_numerator = instance.numerator * second.numerator;
            int reduction = gcd(newValue_denominator, newValue_numerator);
            newValue_denominator /= reduction;
            newValue_numerator /= reduction;
            var fraction = new Fraction(newValue_numerator, newValue_denominator);
            return fraction;
        }
        public static bool operator <=(Fraction instance, Fraction second)
        {
            // расчитываем новую значение
            int newValue_denominator;
            int newValue_numerator;
            int temp = second.numerator;
            second.numerator = second.denominator;
            second.denominator = temp;
            newValue_denominator = instance.denominator * second.denominator;
            newValue_numerator = instance.numerator * second.numerator;
            int reduction = gcd(newValue_denominator, newValue_numerator);
            newValue_denominator /= reduction;
            newValue_numerator /= reduction;
            var fraction = new Fraction(newValue_numerator, newValue_denominator);
            return fraction;
        }
        public static bool operator <(Fraction instance, Fraction second)
        {
            // расчитываем новую значение
            int newValue_denominator;
            int newValue_numerator;
            int temp = second.numerator;
            second.numerator = second.denominator;
            second.denominator = temp;
            newValue_denominator = instance.denominator * second.denominator;
            newValue_numerator = instance.numerator * second.numerator;
            int reduction = gcd(newValue_denominator, newValue_numerator);
            newValue_denominator /= reduction;
            newValue_numerator /= reduction;
            var fraction = new Fraction(newValue_numerator, newValue_denominator);
            return fraction;
        }
        public static bool operator ==(Fraction instance, Fraction second)
        {
            // расчитываем новую значение
            int newValue_denominator;
            int newValue_numerator;
            int temp = second.numerator;
            second.numerator = second.denominator;
            second.denominator = temp;
            newValue_denominator = instance.denominator * second.denominator;
            newValue_numerator = instance.numerator * second.numerator;
            int reduction = gcd(newValue_denominator, newValue_numerator);
            newValue_denominator /= reduction;
            newValue_numerator /= reduction;
            var fraction = new Fraction(newValue_numerator, newValue_denominator);
            return fraction;
        }
        public static bool operator !=(Fraction instance, Fraction second)
        {
            // расчитываем новую значение
            int newValue_denominator;
            int newValue_numerator;
            int temp = second.numerator;
            second.numerator = second.denominator;
            second.denominator = temp;
            newValue_denominator = instance.denominator * second.denominator;
            newValue_numerator = instance.numerator * second.numerator;
            int reduction = gcd(newValue_denominator, newValue_numerator);
            newValue_denominator /= reduction;
            newValue_numerator /= reduction;
            var fraction = new Fraction(newValue_numerator, newValue_denominator);
            return fraction;
        }
    }
}
