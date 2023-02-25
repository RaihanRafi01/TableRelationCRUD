using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TableRelationCRUD.Models
{
    public class ProductModel
    {
        
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public int Product_Qty { get; set; }
        public int Category_Id { get; set;}
        public int Order_Id { get; set;}
    }
}