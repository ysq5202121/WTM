using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.ContractorVMs
{
    public partial class ContractorBatchVM : BaseBatchVM<Contractor, Contractor_BatchEdit>
    {
        public ContractorBatchVM()
        {
            ListVM = new ContractorListVM();
            LinkedVM = new Contractor_BatchEdit();
        }

    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class Contractor_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
