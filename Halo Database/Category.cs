using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Category
    {
        public Category()
        {
            Serviceprovidercategory = new HashSet<Serviceprovidercategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string BottomDescription { get; set; }
        public string Icon { get; set; }
        public string Alias { get; set; }
        public int CategoryTemplateId { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public int ParentCategoryId { get; set; }
        public int Published { get; set; }
        public int Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public string CreatedOnUtc { get; set; }
        public string UpdatedOnUtc { get; set; }

        public virtual ICollection<Serviceprovidercategory> Serviceprovidercategory { get; set; }
    }
}
