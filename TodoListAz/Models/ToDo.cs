using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoListAz.Models
{
    public class ToDo
    {
        [Key]
        public int todoId { get; set; }
        [DisplayName("Item")]
        public string todoItem { get; set; }
        [DisplayName("Created By")]
        public string createdBy { get; set; }
    }
}
