using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.ProjectVMs
{
    public partial class ProjectBatchVM : BaseBatchVM<Project, Project_BatchEdit>
    {
        public ProjectBatchVM()
        {
            ListVM = new ProjectListVM();
            LinkedVM = new Project_BatchEdit();
        }

    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class Project_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
