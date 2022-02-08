using System;

namespace SimpSimulator.Models
{
    public interface Student
    {
        public void accumulateDebt(ref decimal actualDebt) => actualDebt = Decimal.Multiply(actualDebt, 1.1m);  //este ref es para que el parametro apunte al mismo objeto que llama la metodo, aka, el cambio que le hago a este parametro afecta el objeto real

    }
}
