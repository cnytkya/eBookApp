using eBookApp.EntityLayer.Interface;
using System.Collections;

namespace eBookApp.EntityLayer.Entities
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Logo { get; set; }
        public bool IsActive { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<Product>? Products { get; set; }
    }
}