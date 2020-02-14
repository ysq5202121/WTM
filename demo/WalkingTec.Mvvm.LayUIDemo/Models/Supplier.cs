using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    /// <summary>
    /// 供应商
    /// </summary>
    public class Supplier : BasePoco
    {
        [Display(Name = "供应商名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string SupplierName { get; set; }

        [Display(Name = "供应商地址")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(1000, ErrorMessage = "{0}最多输入{1}个字符")]
        public string SupplierAddress { get; set; }

        [Display(Name = "供应商联系人")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string SupplierContact { get; set; }

        [Display(Name = "供应商联系电话")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(20, ErrorMessage = "{0}最多输入{1}个字符")]
        public string SupplierPhone { get; set; }

        [Display(Name = "供应商手机号码")]
        [Required(ErrorMessage = "{0}是必填项")]
        [RegularExpression(@"^1([38][0-9]|4[579]|5[0-3,5-9]|6[6]|7[0135678]|9[89])\d{8}$", ErrorMessage = "请输入正确的手机号")]
        [StringLength(11)]
        public string SupplierTelephone { get; set; }

        public List<SupplierCategoryPrice> SupplierCategoryPrices { get; set; }
    }
}
