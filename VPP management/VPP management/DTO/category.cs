using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPP_management.DTO
{
    public class category
    {
        private int id;
        private String nameCategory;
        public category()
        { }
        public category(int id , String nameCategory)
        {
            this.Id = id;
            this.NameCategory = nameCategory;
        }

        public int Id { get => id; set => id = value; }
        public string NameCategory { get => nameCategory; set => nameCategory = value; }
    }
}
