using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.ProvinceVMs
{
    public partial class ProvinceBatchVM : BaseBatchVM<Province, Province_BatchEdit>
    {
        public ProvinceBatchVM()
        {
            ListVM = new ProvinceListVM();
            LinkedVM = new Province_BatchEdit();
        }

    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class Province_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
