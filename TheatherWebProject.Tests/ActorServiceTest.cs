using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TheatherWebProject.Core.Services;
using TheatherWebProject.Data;
using TheatherWebProject.Infrastructure.Data.Common;
using TheatherWebProject.Infrastructure.Data.Models;
using TheatherWebProject.Core.Models.Actors;

namespace TheatherWebProject.Tests
{
	public class ActorServiceTest
	{
		private IRepository _repository;
		private ActorService _actorService;
		private ApplicationDbContext _DbContext;
		private List<Actor> _actors;
		private List<Play> _plays;
		

		[SetUp]
		public async Task SetUp()
		{
			_plays = new List<Play>()
			{
				new Play
				{
					Id = 1,
					Title = "Play1",
					Description = "Description1",
					Genre = "Genre1",
					PlayImagesURLs = new List<string>(),
					Location = "Location1",
					Town = "Town1",
					DateAndTime = DateTime.Now,
					TicketURL = "TicketURL1",
					Comments = new List<Comment>(),
					
				},
				new Play
				{
					Id = 2,
					Title = "Play2",
					Description = "Description2",
					Genre = "Genre2",
					PlayImagesURLs = new List<string>(),
					Location = "Location2",
					Town = "Town2",
					DateAndTime = DateTime.Now,
					TicketURL = "TicketURL2",
					Comments = new List<Comment>(),
				}
			};
			_actors = new List<Actor>()
			{
				new Actor
				{
					Id = 1,
					FirstName = "John",
					LastName = "Doe",
					Description = "Actor",
					ActorImageURLs = new List<string>(),
					ActorsPlays = new List<ActorPlay>()
					{
						new ActorPlay
						{
							ActorId = 1,
							PlayId = 1
						},
						new ActorPlay
						{
							ActorId = 1,
							PlayId = 2
						}
					}
				}
			};
			var options = new DbContextOptionsBuilder<ApplicationDbContext>()
				.UseInMemoryDatabase(databaseName: "AppDatabase" + Guid.NewGuid().ToString())
				.Options;

			_DbContext = new ApplicationDbContext(options);
			await _DbContext.AddRangeAsync(_actors);
			await _DbContext.AddRangeAsync(_plays);
			await _DbContext.SaveChangesAsync();

			_repository = new Repository(_DbContext);
			_actorService = new ActorService(_repository);


		}
		[TearDown]
		public async Task TearDown()
		{
			await _DbContext.Database.EnsureDeletedAsync();
			await _DbContext.DisposeAsync();
		}
		[Test]
		public async Task CreateAsync_WithValidData_ShouldCreateActor()
		{
			var actorFormModel = new ActorFormModel
			{
				FirstName = "Jane",
				LastName = "Doe",
				Description = "Actress",
				ActorImageUrls = new List<string>() { "C:\\Users\\ddimi\\source\\repos\\TheatherWebProject\\TheatherWebProject\\wwwroot\\Images\\153265986_2893861524220139_5094173891309400300_n.jpg" }
			};

			var result = await _actorService.CreateAsync(actorFormModel);

			Assert.That(result, Is.EqualTo(2));
		}
		[Test]
		public async Task DeleteAsync_WithValidData_ShouldDeleteActor()
		{
			await _actorService.DeleteAsync(1);

			Assert.That(await _repository.AllAsReadOnly<Actor>().CountAsync(), Is.EqualTo(0));
		}
		[Test]
		public async Task EditAsync_WithValidData_ShouldEditActor()
		{
			var actorFormModel = new ActorFormModel
			{
				FirstName = "Jane",
				LastName = "Doe",
				Description = "Actress",
				ActorImageUrls = new List<string>() { "C:\\Users\\ddimi\\source\\repos\\TheatherWebProject\\TheatherWebProject\\wwwroot\\Images\\153265986_2893861524220139_5094173891309400300_n.jpg" }
			};

			await _actorService.EditAsync(1, actorFormModel);

			var actor = await _repository.AllAsReadOnly<Actor>().FirstOrDefaultAsync();

			Assert.That(actor.FirstName, Is.EqualTo("Jane"));
			Assert.That(actor.LastName, Is.EqualTo("Doe"));
			Assert.That(actor.Description, Is.EqualTo("Actress"));
			Assert.That(actor.ActorImageURLs, Is.EqualTo(actorFormModel.ActorImageUrls));
		}
		[Test]
		public async Task ExistsByIdAsync_WithValidData_ShouldReturnTrue()
		{
			var result = await _actorService.ExistsByIdAsync(1);

			Assert.That(result, Is.True);
		}
		[Test]
		public async Task GetDetailsByIdAsync_WithValidData_ShouldReturnActor()
		{
			var result = await _actorService.GetDetailsByIdAsync(1);

			Assert.That(result.Id, Is.EqualTo(1));
			Assert.That(result.FirstName, Is.EqualTo("John"));
			Assert.That(result.LastName, Is.EqualTo("Doe"));
			Assert.That(result.Description, Is.EqualTo("Actor"));
			Assert.That(result.ActorImageUrls, Is.EqualTo(new List<string>()));
			Assert.That(result.actingIn.Count(), Is.EqualTo(2));
		}
		[Test]
		public async Task GetAllAsync_WithValidData_ShouldReturnAllActors()
		{
			var result = await _actorService.GetAllAsync();

			Assert.That(result.Count(), Is.EqualTo(1));
		}
		[Test]
		public async Task GetAllAsync_WithValidData_ShouldReturnAllActorsWithCorrectData()
		{
			var result = await _actorService.GetAllAsync();

			Assert.That(result.First().Id, Is.EqualTo(1));
			Assert.That(result.First().FirstName, Is.EqualTo("John"));
			Assert.That(result.First().LastName, Is.EqualTo("Doe"));
			Assert.That(result.First().Description, Is.EqualTo("Actor"));
			Assert.That(result.First().ActorImageUrl, Is.EqualTo(""));
		}
		//Now for when Inputs are InValid
		[Test]
		public async Task DeleteAsync_WithInValidData_ShouldThrowException()
		{
			await _actorService.DeleteAsync(2);

			Assert.That(_repository.AllAsReadOnly<Actor>().Count(), Is.EqualTo(1));
		}
		[Test]
		public void EditAsync_WithInValidData_ShouldThrowException()
		{
			var actorFormModel = new ActorFormModel
			{
				FirstName = "Jane",
				LastName = "Doe",
				Description = "Actress",
				ActorImageUrls = new List<string>() { "C:\\Users\\ddimi\\source\\repos\\TheatherWebProject\\TheatherWebProject\\wwwroot\\Images\\153265986_2893861524220139_5094173891309400300_n.jpg" }
			};

			Assert.ThrowsAsync<InvalidOperationException>(() => _actorService.EditAsync(2, actorFormModel));

		}
		[Test]
		public async Task ExistsByIdAsync_WithInValidData_ShouldReturnFalse()
		{
			var result = await _actorService.ExistsByIdAsync(2);

			Assert.That(result, Is.False);
		}
		[Test]
		public async Task GetDetailsByIdAsync_WithInValidData_ShouldThrowExpectioNInvalidOperation()
		{
			
			Assert.ThrowsAsync<InvalidOperationException>(() => _actorService.GetDetailsByIdAsync(2));
		}
		[Test]
		public async Task GetAllAsync_WithInValidData_ShouldReturnEmptyList()
		{
			await _actorService.DeleteAsync(1);

			var result = await _actorService.GetAllAsync();

			Assert.That(result.Count(), Is.EqualTo(0));
		}
		

		
	}
	
}
