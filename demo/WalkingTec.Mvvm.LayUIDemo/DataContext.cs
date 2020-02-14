using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.LayUIDemo.Models;

namespace WalkingTec.Mvvm.LayUIDemo
{
    public class DataContext : FrameworkContext
    {
        public DataContext(CS cs) : base(cs)
        {
        }

        public DataContext(string cs, DBTypeEnum dbtype)
             : base(cs, dbtype)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //如果自增列不是主键，需要设置此属性
            //modelBuilder.Entity<CustomerInfo>().HasAlternateKey(x => x.CustomerNo);
        }

        public override async Task<bool> DataInit(object allModules, bool IsSpa)
        {
            var State = await base.DataInit(allModules, IsSpa);
            try
            {
                if (State)
                {
                    IDataContext DC = this as DataContext;
                    string fullPath = AppDomain.CurrentDomain.BaseDirectory + "Procedures";
                    if (Directory.Exists(fullPath))
                    {
                        List<string> fileList = null;
                        fileList = Utils.GetAllFilePathRecursion(fullPath, fileList);
                        string sql = string.Empty;
                        foreach (var file in fileList)
                        {
                            if (file.ToLower().EndsWith(".sql"))
                            {
                                sql = Utils.ReadTxt(file);
                                try
                                {
                                    DC.Database.ExecuteSqlCommand(sql);
                                }
                                catch (Exception)
                                {
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return State;
        }

        /// <summary>
        /// 种子表
        /// </summary>
        public DbSet<IdentitySeed> IdentitySeeds { get; set; }

        /// <summary>
        /// 省份表
        /// </summary>
        public DbSet<Province> Provinces { get; set; }

        /// <summary>
        /// 城市表
        /// </summary>
        public DbSet<City> Cities { get; set; }

        /// <summary>
        /// 预算分类表
        /// </summary>
        public DbSet<BudgetCategory> BudgetCategories { get; set; }

        /// <summary>
        /// 预算品类表
        /// </summary>
        public DbSet<BudgetSubCategory> BudgetSubCategories { get; set; }

        /// <summary>
        /// 承建商
        /// </summary>
        public DbSet<Contractor> Contractors { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public DbSet<Supplier> Suppliers { get; set; }

        /// <summary>
        /// 供应商品类价格表
        /// </summary>
        public DbSet<SupplierCategoryPrice> SupplierCategoryPrices { get; set; }

        /// <summary>
        /// 项目表
        /// </summary>
        public DbSet<Project> Projects { get; set; }
    }

    /// <summary>
    /// 为EF的Migration准备的辅助类，填写完整连接字符串和数据库类型
    /// 就可以使用Add-Migration和Update-Database了
    /// </summary>
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            return new DataContext("你的完整连接字符串", DBTypeEnum.SqlServer);
        }
    }

}
