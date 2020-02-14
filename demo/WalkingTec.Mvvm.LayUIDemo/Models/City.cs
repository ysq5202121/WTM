using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    public class City : BasePoco
    {
        [Display(Name = "省份")]
        public Guid? ProvinceID { get; set; }
        public Province Province { get; set; }

        [Display(Name = "城市名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string CityName { get; set; }

        [Display(Name = "城市坐标")]
        public string LocationPoint { get; set; }

        public List<Project> Projects { get; set; }
    }
}
