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
    public partial class SupplierSearcher : BaseSearcher
    {
        [Display(Name = "供应商名称")]
        public String SupplierName { get; set; }

        protected override void InitVM()
        {
        }

    }
}
