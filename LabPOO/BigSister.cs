using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{
    class BigSister
    {
        Product product;
        List<string> receta;

        public delegate void bigsister(Product product, List<string> receta);
        public event bigsister AlCarro;
        public void SacarDelCarro(Product product, List<string> receta)
        {
            var evento = AlCarro;

            if (receta.Contains(product.Name))
            { }
            else
            {
                receta.Remove(product.Name);
                Console.WriteLine("Matias!! eso no e sparte de la receta >:v");

            }

        }

        public void TerminarCompra(List<string> receta, List<Product> Carro)
        {
            foreach(Product producto in Carro)
            {
                if(receta.Contains(producto.Name))
                {
                    continue;
                }
            }
        }
    }
}
