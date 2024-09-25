using Microsoft.EntityFrameworkCore;
using TheatherWebProject.Core.Models.Plays;
using TheatherWebProject.Core.Services;
using TheatherWebProject.Data;
using TheatherWebProject.Infrastructure.Data.Common;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Tests
{
	public class PlayServiceTest
	{
		private IRepository _repository;
		private PlayService _playService;
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
			_playService = new PlayService(_repository);

		}
		[TearDown]
		public async Task TearDown()
		{
			await _DbContext.Database.EnsureDeletedAsync();
			await _DbContext.DisposeAsync();
		}
		[Test]
		public async Task GetAllPLaysByActorAsync_WithValidData_ShouldReturnCorrectResult()
		{
			var result = await _playService.GetAllPLaysByActorAsync(1);
			Assert.That(result.Count(), Is.EqualTo(2));
		}
		[Test]
		public async Task GetByIdAsyncShould_WithValidData_ReturnCorrectResult()
		{
			var result = await _playService.GetByIdAsync(1);
			Assert.That(result.Id, Is.EqualTo(1));
			Assert.That(result.Title, Is.EqualTo("Play1"));
			Assert.That(result.Description, Is.EqualTo("Description1"));
			Assert.That(result.Genre, Is.EqualTo("Genre1"));
			Assert.That(result.Location, Is.EqualTo("Location1"));
			Assert.That(result.Town, Is.EqualTo("Town1"));
			Assert.That(result.TicketURL, Is.EqualTo("TicketURL1"));
			Assert.That(result.Comments.Count, Is.EqualTo(0));
			Assert.That(result.ActorsPlays.Count, Is.EqualTo(1));
		}
		[Test]
		public async Task GetByIdAsyncShould_WithInvalidData_ThrowException()
		{
			Assert.ThrowsAsync<InvalidOperationException>(async () => await _playService.GetByIdAsync(3));
		}
		[Test]
		public async Task ExistsById_WithValidData_ShouldReturnTrue()
		{
			var result = await _playService.ExistsById(1);
			Assert.That(result, Is.True);
		}
		[Test]
		public async Task ExistsById_WithInvalidData_ShouldReturnFalse()
		{
			var result = await _playService.ExistsById(3);
			Assert.That(result, Is.False);
		}
		[Test]
		public async Task EditAsync_WithValidData_ShouldUpdatePlay()
		{
			var model = new PlayFormModel
			{
				Title = "Play1",
				Genre = "Genre1",
				Description = "Description1",
				Location = "Location1",
				DateAndTime = DateTime.Now,
				TicketURL = "TicketURL1",
				Town = "Town1",
				ImagesURLs = new List<string>(),
				VideosURLs = new List<string>(),
				ActorsIds = new List<int> { 1 }
			};
			await _playService.EditAsync(1, model);
			var result = await _playService.GetByIdAsync(1);
			Assert.That(result.Title, Is.EqualTo("Play1"));
			Assert.That(result.Genre, Is.EqualTo("Genre1"));
			Assert.That(result.Description, Is.EqualTo("Description1"));
			Assert.That(result.Location, Is.EqualTo("Location1"));
			Assert.That(result.Town, Is.EqualTo("Town1"));
			Assert.That(result.TicketURL, Is.EqualTo("TicketURL1"));
			Assert.That(result.ActorsPlays.Count, Is.EqualTo(1));
		}
		[Test]
		public async Task EditAsync_WithInvalidData_ShouldThrowException()
		{
			var model = new PlayFormModel
			{
				Title = "Play1",
				Genre = "Genre1",
				Description = "Description1",
				Location = "Location1",
				DateAndTime = DateTime.Now,
				TicketURL = "TicketURL1",
				Town = "Town1",
				ImagesURLs = new List<string>(),
				VideosURLs = new List<string>(),
				ActorsIds = new List<int> { 1 }
			};
			Assert.ThrowsAsync<InvalidOperationException>(async () => await _playService.EditAsync(3, model));
		}
		[Test]
		public async Task CreateAsync_WithValidData_ShouldCreatePlay()
		{
			var model = new PlayFormModel
			{
				Title = "Play3",
				Genre = "Genre3",
				Description = "Description3",
				Location = "Location3",
				DateAndTime = DateTime.Now,
				TicketURL = "TicketURL3",
				Town = "Town3",
				ImagesURLs = new List<string>(),
				VideosURLs = new List<string>(),
				ActorsIds = new List<int> { 1 }
			};
			var result = await _playService.CreateAsync(model);
			Assert.That(result, Is.EqualTo(3));
		}
		[Test]
		public async Task DeleteAsync_WithValidData_ShouldDeletePlay()
		{
			await _playService.DeleteAsync(1);
			var result = await _playService.ExistsById(1);
			Assert.That(result, Is.False);
		}
		[Test]
		public async Task DeleteAsync_WithInvalidData_ShouldDoNothing()
		{
			await _playService.DeleteAsync(3);
			var result = await _playService.ExistsById(3);
			Assert.That(result, Is.False);
		}
		[Test]
		public async Task DeleteAsync_WithInvalidData_ShouldDeleteActorPlay()
		{
			await _playService.DeleteAsync(1);
			var result = await _repository.AllAsReadOnly<ActorPlay>().AnyAsync(ap => ap.PlayId == 1);
			Assert.That(result, Is.False);
		}
		

		
		
	}
}
