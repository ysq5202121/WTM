using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    /// <summary>
    /// 承建商
    /// </summary>
    public class Contractor : BasePoco
    {
        [Display(Name = "省份")]
        public Guid? ProvinceID { get; set; }
        public Province Province { get; set; }

        [Display(Name = "公司名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ContractorName { get; set; }

        [Display(Name = "公司地址")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(1000, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ContractorAddress { get; set; }

        [Display(Name = "公司联系人")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ContractorContact { get; set; }

        [Display(Name = "邮编")]
        [Required(ErrorMessage = "{0}是必填项")]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "请输入正确的邮编号")]
        [StringLength(6)]
        public string ZipCode { get; set; }

        [Display(Name = "邮件")]
        [Required(ErrorMessage = "{0}是必填项")]
        [RegularExpression(@"^[A-Za-z0-9\u4e00-\u9fa5]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$", ErrorMessage = "请输入正确的邮箱")]
        [StringLength(100)]
        public string Email { get; set; }

        [Display(Name = "联系电话")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(20, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ContractorPhone { get; set; }
    }
}
