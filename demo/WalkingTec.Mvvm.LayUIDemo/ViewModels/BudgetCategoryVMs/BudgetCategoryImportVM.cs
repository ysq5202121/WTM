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
    public partial class BudgetCategoryTemplateVM : BaseTemplateVM
    {
        [Display(Name = "预算类别编号")]
        public ExcelPropety CategoryCode_Excel = ExcelPropety.CreateProperty<BudgetCategory>(x => x.CategoryCode);
        [Display(Name = "预算类别名称")]
        public ExcelPropety CategoryName_Excel = ExcelPropety.CreateProperty<BudgetCategory>(x => x.CategoryName);

	    protected override void InitVM()
        {
        }

    }

    public class BudgetCategoryImportVM : BaseImportVM<BudgetCategoryTemplateVM, BudgetCategory>
    {

    }

}
