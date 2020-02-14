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
    public partial class SupplierCategoryPriceBatchVM : BaseBatchVM<SupplierCategoryPrice, SupplierCategoryPrice_BatchEdit>
    {
        public SupplierCategoryPriceBatchVM()
        {
            ListVM = new SupplierCategoryPriceListVM();
            LinkedVM = new SupplierCategoryPrice_BatchEdit();
        }

    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class SupplierCategoryPrice_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
