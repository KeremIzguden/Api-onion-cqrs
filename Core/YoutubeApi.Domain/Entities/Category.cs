using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;

namespace YoutubeApi.Domain.Entities
{
    public  class Category : EntityBase
    {
        public Category() { 
        
        }
        public Category(int parentId , string name ,int priorty) 
        {
            parentId = ParentId;
            name = Name;
            priorty = Priorty;

        }


        public required int ParentId { get; set; }
        public required string Name { get; set; }
        public  required int Priorty { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Detail> Details { get; set; }
    }
}
