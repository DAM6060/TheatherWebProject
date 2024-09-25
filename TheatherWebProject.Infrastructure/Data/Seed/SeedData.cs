using Microsoft.AspNetCore.Identity;
using TheatherWebProject.Infrastructure.Data.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TheatherWebProject.Infrastructure.Data
{
    public class SeedData
    {
        public SeedData()
        {
            SeedIdentityUsers();
            SeedApplicationUsers();
            SeedActor();
            SeedPlay();
            ActorPlay();
            SeedComment();
        }

        public IdentityUser AdminUser { get; set; }

        public IdentityUser IdentityUser { get; set; }

        public ApplicationUser User1 { get; set; }

        public ApplicationUser User2 { get; set; }

        public Actor AlexDimitrova { get; set; }

        public Play Play { get; set; }

        public Comment Comment { get; set; }

        public ActorPlay ActorPlay1 { get; set; }

        private void SeedIdentityUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            AdminUser = new IdentityUser
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "ddimitar98@gmail.com",
                NormalizedUserName = "ddimitar98@gmail.com",
                Email = "ddimitar98@gmail.com",
                NormalizedEmail = "DDIMITAR98@GMAIL.COM"
            };

            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "@Admin123");

            IdentityUser = new IdentityUser
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "varnasharks.afc@gmail.com",
                NormalizedUserName = "VARNASHARKS.AFC@GMAIL.COM",
                Email = "varnasharks.afc@gmail.com",
                NormalizedEmail = "VARNASHARKS.AFC@GMAIL.COM"
            };

            IdentityUser.PasswordHash = hasher.HashPassword(IdentityUser, "@User123");
        }

        private void SeedApplicationUsers()
        {
            User1 = new ApplicationUser
            {
                Id = 1,
                IdentityUserId = AdminUser.Id,
                DisplayName = "Dimitar Dimitrov"

            };

            User2 = new ApplicationUser
            {
                Id = 2,
                IdentityUserId = IdentityUser.Id,
                DisplayName = "VarnaSharksAFC"
            };
        }

        private void SeedActor()
        {

            AlexDimitrova = new Actor
            {
                Id = 1,
                FirstName = "Alex",
                LastName = "Dimitrova",
                Description = "Alex Dimitrova is a young and talented actor who has been in the industry for 5 years. She has starred in a number of successful films and TV shows and has received critical acclaim for her performances. She is known for her versatility and ability to bring depth and emotion to her characters. Alex is a dedicated and hard-working actor who is always looking to challenge herself and push the boundaries of her craft. She is passionate about her work and is committed to delivering the best possible performance in every role she takes on.",
                ActorImageURLs = ["/Images/153265986_2893861524220139_5094173891309400300_n.jpg"]

            };
        }
        private void SeedComment()
        {
            Comment = new Comment
            {
                Id = 1,
                Content = "This is a great play! I highly recommend it to everyone!",
                PlayId = Play.Id,
                ApplicationUserId = User1.Id,
                CreatedOn = new DateTime(2025, 12, 15, 19, 30, 0)
            };

        }

        private void SeedPlay()
        {
            Play = new Play
            {
                Id = 1,
                Title = "Romeo and Juliet",
                Description = "Romeo and Juliet is a tragedy written by William Shakespeare early in his career about two young star-crossed lovers whose deaths ultimately reconcile their feuding families. It was among Shakespeare's most popular plays during his lifetime and along with Hamlet, is one of his most frequently performed plays. Today, the title characters are regarded as archetypal young lovers.",
                PlayImagesURLs = ["/Images/IMG_0843(i).jpg", "/Images/dyslexia card.jpg"],
                PlayVideosURLs = ["https://www.youtube.com/watch?v=CCI3XPFjqn8"],
                Location = "Opera Varna, CenterOdesos, pl. \"Nezavisimost\" 1, 9000 Varna",
                DateAndTime = new DateTime(2025, 12, 15, 19, 30, 0),
                TicketURL = "https://www.eventim.bg/bg/",
                Genre = "Comedy",
                Town = "Sofia"

            };
        }
        private void ActorPlay()
        {
            ActorPlay1 = new ActorPlay
            {
                ActorId = AlexDimitrova.Id,
                PlayId = Play.Id
            };
        }


    }
}