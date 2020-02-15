using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.BudgetCategoryVMs
{
    public partial class BudgetCategorySearcher : BaseSearcher
    {
        [Display(Name = "类别编号")]
        public String CategoryCode { get; set; }

        [Display(Name = "类别名称")]
        public String CategoryName { get; set; }

        protected override void InitVM()
        {
        }

    }
}
