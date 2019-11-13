﻿
//------------------------------------------------------------------------------
// <auto-generated>
// 此文件由T4模板生成，请勿手动修改
// by hoho
// 11/13/2019 15:49:34
// </auto-generated>
//------------------------------------------------------------------------------

using Hos.ScheduleMaster.Core.Models;
using Hos.ScheduleMaster.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Hos.ScheduleMaster.Core.EntityFramework;

namespace Hos.ScheduleMaster.Core.Models
{
	[ServiceMapTo(typeof(IUnitOfWork))]
    public class TaskDbContext : DbContext, IUnitOfWork
    {
		public TaskDbContext(DbContextOptions<TaskDbContext> option) : base(option)
        {
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            base.OnModelCreating(modelBuilder);		
			//初始化数据
            modelBuilder.SeedData();
		}
			public virtual DbSet<ServerNodeEntity> ServerNodes { get; set; }

		public virtual DbSet<SystemConfigEntity> SystemConfigs { get; set; }

		public virtual DbSet<SystemLogEntity> SystemLogs { get; set; }

		public virtual DbSet<SystemUserEntity> SystemUsers { get; set; }

		public virtual DbSet<TaskEntity> Tasks { get; set; }

		public virtual DbSet<TaskGuardianEntity> TaskGuardians { get; set; }

		public virtual DbSet<TaskLockEntity> TaskLocks { get; set; }

		public virtual DbSet<TaskReferenceEntity> TaskReferences { get; set; }

		public virtual DbSet<TaskRunTraceEntity> TaskRunTraces { get; set; }

	
		public int Commit()
        {
            return base.SaveChanges();
        }

        public async System.Threading.Tasks.Task<int> CommitAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}