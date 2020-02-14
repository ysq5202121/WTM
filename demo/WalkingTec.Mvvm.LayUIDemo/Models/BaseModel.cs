using System.ComponentModel.DataAnnotations;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    public class BaseModel
    {
    }

    /// <summary>
    /// 预算分类材料下的类型
    /// </summary>
    public enum UseTypeEnum
    {
        [Display(Name = "采购(台)")]
        Buy = 0,
        [Display(Name = "租赁(小时)")]
        Rent = 1
    }

    /// <summary>
    /// 项目状态枚举
    /// </summary>
    public enum ProjectStatusEnum
    {
        [Display(Name = "新建")]
        Draft = 0,
        [Display(Name = "预算提交")]
        BudgetSubmit = 1,
        [Display(Name = "预算驳回")]
        RejectSubmit = 2,
        [Display(Name = "预算锁定")]
        BudgetLock = 3,
        [Display(Name = "作废")]
        Invalid = 4
    }
}
