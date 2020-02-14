using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.ProjectVMs
{
    public partial class ProjectVM : BaseCRUDVM<Project>
    {
        public List<ComboSelectListItem> AllProvinces { get; set; }
        public List<ComboSelectListItem> AllCitys { get; set; }
        public List<ComboSelectListItem> AllContractorAs { get; set; }
        public List<ComboSelectListItem> AllContractorBs { get; set; }

        public ProjectVM()
        {
            SetInclude(x => x.Province);
            SetInclude(x => x.City);
            SetInclude(x => x.ContractorA);
            SetInclude(x => x.ContractorB);
        }

        protected override void InitVM()
        {
            AllProvinces = DC.Set<Province>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ProvinceName);
            AllCitys = DC.Set<City>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.CityName);
            AllContractorAs = DC.Set<Contractor>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ContractorName);
            AllContractorBs = DC.Set<Contractor>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ContractorName);
        }

        public override void DoAdd()
        {           
            base.DoAdd();
        }

        public override void DoEdit(bool updateAllFields = false)
        {
            base.DoEdit(updateAllFields);
        }

        public override void DoDelete()
        {
            base.DoDelete();
        }
    }
}
