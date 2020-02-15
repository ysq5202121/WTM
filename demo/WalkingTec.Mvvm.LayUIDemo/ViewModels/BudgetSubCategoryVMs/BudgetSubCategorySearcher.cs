using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.BudgetSubCategoryVMs
{
    public partial class BudgetSubCategorySearcher : BaseSearcher
    {
        [Display(Name = "预算分类")]
        public Guid? BudgetCategoryID { get; set; }
        public List<ComboSelectListItem> AllBudgetCategorys { get; set; }

        [Display(Name = "品类名称")]
        public String SubCategoryName { get; set; }

        protected override void InitVM()
        {
            AllBudgetCategorys = DC.Set<BudgetCategory>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.CategoryName);
        }
    }
}
