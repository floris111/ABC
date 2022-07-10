using System.ComponentModel.DataAnnotations;

namespace ABCApi
{
    public class Article
    {
        /// <summary>
        /// Unique article number of product
        /// </summary>
        /// <example>123456</example>
        [MaxLength(32)]
        [Required]
        public string ArticleNumber { get; set; } = "";
        /// <summary>
        /// Amount contained in carton
        /// </summary>
        /// <example>5</example>
        [Required]
        public int Quantity { get; set; }
        /// <summary>
        /// Does the carton contain the right amount for this product. True if it does. False if it does not.
        /// </summary>
        public bool IsOk { get; set; }
    }
}
