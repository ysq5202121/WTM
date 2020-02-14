using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.SupplierCategoryPriceVMs
{
    public partial class SupplierCategoryPriceVM : BaseCRUDVM<SupplierCategoryPrice>
    {
        public List<ComboSelectListItem> AllBudgetCategorys { get; set; }
        public List<ComboSelectListItem> AllBudgetSubCategorys { get; set; }
        public List<ComboSelectListItem> AllSuppliers { get; set; }

        public SupplierCategoryPriceVM()
        {
            SetInclude(x => x.BudgetCategory);
            SetInclude(x => x.BudgetSubCategory);
            SetInclude(x => x.Supplier);
        }

        protected override void InitVM()
        {
            AllBudgetCategorys = DC.Set<BudgetCategory>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.CategoryName);
            AllBudgetSubCategorys = DC.Set<BudgetSubCategory>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.SubCategoryName);
            AllSuppliers = DC.Set<Supplier>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.SupplierName);
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
