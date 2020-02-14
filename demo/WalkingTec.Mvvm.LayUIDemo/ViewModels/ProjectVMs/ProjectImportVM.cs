using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.ProjectVMs
{
    public partial class ProjectTemplateVM : BaseTemplateVM
    {
        [Display(Name = "项目编号")]
        public ExcelPropety ProjectNo_Excel = ExcelPropety.CreateProperty<Project>(x => x.ProjectNo);
        [Display(Name = "项目名称")]
        public ExcelPropety ProjectName_Excel = ExcelPropety.CreateProperty<Project>(x => x.ProjectName);
        public ExcelPropety Province_Excel = ExcelPropety.CreateProperty<Project>(x => x.ProvinceID);
        public ExcelPropety City_Excel = ExcelPropety.CreateProperty<Project>(x => x.CityID);
        public ExcelPropety ContractorA_Excel = ExcelPropety.CreateProperty<Project>(x => x.ContractorAID);
        public ExcelPropety ContractorB_Excel = ExcelPropety.CreateProperty<Project>(x => x.ContractorBID);
        [Display(Name = "合同简介")]
        public ExcelPropety ContractIntroduction_Excel = ExcelPropety.CreateProperty<Project>(x => x.ContractIntroduction);
        [Display(Name = "合同签订日期")]
        public ExcelPropety ContractSignDate_Excel = ExcelPropety.CreateProperty<Project>(x => x.ContractSignDate);
        [Display(Name = "合同结束日期")]
        public ExcelPropety ContractEndDate_Excel = ExcelPropety.CreateProperty<Project>(x => x.ContractEndDate);
        [Display(Name = "合同总金额")]
        public ExcelPropety ContractAmount_Excel = ExcelPropety.CreateProperty<Project>(x => x.ContractAmount);
        [Display(Name = "质押金")]
        public ExcelPropety CashPledge_Excel = ExcelPropety.CreateProperty<Project>(x => x.CashPledge);
        [Display(Name = "固定预算额")]
        public ExcelPropety SpecifiedBudgeAmount_Excel = ExcelPropety.CreateProperty<Project>(x => x.SpecifiedBudgeAmount);
        [Display(Name = "概率预算额")]
        public ExcelPropety EstimateBudgeAmount_Excel = ExcelPropety.CreateProperty<Project>(x => x.EstimateBudgeAmount);
        [Display(Name = "项目状态")]
        public ExcelPropety Status_Excel = ExcelPropety.CreateProperty<Project>(x => x.Status);

	    protected override void InitVM()
        {
            Province_Excel.DataType = ColumnDataType.ComboBox;
            Province_Excel.ListItems = DC.Set<Province>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ProvinceName);
            City_Excel.DataType = ColumnDataType.ComboBox;
            City_Excel.ListItems = DC.Set<City>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.CityName);
            ContractorA_Excel.DataType = ColumnDataType.ComboBox;
            ContractorA_Excel.ListItems = DC.Set<Contractor>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ContractorName);
            ContractorB_Excel.DataType = ColumnDataType.ComboBox;
            ContractorB_Excel.ListItems = DC.Set<Contractor>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ContractorName);
        }

    }

    public class ProjectImportVM : BaseImportVM<ProjectTemplateVM, Project>
    {

    }

}
