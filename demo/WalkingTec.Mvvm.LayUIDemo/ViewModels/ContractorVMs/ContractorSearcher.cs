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
    public partial class ContractorSearcher : BaseSearcher
    {
        public List<ComboSelectListItem> AllProvinces { get; set; }
        public Guid? ProvinceID { get; set; }
        [Display(Name = "公司名称")]
        public String ContractorName { get; set; }

        protected override void InitVM()
        {
            AllProvinces = DC.Set<Province>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ProvinceName);
        }

    }
}
