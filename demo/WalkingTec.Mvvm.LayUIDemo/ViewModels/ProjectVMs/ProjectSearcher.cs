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
    public partial class ProjectSearcher : BaseSearcher
    {
        [Display(Name = "项目编号")]
        public String ProjectNo { get; set; }
        [Display(Name = "项目名称")]
        public String ProjectName { get; set; }
        public List<ComboSelectListItem> AllProvinces { get; set; }
        public Guid? ProvinceID { get; set; }
        public List<ComboSelectListItem> AllCitys { get; set; }
        public Guid? CityID { get; set; }
        public List<ComboSelectListItem> AllContractorAs { get; set; }
        public Guid? ContractorAID { get; set; }
        public List<ComboSelectListItem> AllContractorBs { get; set; }
        public Guid? ContractorBID { get; set; }
        [Display(Name = "合同签订日期")]
        public DateTime? ContractSignDate { get; set; }
        [Display(Name = "合同结束日期")]
        public DateTime? ContractEndDate { get; set; }
        [Display(Name = "项目状态")]
        public ProjectStatusEnum? Status { get; set; }

        protected override void InitVM()
        {
            AllProvinces = DC.Set<Province>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ProvinceName);
            AllCitys = DC.Set<City>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.CityName);
            AllContractorAs = DC.Set<Contractor>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ContractorName);
            AllContractorBs = DC.Set<Contractor>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ContractorName);
        }

    }
}
