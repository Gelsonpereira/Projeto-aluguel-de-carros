using System;
using Aluguel_de_carro.Entities;

namespace Aluguel_de_carro.Service
{
    class BrazilTaxService
    {
        public double Tax(double amout)
        {
            if (amout <= 100.0)
            {
                return amout * 0.2;
            }
            else
            {
                return amout * 0.15;
            }
        }
    }
}
