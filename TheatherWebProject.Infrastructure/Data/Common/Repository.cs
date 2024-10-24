﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatherWebProject.Data;

namespace TheatherWebProject.Infrastructure.Data.Common
{
	public class Repository : IRepository
	{
		private readonly DbContext context;

		public Repository(ApplicationDbContext _context)
		{
			context = _context;
		}

		public IQueryable<T> All<T>() where T : class
		{
			return DbSet<T>();
		}

		public IQueryable<T> AllAsReadOnly<T>() where T : class
		{
			return DbSet<T>()
				.AsNoTracking();
		}
		public async Task AddAsync<T>(T entity) where T : class
		{
			await DbSet<T>().AddAsync(entity);
		}
		public async Task<int> SaveChangesAsync()
		{
			return await context.SaveChangesAsync();
		}

		private DbSet<T> DbSet<T>() where T : class
		{
			return context.Set<T>();
		}

		public async Task<T?> GetByIdAsync<T>(object id) where T : class
		{
			return await DbSet<T>().FindAsync(id);
		}

		public async Task DeleteAsync<T>(object id) where T : class
		{
			T? entity = await GetByIdAsync<T>(id);

			if (entity != null)
			{
				DbSet<T>().Remove(entity);
			}
		}
	}
}
