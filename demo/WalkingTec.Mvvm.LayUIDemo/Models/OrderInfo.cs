using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    [Table("OrderInfo")]
    public class OrderInfo : BasePoco
    {
        [Display(Name = "订单编号")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string OrderNo { get; set; }

        [Display(Name = "客户ID")]
        public Guid? CustomerInfoID { get; set; }
        public CustomerInfo CustomerInfo { get; set; }

        [Display(Name = "商品总个数")]
        public decimal TotalNumber { get; set; }

        [Display(Name = "订单总金额")]
        public decimal TotalAmount { get; set; }

        [Display(Name = "订单状态")]
        public OrderStatusEnum OrderStatus { get; set; }

        [Display(Name = "付款状态")]
        public PaymentStatusEnum PaymentStatus { get; set; }

        [Display(Name = "付款方式")]
        public PaymentTypeEnum? PaymentType { get; set; }

        [Display(Name = "订单备注")]
        public string Remark { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
