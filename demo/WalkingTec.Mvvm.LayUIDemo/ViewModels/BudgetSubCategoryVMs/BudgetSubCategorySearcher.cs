using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.BudgetSubCategoryVMs
{
    public partial class BudgetSubCategorySearcher : BaseSearcher
    {
        public List<ComboSelectListItem> AllBudgetCategorys { get; set; }
        public Guid? BudgetCategoryID { get; set; }
        [Display(Name = "品类名称")]
        public String SubCategoryName { get; set; }

        protected override void InitVM()
        {
            AllBudgetCategorys = DC.Set<BudgetCategory>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.CategoryName);
        }

    }
}
