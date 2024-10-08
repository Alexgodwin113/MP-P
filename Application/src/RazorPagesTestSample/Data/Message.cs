using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(350, ErrorMessage = "There's a 350 character limit on messages.")]
        public string Text { get; set; }
    }
    #endregion
}
