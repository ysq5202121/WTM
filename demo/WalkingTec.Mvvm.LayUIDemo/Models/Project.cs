using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace WalkingTec.Mvvm.LayUIDemo.Models
{
    /// <summary>
    /// 项目表
    /// </summary>
    public class Project : BasePoco
    {
        [Display(Name = "项目编号")]
        public string ProjectNo { get; set; }

        [Display(Name = "项目名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ProjectName { get; set; }

        [Display(Name = "省份")]
        [Required(ErrorMessage = "{0}是必填项")]
        public Guid? ProvinceID { get; set; }
        public Province Province { get; set; }

        [Display(Name = "城市")]
        [Required(ErrorMessage = "{0}是必填项")]
        public Guid? CityID { get; set; }
        public City City { get; set; }

        [Display(Name = "甲方")]
        [Required(ErrorMessage = "{0}是必填项")]
        public Guid? ContractorAID { get; set; }
        public Contractor ContractorA { get; set; }

        [Display(Name = "乙方")]
        public Guid? ContractorBID { get; set; }
        public Contractor ContractorB { get; set; }

        [Display(Name = "合同简介")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string ContractIntroduction { get; set; }

        [Display(Name = "合同文档")]
        [Required(ErrorMessage = "{0}是必填项")]
        public Guid? ContractDocumentID { get; set; }
        public FileAttachment ContractDocument { get; set; }

        [Display(Name = "合同签订日期")]
        [Required(ErrorMessage = "{0}是必填项")]
        public DateTime ContractSignDate { get; set; }

        [Display(Name = "合同结束日期")]
        [Required(ErrorMessage = "{0}是必填项")]
        public DateTime ContractEndDate { get; set; }

        [Display(Name = "合同总金额")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ContractAmount { get; set; }

        [Display(Name = "质押金")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal CashPledge { get; set; }

        [Display(Name = "固定预算额")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SpecifiedBudgeAmount { get; set; }

        [Display(Name = "概率预算额")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal EstimateBudgeAmount { get; set; }

        [Display(Name = "项目状态")]
        public ProjectStatusEnum Status { get; set; }
    }
}
