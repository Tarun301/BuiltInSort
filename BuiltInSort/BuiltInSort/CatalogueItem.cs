using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInSort
{
    class CatalogueItem : IComparable<CatalogueItem>
    {



        public Int32 Id { get; set; }
        public String ItemName { get; set; }
        public String Category { get; set; }

        public int CompareTo(CatalogueItem other)
        {
            return this.Category.CompareTo(other.Category);
        }

        // constructor
        public CatalogueItem(Int32 newId, String newName, String newCategory)
        {

            
            Category = newCategory;
            Id = newId;
            ItemName = newName;
        }

       
    }











}

