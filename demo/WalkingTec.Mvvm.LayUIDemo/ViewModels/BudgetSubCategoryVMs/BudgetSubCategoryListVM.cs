using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.BudgetSubCategoryVMs
{
    public partial class BudgetSubCategoryListVM : BasePagedListVM<BudgetSubCategory_View, BudgetSubCategorySearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("BudgetSubCategory", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("BudgetSubCategory", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("BudgetSubCategory", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("BudgetSubCategory", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("BudgetSubCategory", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("BudgetSubCategory", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("BudgetSubCategory", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<BudgetSubCategory_View>> InitGridHeader()
        {
            return new List<GridColumn<BudgetSubCategory_View>>{
                this.MakeGridHeader(x => x.CategoryName),
                this.MakeGridHeader(x => x.SubCategoryName),
                this.MakeGridHeader(x => x.Unit),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<BudgetSubCategory_View> GetSearchQuery()
        {
            var query = DC.Set<BudgetSubCategory>()
                .CheckEqual(Searcher.BudgetCategoryID, x => x.BudgetCategoryID)
                .CheckContain(Searcher.SubCategoryName, x => x.SubCategoryName)
                .Select(x => new BudgetSubCategory_View
                {
                    ID = x.ID,
                    CategoryName = x.BudgetCategory.CategoryName,
                    SubCategoryName = x.SubCategoryName,
                    Unit = x.Unit,
                })
                .OrderBy(x => x.CategoryName)
                .ThenBy(x => x.SubCategoryName);
            return query;
        }

    }

    public class BudgetSubCategory_View : BudgetSubCategory
    {
        [Display(Name = "预算类别名称")]
        public String CategoryName { get; set; }
    }
}
