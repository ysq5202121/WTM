using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.ProvinceVMs
{
    public partial class ProvinceListVM : BasePagedListVM<Province_View, ProvinceSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Province", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Province", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Province", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Province", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Province", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Province", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("Province", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<Province_View>> InitGridHeader()
        {
            return new List<GridColumn<Province_View>>{
                this.MakeGridHeader(x => x.ProvinceName),
                this.MakeGridHeader(x => x.ProvinceCode),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Province_View> GetSearchQuery()
        {
            var query = DC.Set<Province>()
                .CheckContain(Searcher.ProvinceName, x => x.ProvinceName)
                .CheckContain(Searcher.ProvinceCode, x => x.ProvinceCode)
                .Select(x => new Province_View
                {
                    ID = x.ID,
                    ProvinceName = x.ProvinceName,
                    ProvinceCode = x.ProvinceCode,
                })
                .OrderBy(x => x.ProvinceCode);
            return query;
        }

    }

    public class Province_View : Province
    {

    }
}
