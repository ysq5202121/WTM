using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.ProjectVMs
{
    public partial class ProjectListVM : BasePagedListVM<Project_View, ProjectSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Project", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Project", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Project", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Project", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Project", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("Project", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Project", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("Project", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<Project_View>> InitGridHeader()
        {
            return new List<GridColumn<Project_View>>{
                this.MakeGridHeader(x => x.ProjectNo),
                this.MakeGridHeader(x => x.ProjectName),
                this.MakeGridHeader(x => x.ProvinceName_view),
                this.MakeGridHeader(x => x.CityName_view),
                this.MakeGridHeader(x => x.ContractorName_view),
                this.MakeGridHeader(x => x.ContractorName_view2),
                this.MakeGridHeader(x => x.ContractIntroduction),
                this.MakeGridHeader(x => x.ContractDocumentID).SetFormat(ContractDocumentIDFormat),
                this.MakeGridHeader(x => x.ContractSignDate),
                this.MakeGridHeader(x => x.ContractEndDate),
                this.MakeGridHeader(x => x.ContractAmount),
                this.MakeGridHeader(x => x.CashPledge),
                this.MakeGridHeader(x => x.SpecifiedBudgeAmount),
                this.MakeGridHeader(x => x.EstimateBudgeAmount),
                this.MakeGridHeader(x => x.Status),
                this.MakeGridHeaderAction(width: 200)
            };
        }
        private List<ColumnFormatInfo> ContractDocumentIDFormat(Project_View entity, object val)
        {
            return new List<ColumnFormatInfo>
            {
                ColumnFormatInfo.MakeDownloadButton(ButtonTypesEnum.Button,entity.ContractDocumentID),
                ColumnFormatInfo.MakeViewButton(ButtonTypesEnum.Button,entity.ContractDocumentID,640,480),
            };
        }


        public override IOrderedQueryable<Project_View> GetSearchQuery()
        {
            var query = DC.Set<Project>()
                .CheckContain(Searcher.ProjectNo, x=>x.ProjectNo)
                .CheckContain(Searcher.ProjectName, x=>x.ProjectName)
                .CheckEqual(Searcher.ProvinceID, x=>x.ProvinceID)
                .CheckEqual(Searcher.CityID, x=>x.CityID)
                .CheckEqual(Searcher.ContractorAID, x=>x.ContractorAID)
                .CheckEqual(Searcher.ContractorBID, x=>x.ContractorBID)
                .CheckEqual(Searcher.ContractSignDate, x=>x.ContractSignDate)
                .CheckEqual(Searcher.ContractEndDate, x=>x.ContractEndDate)
                .CheckEqual(Searcher.Status, x=>x.Status)
                .Select(x => new Project_View
                {
				    ID = x.ID,
                    ProjectNo = x.ProjectNo,
                    ProjectName = x.ProjectName,
                    ProvinceName_view = x.Province.ProvinceName,
                    CityName_view = x.City.CityName,
                    ContractorName_view = x.ContractorA.ContractorName,
                    ContractorName_view2 = x.ContractorB.ContractorName,
                    ContractIntroduction = x.ContractIntroduction,
                    ContractDocumentID = x.ContractDocumentID,
                    ContractSignDate = x.ContractSignDate,
                    ContractEndDate = x.ContractEndDate,
                    ContractAmount = x.ContractAmount,
                    CashPledge = x.CashPledge,
                    SpecifiedBudgeAmount = x.SpecifiedBudgeAmount,
                    EstimateBudgeAmount = x.EstimateBudgeAmount,
                    Status = x.Status,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Project_View : Project{
        [Display(Name = "省份名称")]
        public String ProvinceName_view { get; set; }
        [Display(Name = "城市名称")]
        public String CityName_view { get; set; }
        [Display(Name = "公司名称")]
        public String ContractorName_view { get; set; }
        [Display(Name = "公司名称")]
        public String ContractorName_view2 { get; set; }

    }
}
