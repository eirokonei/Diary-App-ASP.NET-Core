using System.ComponentModel.DataAnnotations;

namespace MyDiary.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter a Title")]
        //[StringLength(100, ErrorMessage = "Title Should be Between 3 to 100 Characters", MinimumLength = 3)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Write About Your Day")]
        public string Content { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter a Date")]
        public DateTime Created { get; set; } = DateTime.Now;

    }
}
