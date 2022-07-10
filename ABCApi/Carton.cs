using System.ComponentModel.DataAnnotations;

namespace ABCApi
{
    /// <summary>
    /// A carton with picked articles
    /// </summary>
    public class Carton
    {
        /// <summary>
        /// Does the carton contain the right amount of product. True if it does. False if it does not.
        /// </summary>
        [Required]
        public bool IsOk { get; set; }
        /// <summary>
        /// SSCC barcode
        /// </summary>
        /// <example>008012349999999997</example>
        [Required(AllowEmptyStrings = false)]
        [StringLength(18, MinimumLength = 18)]
        public string Barcode { get; set; } = "";
        /// <summary>
        /// List of articles in this carton
        /// </summary>
        [Required]
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}
