using System.ComponentModel.DataAnnotations;

namespace RunTheSneakers.Models
{
    public class ProductPhoto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }
        [EnumDataType(typeof(PhotoType))]
        public  PhotoType PhotoType { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }

    public enum PhotoType
    {   Overall=1,
        Front = 2,
        Back = 3,
        LeftSide = 4,
        RightSide = 5,
        Details = 6
    }
}