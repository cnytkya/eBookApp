using eBookApp.EntityLayer.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookApp.EntityLayer.Entities
{
    public class Contact : IEntity
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Sur Name")]
        public string SurName { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string Message { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}