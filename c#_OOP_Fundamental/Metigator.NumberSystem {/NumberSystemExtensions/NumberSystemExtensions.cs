using Metigator.NumberSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metigator.NumberSystem
{
    public static class NumberSystemExtensions
    {
        public static void Guard(this string source , string alloewdCharacter , NumberBase numberBase  ) {

            foreach (var ch in source) {
                if (!alloewdCharacter.Contains(ch)) {
                    throw new InvalidOperationException($"{source} is invalid {numberBase} format ");
                }
               
            }
        
        }

        public static string To<T>(this T source, NumberBase toBase) where T : Base
        {
            NumberBase fromBase;
            switch (source)
            {
                case BinarySystem: fromBase = NumberBase.BINARY;break;
                case DecimalSystem: fromBase = NumberBase.DECIMAL; break;
                case HexaDecimalSystem: fromBase = NumberBase.OCTAL; break;
                case OctalSystem: fromBase = NumberBase.HEXADECIMAL; break;
                default: fromBase = NumberBase.DECIMAL; break;

            }
            return Convert.ToString(Convert.ToInt32(source.Value,(int)fromBase ) , (int)toBase );   
        }
    }
}
