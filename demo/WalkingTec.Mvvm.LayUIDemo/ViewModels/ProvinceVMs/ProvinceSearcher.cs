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
    public partial class ProvinceSearcher : BaseSearcher
    {
        [Display(Name = "省份名称")]
        public String ProvinceName { get; set; }
        [Display(Name = "省份编号")]
        public String ProvinceCode { get; set; }

        protected override void InitVM()
        {
        }

    }
}
