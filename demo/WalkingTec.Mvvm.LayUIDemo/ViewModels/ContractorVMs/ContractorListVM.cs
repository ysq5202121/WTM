using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.ContractorVMs
{
    public partial class ContractorListVM : BasePagedListVM<Contractor_View, ContractorSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Contractor", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Contractor", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Contractor", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Contractor", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Contractor", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("Contractor", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Contractor", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("Contractor", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<Contractor_View>> InitGridHeader()
        {
            return new List<GridColumn<Contractor_View>>{
                this.MakeGridHeader(x => x.ProvinceName_view),
                this.MakeGridHeader(x => x.ContractorName),
                this.MakeGridHeader(x => x.ContractorAddress),
                this.MakeGridHeader(x => x.ContractorContact),
                this.MakeGridHeader(x => x.ZipCode),
                this.MakeGridHeader(x => x.Email),
                this.MakeGridHeader(x => x.ContractorPhone),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Contractor_View> GetSearchQuery()
        {
            var query = DC.Set<Contractor>()
                .CheckEqual(Searcher.ProvinceID, x=>x.ProvinceID)
                .CheckContain(Searcher.ContractorName, x=>x.ContractorName)
                .Select(x => new Contractor_View
                {
				    ID = x.ID,
                    ProvinceName_view = x.Province.ProvinceName,
                    ContractorName = x.ContractorName,
                    ContractorAddress = x.ContractorAddress,
                    ContractorContact = x.ContractorContact,
                    ZipCode = x.ZipCode,
                    Email = x.Email,
                    ContractorPhone = x.ContractorPhone,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Contractor_View : Contractor{
        [Display(Name = "省份名称")]
        public String ProvinceName_view { get; set; }

    }
}
