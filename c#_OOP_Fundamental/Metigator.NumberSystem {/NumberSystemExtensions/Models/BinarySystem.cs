namespace Metigator.NumberSystem.Models
{
    public class BinarySystem : Base
    {
       public BinarySystem(string value) {  // number must be binary "01"
            value.Guard("01", NumberBase.BINARY);
            this.Value = value;  
               }
    }
}
