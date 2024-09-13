namespace Metigator.NumberSystem.Models
{
    public class HexaDecimalSystem : Base
    {
        public HexaDecimalSystem(string value)
        {  
            value.Guard("0123456789ABCDEFabcdef", NumberBase.HEXADECIMAL);
            this.Value = value;
        }
    }
}
