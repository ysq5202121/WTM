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
    public partial class BudgetCategoryBatchVM : BaseBatchVM<BudgetCategory, BudgetCategory_BatchEdit>
    {
        public BudgetCategoryBatchVM()
        {
            ListVM = new BudgetCategoryListVM();
            LinkedVM = new BudgetCategory_BatchEdit();
        }

    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class BudgetCategory_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
