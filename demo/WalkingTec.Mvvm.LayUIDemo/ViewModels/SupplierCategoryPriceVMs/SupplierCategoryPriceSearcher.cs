using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.SupplierCategoryPriceVMs
{
    public partial class SupplierCategoryPriceSearcher : BaseSearcher
    {
        public List<ComboSelectListItem> AllBudgetCategorys { get; set; }
        public Guid? BudgetCategoryID { get; set; }
        public List<ComboSelectListItem> AllBudgetSubCategorys { get; set; }
        public Guid? BudgetSubCategoryID { get; set; }
        public List<ComboSelectListItem> AllSuppliers { get; set; }
        public Guid? SupplierID { get; set; }

        protected override void InitVM()
        {
            AllBudgetCategorys = DC.Set<BudgetCategory>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.CategoryName);
            AllBudgetSubCategorys = DC.Set<BudgetSubCategory>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.SubCategoryName);
            AllSuppliers = DC.Set<Supplier>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.SupplierName);
        }

    }
}
