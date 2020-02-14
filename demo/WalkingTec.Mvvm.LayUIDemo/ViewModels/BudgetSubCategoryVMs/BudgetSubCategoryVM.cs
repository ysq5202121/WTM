using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.BudgetSubCategoryVMs
{
    public partial class BudgetSubCategoryVM : BaseCRUDVM<BudgetSubCategory>
    {
        public List<ComboSelectListItem> AllBudgetCategorys { get; set; }

        public BudgetSubCategoryVM()
        {
            SetInclude(x => x.BudgetCategory);
        }

        protected override void InitVM()
        {
            AllBudgetCategorys = DC.Set<BudgetCategory>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.CategoryName);
        }

        public override void DoAdd()
        {           
            base.DoAdd();
        }

        public override void DoEdit(bool updateAllFields = false)
        {
            base.DoEdit(updateAllFields);
        }

        public override void DoDelete()
        {
            base.DoDelete();
        }
    }
}
