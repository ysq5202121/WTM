using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.SupplierCategoryPriceVMs
{
    public partial class SupplierCategoryPriceTemplateVM : BaseTemplateVM
    {
        public ExcelPropety BudgetCategory_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.BudgetCategoryID);
        public ExcelPropety BudgetSubCategory_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.BudgetSubCategoryID);
        public ExcelPropety Supplier_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.SupplierID);
        [Display(Name = "合同编号")]
        public ExcelPropety ContractNo_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.ContractNo);
        [Display(Name = "当前最低价/人工工时价/外包总价")]
        public ExcelPropety Price_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.Price);
        [Display(Name = "价格有效截止日期")]
        public ExcelPropety PriceEffectiveEndDate_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.PriceEffectiveEndDate);
        [Display(Name = "品牌")]
        public ExcelPropety Brand_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.Brand);
        [Display(Name = "规格")]
        public ExcelPropety Format_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.Format);
        [Display(Name = "采购类型")]
        public ExcelPropety UseType_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.UseType);
        [Display(Name = "数量/工时")]
        public ExcelPropety WorkNumber_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.WorkNumber);
        [Display(Name = "合同/市场价")]
        public ExcelPropety MarketPrice_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.MarketPrice);
        [Display(Name = "外包种类")]
        public ExcelPropety OutSourceType_Excel = ExcelPropety.CreateProperty<SupplierCategoryPrice>(x => x.OutSourceType);

	    protected override void InitVM()
        {
            BudgetCategory_Excel.DataType = ColumnDataType.ComboBox;
            BudgetCategory_Excel.ListItems = DC.Set<BudgetCategory>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.CategoryName);
            BudgetSubCategory_Excel.DataType = ColumnDataType.ComboBox;
            BudgetSubCategory_Excel.ListItems = DC.Set<BudgetSubCategory>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.SubCategoryName);
            Supplier_Excel.DataType = ColumnDataType.ComboBox;
            Supplier_Excel.ListItems = DC.Set<Supplier>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.SupplierName);
        }

    }

    public class SupplierCategoryPriceImportVM : BaseImportVM<SupplierCategoryPriceTemplateVM, SupplierCategoryPrice>
    {

    }

}
