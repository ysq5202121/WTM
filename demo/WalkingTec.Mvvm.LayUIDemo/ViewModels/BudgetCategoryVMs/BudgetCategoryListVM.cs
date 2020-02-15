using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.BudgetCategoryVMs
{
    public partial class BudgetCategoryListVM : BasePagedListVM<BudgetCategory_View, BudgetCategorySearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("BudgetCategory", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("BudgetCategory", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("BudgetCategory", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("BudgetCategory", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("BudgetCategory", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("BudgetCategory", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("BudgetCategory", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<BudgetCategory_View>> InitGridHeader()
        {
            return new List<GridColumn<BudgetCategory_View>>{
                this.MakeGridHeader(x => x.CategoryCode),
                this.MakeGridHeader(x => x.CategoryName),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<BudgetCategory_View> GetSearchQuery()
        {
            var query = DC.Set<BudgetCategory>()
                .CheckContain(Searcher.CategoryCode, x => x.CategoryCode)
                .CheckContain(Searcher.CategoryName, x => x.CategoryName)
                .Select(x => new BudgetCategory_View
                {
                    ID = x.ID,
                    CategoryCode = x.CategoryCode,
                    CategoryName = x.CategoryName,
                })
                .OrderBy(x => x.CategoryCode);
            return query;
        }

    }

    public class BudgetCategory_View : BudgetCategory
    {

    }
}
