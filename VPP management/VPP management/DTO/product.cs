using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPP_management.DTO
{
    public class product
    {
        private int iD;
        private int iDCategory;
        private String name;
        private String description;
        private Byte[] image;
        private int price;
        private int promotionPrice;
        private DateTime createdDate;
        private String createdBy;
        private DateTime modifiedDate;
        private String modifiedBy;
        private Boolean status;
        public product()
        { }
        public product(int iD, int iDCategory, String name, String description, Byte[] image, int price, int promotionPrice, DateTime createdDate, String createdBy, DateTime modifiedDate, String modifiedBy, Boolean status)
        {
            this.iD = iD;
            this.iDCategory = IDCategory;
            this.name = name;
            this.description = description;
            this.image = image;
            this.price = price;
            this.promotionPrice = promotionPrice;
            this.createdDate = createdDate;
            this.createdBy = createdBy;
            this.modifiedDate = modifiedDate;
            this.modifiedBy = modifiedBy;
            this.status = status;
        }
        public int ID { get => iD; set => iD = value; }
        public int IDCategory { get => iDCategory; set => iDCategory = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public byte[] Image { get => image; set => image = value; }
        public int Price { get => price; set => price = value; }
        public int PromotionPrice { get => promotionPrice; set => promotionPrice = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime ModifiedDate { get => modifiedDate; set => modifiedDate = value; }
        public string ModifiedBy { get => modifiedBy; set => modifiedBy = value; }
        public bool Status { get => status; set => status = value; }



    }
}
