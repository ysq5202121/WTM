using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    public class Province : BasePoco
    {
        [Display(Name = "省份名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ProvinceName { get; set; }

        [Display(Name = "省份编号")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(3, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ProvinceCode { get; set; }


        public List<City> Cities { get; set; }
        public List<Contractor> Contractors { get; set; }
        public List<Project> Projects { get; set; }
    }
}
