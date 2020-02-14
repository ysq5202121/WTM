using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.SupplierVMs
{
    public partial class SupplierListVM : BasePagedListVM<Supplier_View, SupplierSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<Supplier_View>> InitGridHeader()
        {
            return new List<GridColumn<Supplier_View>>{
                this.MakeGridHeader(x => x.SupplierName),
                this.MakeGridHeader(x => x.SupplierAddress),
                this.MakeGridHeader(x => x.SupplierContact),
                this.MakeGridHeader(x => x.SupplierPhone),
                this.MakeGridHeader(x => x.SupplierTelephone),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Supplier_View> GetSearchQuery()
        {
            var query = DC.Set<Supplier>()
                .CheckContain(Searcher.SupplierName, x=>x.SupplierName)
                .Select(x => new Supplier_View
                {
				    ID = x.ID,
                    SupplierName = x.SupplierName,
                    SupplierAddress = x.SupplierAddress,
                    SupplierContact = x.SupplierContact,
                    SupplierPhone = x.SupplierPhone,
                    SupplierTelephone = x.SupplierTelephone,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Supplier_View : Supplier{

    }
}
