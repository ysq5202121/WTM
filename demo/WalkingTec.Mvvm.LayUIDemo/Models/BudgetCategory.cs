using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    /// <summary>
    /// 预算分类
    /// </summary>
    public class BudgetCategory : BasePoco
    {
        [Display(Name = "预算类别编号")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(10, ErrorMessage = "{0}最多输入{1}个字符")]
        public string CategoryCode { get; set; }

        [Display(Name = "预算类别名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string CategoryName { get; set; }


        public List<BudgetSubCategory> BudgetSubCategories { get; set; }
    }
}
