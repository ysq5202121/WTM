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
    public partial class ProvinceTemplateVM : BaseTemplateVM
    {
        [Display(Name = "省份名称")]
        public ExcelPropety ProvinceName_Excel = ExcelPropety.CreateProperty<Province>(x => x.ProvinceName);
        [Display(Name = "省份编号")]
        public ExcelPropety ProvinceCode_Excel = ExcelPropety.CreateProperty<Province>(x => x.ProvinceCode);

	    protected override void InitVM()
        {
        }

    }

    public class ProvinceImportVM : BaseImportVM<ProvinceTemplateVM, Province>
    {

    }

}
