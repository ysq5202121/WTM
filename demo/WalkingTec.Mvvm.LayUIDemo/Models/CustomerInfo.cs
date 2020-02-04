using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    [Table("CustomerInfo")]
    public class CustomerInfo : BasePoco
    {
        [Display(Name = "客户名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(1000, ErrorMessage = "{0}最多输入{1}个字符")]
        public string CustomerName { get; set; }

        [Display(Name = "客户编号")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerNo { get; set; }

        [Display(Name = "公司名称")]
        [StringLength(1000, ErrorMessage = "{0}最多输入{1}个字符")]
        public string CompanyName { get; set; }

        [Display(Name = "送货地址")]
        [StringLength(2000, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Address { get; set; }

        [Display(Name = "联系电话")]
        [StringLength(2000, ErrorMessage = "{0}最多输入{1}个字符")]
        public string CellPhone { get; set; }


        public List<OrderInfo> OrderInfoes { get; set; }
    }
}
