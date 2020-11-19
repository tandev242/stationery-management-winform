using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPP_management.DTO
{
    public class inventory
    {
        private int idProduct;
        private int idCategory;
        private int quantity;
        private int priceBuy;
        public inventory()
        { }
        public inventory(int idProduct , int idCategory ,int quantity , int priceBuy)
        {
            this.IdProduct = idProduct;
            this.IdCategory = idCategory;
            this.Quantity = quantity;
            this.PriceBuy = priceBuy;
        }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int PriceBuy { get => priceBuy; set => priceBuy = value; }
    }
}
