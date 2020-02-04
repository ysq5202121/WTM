using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    [Table("OrderDetail")]
    public class OrderDetail : BasePoco
    {
        [Display(Name = "订单信息")]
        public Guid? OrderInfoID { get; set; }
        public OrderInfo OrderInfo { get; set; }

        [Display(Name = "商品ID")]
        public Guid? ProductID { get; set; }

        [Display(Name = "商品名称")]
        public string ProductName { get; set; }

        [Display(Name = "商品编号")]
        public int ProductNo { get; set; }

        [Display(Name = "商品品牌")]
        public string ProductBrand { get; set; }

        [Display(Name = "商品规格")]
        public string ProductFormat { get; set; }

        [Display(Name = "商品单位")]
        public string ProductUnit { get; set; }

        [Display(Name = "卖出价格")]
        public decimal SellPrice { get; set; }

        [Display(Name = "卖出数量")]
        public decimal ProductNumber { get; set; }

        [Display(Name = "商品总金额")]
        public decimal ProductTotalAmount { get; set; }
    }
}
