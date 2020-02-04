using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    [Table("IdentitySeed")]
    public class IdentitySeed : BasePoco
    {
        [Display(Name = "模块名称")]
        [StringLength(200, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ModuleName { get; set; }

        [Display(Name = "动作名称")]
        [StringLength(200, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ActionName { get; set; }

        [Display(Name = "种子日期")]
        [StringLength(200, ErrorMessage = "{0}最多输入{1}个字符")]
        public string SeedDate { get; set; }

        [Display(Name = "种子数")]
        public int Seed { get; set; }
    }
}
