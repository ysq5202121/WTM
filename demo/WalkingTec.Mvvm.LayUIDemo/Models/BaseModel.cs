using System.ComponentModel.DataAnnotations;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    public class BaseModel
    {
    }

    /// <summary>
    /// 单据状态
    /// </summary>
    public enum OrderStatusEnum
    {
        [Display(Name = "未发货")]
        Draft = 0,
        [Display(Name = "已发货")]
        Progress = 1,
        [Display(Name = "已完结")]
        Complete = 2
    }

    /// <summary>
    /// 支付状态
    /// </summary>
    public enum PaymentStatusEnum
    {
        [Display(Name = "未付款")]
        UnPay = 0,
        [Display(Name = "已付款")]
        Paid = 1
    }

    /// <summary>
    /// 付款方式
    /// </summary>
    public enum PaymentTypeEnum
    {
        [Display(Name = "现金")]
        Cash = 0,
        [Display(Name = "微信")]
        WX = 1,
        [Display(Name = "支付宝")]
        ZFB = 2,
        [Display(Name = "信用卡")]
        CreditCard = 3,
        [Display(Name = "其他")]
        Other = 4
    }
}
