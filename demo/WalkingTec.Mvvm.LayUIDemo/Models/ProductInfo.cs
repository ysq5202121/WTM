using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    [Table("ProductInfo")]
    public class ProductInfo : BasePoco
    {
        [Display(Name = "商品名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(1000, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ProductName { get; set; }

        [Display(Name = "商品编号")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductNo { get; set; }

        [Display(Name = "商品品牌")]
        [StringLength(1000)]
        public string ProductBrand { get; set; }

        [Display(Name = "商品规格")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(100, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ProductFormat { get; set; }

        [Display(Name = "商品单位")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(10, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ProductUnit { get; set; }

        [Display(Name = "价格")]
        [Required(ErrorMessage = "{0}是必填项")]
        [Range(0, double.MaxValue)]
        public decimal SellPrice { get; set; }

        [Display(Name = "商品描述")]
        public string Description { get; set; }

        [Display(Name = "备注")]
        public string Remark { get; set; }
    }
}
