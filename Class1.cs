using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt6
{
    internal class Pair
    {
        /// <summary>
        /// Класс для пар чисел и операций сравнения и вычитания
        /// </summary>
        public int Pair1 { get; set; }
        public int Pair2 { get; set; }
        /// <summary>
        /// Метод для Проверки чисел первой пары на равенство
        /// </summary>
        /// <returns>Логическое значение "верно" или "неверно"</returns>
        /// 
        public Pair()
        {
            Pair1 = 0;
            Pair2 = 0;
        }

        public bool Prov()
        {
            return Pair1 == Pair2;
        }
        /// <summary>
        /// Метод для нахождения произведния чисел в первой паре
        /// </summary>
        /// <returns>Произведение первого числа пары на второе</returns>
        public int Peremnozh()
        {
            return Pair1 * Pair2;
        }
        /// <summary>
        /// Метод для нахождения разности первой пары и второй пары
        /// </summary>
        /// <param name="value">Объект класса обозначающий вторую пару</param>
        /// <param name="dop1">Значение от разности первого числа перв пары и второй пары</param>
        /// <param name="dop2">Значение от разности второго числа перв пары и второй пары</param>
        public void Vichit(Pair value, out int dop1, out int dop2)
        {
            dop1 = Pair1 - value.Pair1;
            dop2 = Pair2 - value.Pair2;
        }
        /// <summary>
        /// Метод для нахождения разности первой,второй и третьей пары
        /// </summary>
        /// <param name="value1">Объект обозначающий вторую пару</param>
        /// <param name="value2">Объект обозначающий третью пару</param>
        /// <param name="dop1">Значение разности первых чисел перв пары,второй и третьей</param>
        /// <param name="dop2">Значение разности вторых чисел перв пары,второй и третьей</param>
        public void Vichit(Pair value1, Pair value2, out int dop1, out int dop2)
        {
            dop1 = Pair1 - value1.Pair1 - value2.Pair1;
            dop2 = Pair2 - value1.Pair2 - value2.Pair2;
        }
    }
}
