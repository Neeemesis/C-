using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Quality
    {
        public Quality(string format, int value)
        {
            Format = format;
            Value = value;
        }

        /// <summary>
        /// Название
        /// </summary>
        public string Format { get; }

        /// <summary>
        /// Значение
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Значение
        /// </summary>
        public override string ToString() => string.Format(Format, Value);
    }
}
