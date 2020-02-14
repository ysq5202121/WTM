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
    public partial class BudgetSubCategoryBatchVM : BaseBatchVM<BudgetSubCategory, BudgetSubCategory_BatchEdit>
    {
        public BudgetSubCategoryBatchVM()
        {
            ListVM = new BudgetSubCategoryListVM();
            LinkedVM = new BudgetSubCategory_BatchEdit();
        }

    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class BudgetSubCategory_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
