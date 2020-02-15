using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.CityVMs
{
    public partial class CitySearcher : BaseSearcher
    {
        [Display(Name = "省份名称")]
        public Guid? ProvinceID { get; set; }
        public List<ComboSelectListItem> AllProvinces { get; set; }

        [Display(Name = "城市名称")]
        public String CityName { get; set; }

        protected override void InitVM()
        {
            AllProvinces = DC.Set<Province>().OrderBy(x => x.ProvinceCode).Select(x => new ComboSelectListItem { Text = x.ProvinceName, Value = x.ID + "" }).ToList();
        }
    }
}
