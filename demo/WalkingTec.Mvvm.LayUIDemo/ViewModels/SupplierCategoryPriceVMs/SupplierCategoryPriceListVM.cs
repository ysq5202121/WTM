using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.SupplierCategoryPriceVMs
{
    public partial class SupplierCategoryPriceListVM : BasePagedListVM<SupplierCategoryPrice_View, SupplierCategoryPriceSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("SupplierCategoryPrice", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("SupplierCategoryPrice", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("SupplierCategoryPrice", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("SupplierCategoryPrice", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("SupplierCategoryPrice", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("SupplierCategoryPrice", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("SupplierCategoryPrice", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("SupplierCategoryPrice", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<SupplierCategoryPrice_View>> InitGridHeader()
        {
            return new List<GridColumn<SupplierCategoryPrice_View>>{
                this.MakeGridHeader(x => x.CategoryName_view),
                this.MakeGridHeader(x => x.SubCategoryName_view),
                this.MakeGridHeader(x => x.SupplierName_view),
                this.MakeGridHeader(x => x.ContractNo),
                this.MakeGridHeader(x => x.Price),
                this.MakeGridHeader(x => x.PriceEffectiveEndDate),
                this.MakeGridHeader(x => x.Brand),
                this.MakeGridHeader(x => x.Format),
                this.MakeGridHeader(x => x.UseType),
                this.MakeGridHeader(x => x.WorkNumber),
                this.MakeGridHeader(x => x.MarketPrice),
                this.MakeGridHeader(x => x.FileAttachmentID).SetFormat(FileAttachmentIDFormat),
                this.MakeGridHeader(x => x.OutSourceType),
                this.MakeGridHeaderAction(width: 200)
            };
        }
        private List<ColumnFormatInfo> FileAttachmentIDFormat(SupplierCategoryPrice_View entity, object val)
        {
            return new List<ColumnFormatInfo>
            {
                ColumnFormatInfo.MakeDownloadButton(ButtonTypesEnum.Button,entity.FileAttachmentID),
                ColumnFormatInfo.MakeViewButton(ButtonTypesEnum.Button,entity.FileAttachmentID,640,480),
            };
        }


        public override IOrderedQueryable<SupplierCategoryPrice_View> GetSearchQuery()
        {
            var query = DC.Set<SupplierCategoryPrice>()
                .CheckEqual(Searcher.BudgetCategoryID, x=>x.BudgetCategoryID)
                .CheckEqual(Searcher.BudgetSubCategoryID, x=>x.BudgetSubCategoryID)
                .CheckEqual(Searcher.SupplierID, x=>x.SupplierID)
                .Select(x => new SupplierCategoryPrice_View
                {
				    ID = x.ID,
                    CategoryName_view = x.BudgetCategory.CategoryName,
                    SubCategoryName_view = x.BudgetSubCategory.SubCategoryName,
                    SupplierName_view = x.Supplier.SupplierName,
                    ContractNo = x.ContractNo,
                    Price = x.Price,
                    PriceEffectiveEndDate = x.PriceEffectiveEndDate,
                    Brand = x.Brand,
                    Format = x.Format,
                    UseType = x.UseType,
                    WorkNumber = x.WorkNumber,
                    MarketPrice = x.MarketPrice,
                    FileAttachmentID = x.FileAttachmentID,
                    OutSourceType = x.OutSourceType,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class SupplierCategoryPrice_View : SupplierCategoryPrice{
        [Display(Name = "预算类别名称")]
        public String CategoryName_view { get; set; }
        [Display(Name = "品类名称")]
        public String SubCategoryName_view { get; set; }
        [Display(Name = "供应商名称")]
        public String SupplierName_view { get; set; }

    }
}
