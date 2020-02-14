using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    /// <summary>
    /// 供应商提供品类相应价格
    /// </summary>
    public class SupplierCategoryPrice : BasePoco
    {
        [Display(Name = "预算分类")]
        [Required(ErrorMessage = "{0}是必填项")]
        public Guid? BudgetCategoryID { get; set; }
        public BudgetCategory BudgetCategory { get; set; }

        [Display(Name = "预算品类")]
        [Required(ErrorMessage = "{0}是必填项")]
        public Guid? BudgetSubCategoryID { get; set; }
        public BudgetSubCategory BudgetSubCategory { get; set; }

        [Display(Name = "供应商")]
        [Required(ErrorMessage = "{0}是必填项")]
        public Guid? SupplierID { get; set; }
        public Supplier Supplier { get; set; }

        [Display(Name = "合同编号")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ContractNo { get; set; }

        [Display(Name = "当前最低价/人工工时价/外包总价")]
        [Required(ErrorMessage = "{0}是必填项")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Display(Name = "价格有效截止日期")]
        [Required(ErrorMessage = "{0}是必填项")]
        public DateTime PriceEffectiveEndDate { get; set; }

        #region 机械预算分类下的字段
        [Display(Name = "品牌")]
        [StringLength(100, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Brand { get; set; }

        [Display(Name = "规格")]
        [StringLength(100, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Format { get; set; }

        [Display(Name = "采购类型")]
        public UseTypeEnum? UseType { get; set; }

        [Display(Name = "数量/工时")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal WorkNumber { get; set; }

        [Display(Name = "合同/市场价")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? MarketPrice { get; set; }

        [Display(Name = "价格清单")]
        public Guid? FileAttachmentID { get; set; }
        public FileAttachment FileAttachment { get; set; }
        #endregion

        #region 外包预算分类
        [Display(Name = "外包种类")]
        [StringLength(100, ErrorMessage = "{0}最多输入{1}个字符")]
        public string OutSourceType { get; set; }
        #endregion
    }
}
