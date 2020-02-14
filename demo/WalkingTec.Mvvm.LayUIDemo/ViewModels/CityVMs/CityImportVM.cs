using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.CityVMs
{
    public partial class CityTemplateVM : BaseTemplateVM
    {
        public ExcelPropety Province_Excel = ExcelPropety.CreateProperty<City>(x => x.ProvinceID);
        [Display(Name = "城市名称")]
        public ExcelPropety CityName_Excel = ExcelPropety.CreateProperty<City>(x => x.CityName);
        [Display(Name = "城市坐标")]
        public ExcelPropety LocationPoint_Excel = ExcelPropety.CreateProperty<City>(x => x.LocationPoint);

	    protected override void InitVM()
        {
            Province_Excel.DataType = ColumnDataType.ComboBox;
            Province_Excel.ListItems = DC.Set<Province>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ProvinceName);
        }

    }

    public class CityImportVM : BaseImportVM<CityTemplateVM, City>
    {

    }

}
