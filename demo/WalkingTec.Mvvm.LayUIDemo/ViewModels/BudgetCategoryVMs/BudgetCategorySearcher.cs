using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.BudgetCategoryVMs
{
    public partial class BudgetCategorySearcher : BaseSearcher
    {
        [Display(Name = "预算类别编号")]
        public String CategoryCode { get; set; }
        [Display(Name = "预算类别名称")]
        public String CategoryName { get; set; }

        protected override void InitVM()
        {
        }

    }
}
