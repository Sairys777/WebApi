﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DataAccessLayer;
using WebApi.DataAccessLayer.Entities;

namespace WebApi.Controllers
{
	[ApiController]
	[Route("test-entities")]
	public class TestEntityController : ControllerBase
	{
		private AppDbContext _dbContext;

		public TestEntityController(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpPost("create-random-new")]
		public TestEntity CreateRandomNew()
		{
			var @new = new TestEntity
			{
				Descrpition = $"Test Description {DateTime.Now}",
			};

			_dbContext.TestEntities.Add(@new);
			_dbContext.SaveChanges();

			return @new;
		}

		[HttpPost("get-all")]
		public TestEntity[] GetAll()
		{
			return _dbContext.TestEntities.ToArray();
		}
	}
}
