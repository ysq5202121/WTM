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
    public partial class ContractorTemplateVM : BaseTemplateVM
    {
        public ExcelPropety Province_Excel = ExcelPropety.CreateProperty<Contractor>(x => x.ProvinceID);
        [Display(Name = "公司名称")]
        public ExcelPropety ContractorName_Excel = ExcelPropety.CreateProperty<Contractor>(x => x.ContractorName);
        [Display(Name = "公司地址")]
        public ExcelPropety ContractorAddress_Excel = ExcelPropety.CreateProperty<Contractor>(x => x.ContractorAddress);
        [Display(Name = "公司联系人")]
        public ExcelPropety ContractorContact_Excel = ExcelPropety.CreateProperty<Contractor>(x => x.ContractorContact);
        [Display(Name = "邮编")]
        public ExcelPropety ZipCode_Excel = ExcelPropety.CreateProperty<Contractor>(x => x.ZipCode);
        [Display(Name = "邮件")]
        public ExcelPropety Email_Excel = ExcelPropety.CreateProperty<Contractor>(x => x.Email);
        [Display(Name = "联系电话")]
        public ExcelPropety ContractorPhone_Excel = ExcelPropety.CreateProperty<Contractor>(x => x.ContractorPhone);

	    protected override void InitVM()
        {
            Province_Excel.DataType = ColumnDataType.ComboBox;
            Province_Excel.ListItems = DC.Set<Province>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ProvinceName);
        }

    }

    public class ContractorImportVM : BaseImportVM<ContractorTemplateVM, Contractor>
    {

    }

}
