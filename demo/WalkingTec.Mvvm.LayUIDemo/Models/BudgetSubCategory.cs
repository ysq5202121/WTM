using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    /// <summary>
    /// 预算品类
    /// </summary>
    public class BudgetSubCategory : BasePoco
    {
        [Display(Name = "预算分类")]
        [Required(ErrorMessage = "{0}是必填项")]
        public Guid? BudgetCategoryID { get; set; }
        public BudgetCategory BudgetCategory { get; set; }

        [Display(Name = "品类名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string SubCategoryName { get; set; }

        [Display(Name = "计量单位")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(10, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Unit { get; set; }
    }
}
