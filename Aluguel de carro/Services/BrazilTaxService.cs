using System;
using Aluguel_de_carro.Entities;
using Aluguel_de_carro.Services;

namespace Aluguel_de_carro.Service
{
    class BrazilTaxService : ITaxService 
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
