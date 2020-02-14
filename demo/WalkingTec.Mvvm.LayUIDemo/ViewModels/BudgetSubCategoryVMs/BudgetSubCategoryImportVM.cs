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
    public partial class BudgetSubCategoryTemplateVM : BaseTemplateVM
    {
        public ExcelPropety BudgetCategory_Excel = ExcelPropety.CreateProperty<BudgetSubCategory>(x => x.BudgetCategoryID);
        [Display(Name = "品类名称")]
        public ExcelPropety SubCategoryName_Excel = ExcelPropety.CreateProperty<BudgetSubCategory>(x => x.SubCategoryName);
        [Display(Name = "计量单位")]
        public ExcelPropety Unit_Excel = ExcelPropety.CreateProperty<BudgetSubCategory>(x => x.Unit);

	    protected override void InitVM()
        {
            BudgetCategory_Excel.DataType = ColumnDataType.ComboBox;
            BudgetCategory_Excel.ListItems = DC.Set<BudgetCategory>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.CategoryName);
        }

    }

    public class BudgetSubCategoryImportVM : BaseImportVM<BudgetSubCategoryTemplateVM, BudgetSubCategory>
    {

    }

}
