using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.SupplierVMs
{
    public partial class SupplierTemplateVM : BaseTemplateVM
    {
        [Display(Name = "供应商名称")]
        public ExcelPropety SupplierName_Excel = ExcelPropety.CreateProperty<Supplier>(x => x.SupplierName);
        [Display(Name = "供应商地址")]
        public ExcelPropety SupplierAddress_Excel = ExcelPropety.CreateProperty<Supplier>(x => x.SupplierAddress);
        [Display(Name = "供应商联系人")]
        public ExcelPropety SupplierContact_Excel = ExcelPropety.CreateProperty<Supplier>(x => x.SupplierContact);
        [Display(Name = "供应商联系电话")]
        public ExcelPropety SupplierPhone_Excel = ExcelPropety.CreateProperty<Supplier>(x => x.SupplierPhone);
        [Display(Name = "供应商手机号码")]
        public ExcelPropety SupplierTelephone_Excel = ExcelPropety.CreateProperty<Supplier>(x => x.SupplierTelephone);

	    protected override void InitVM()
        {
        }

    }

    public class SupplierImportVM : BaseImportVM<SupplierTemplateVM, Supplier>
    {

    }

}
