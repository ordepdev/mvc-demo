using System.ComponentModel;

namespace FirstMVCApplication.Models
{
    public class Project
    {
        [DisplayName("Code")]
        public int Id { get; set; }

        public string Title { get; set; }
    }
}