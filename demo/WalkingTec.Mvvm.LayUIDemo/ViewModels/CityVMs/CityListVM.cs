using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.CityVMs
{
    public partial class CityListVM : BasePagedListVM<City_View, CitySearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("City", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("City", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("City", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("City", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("City", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("City", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("City", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<City_View>> InitGridHeader()
        {
            return new List<GridColumn<City_View>>{
                this.MakeGridHeader(x => x.ProvinceName),
                this.MakeGridHeader(x => x.ProvinceCode),
                this.MakeGridHeader(x => x.CityName),
                this.MakeGridHeader(x => x.LocationPoint),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<City_View> GetSearchQuery()
        {
            var query = DC.Set<City>()
                .CheckEqual(Searcher.ProvinceID, x => x.ProvinceID)
                .CheckContain(Searcher.CityName, x => x.CityName)
                .Select(x => new City_View
                {
                    ID = x.ID,
                    ProvinceCode = x.Province.ProvinceCode,
                    ProvinceName = x.Province.ProvinceName,
                    CityName = x.CityName,
                    LocationPoint = x.LocationPoint,
                })
                .OrderBy(x => x.ProvinceCode)
                .ThenBy(x => x.CityName);
            return query;
        }

    }

    public class City_View : City
    {
        [Display(Name = "省份名称")]
        public String ProvinceName { get; set; }

        [Display(Name = "省份名称")]
        public String ProvinceCode { get; set; }
    }
}
