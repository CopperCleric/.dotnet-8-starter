using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

// dotnet ef migrations add AddSeedData --project Infrastructure --startup-project WebApi
// dotnet ef database update --project Infrastructure --startup-project WebApi

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options) { }

    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().HasData(
            new User { Id = Guid.NewGuid(), Username = "John Doe", Mail = "john.doe@gmail.com", PhoneNumber = "0112345678", Skillsets = "C#, ASP.NET, EF Core", Hobby = "Gaming" },
            new User { Id = Guid.NewGuid(), Username = "Jane Smith", Mail = "jane.smith@gmail.com", PhoneNumber = "0123456789", Skillsets = "JavaScript, React, Node.js", Hobby = "Reading" },
            new User { Id = Guid.NewGuid(), Username = "Michael Johnson", Mail = "michael.johnson@gmail.com", PhoneNumber = "0134567890", Skillsets = "Python, Django, Flask", Hobby = "Cycling" },
            new User { Id = Guid.NewGuid(), Username = "Emily Davis", Mail = "emily.davis@gmail.com", PhoneNumber = "0145678901", Skillsets = "Java, Spring Boot", Hobby = "Photography" },
            new User { Id = Guid.NewGuid(), Username = "Daniel Wilson", Mail = "daniel.wilson@gmail.com", PhoneNumber = "0156789012", Skillsets = "Go, Kubernetes, Docker", Hobby = "Cooking" },
            new User { Id = Guid.NewGuid(), Username = "Olivia Brown", Mail = "olivia.brown@gmail.com", PhoneNumber = "0167890123", Skillsets = "Ruby, Rails, PostgreSQL", Hobby = "Hiking" },
            new User { Id = Guid.NewGuid(), Username = "William Lee", Mail = "william.lee@gmail.com", PhoneNumber = "0178901234", Skillsets = "C++, Unreal Engine", Hobby = "3D Modeling" },
            new User { Id = Guid.NewGuid(), Username = "Sophia Martin", Mail = "sophia.martin@gmail.com", PhoneNumber = "0189012345", Skillsets = "Swift, iOS Development", Hobby = "Traveling" },
            new User { Id = Guid.NewGuid(), Username = "James Taylor", Mail = "james.taylor@gmail.com", PhoneNumber = "0190123456", Skillsets = "PHP, Laravel, MySQL", Hobby = "Fishing" },
            new User { Id = Guid.NewGuid(), Username = "Ava Anderson", Mail = "ava.anderson@gmail.com", PhoneNumber = "0111234567", Skillsets = "HTML, CSS, UX Design", Hobby = "Painting" },
            new User { Id = Guid.NewGuid(), Username = "Benjamin Thomas", Mail = "benjamin.thomas@gmail.com", PhoneNumber = "0122345678", Skillsets = "Python, Pandas, NumPy", Hobby = "Chess" },
            new User { Id = Guid.NewGuid(), Username = "Mia Jackson", Mail = "mia.jackson@gmail.com", PhoneNumber = "0133456789", Skillsets = "R, Data Analysis", Hobby = "Writing" },
            new User { Id = Guid.NewGuid(), Username = "Logan White", Mail = "logan.white@gmail.com", PhoneNumber = "0144567890", Skillsets = "Scala, Akka, Kafka", Hobby = "Skiing" },
            new User { Id = Guid.NewGuid(), Username = "Isabella Harris", Mail = "isabella.harris@gmail.com", PhoneNumber = "0155678901", Skillsets = "Android, Kotlin, Jetpack", Hobby = "Drawing" },
            new User { Id = Guid.NewGuid(), Username = "Ethan Lewis", Mail = "ethan.lewis@gmail.com", PhoneNumber = "0166789012", Skillsets = "Unity, Game Dev, C#", Hobby = "Board Games" },
            new User { Id = Guid.NewGuid(), Username = "Charlotte Clark", Mail = "charlotte.clark@gmail.com", PhoneNumber = "0177890123", Skillsets = "Figma, UI Design", Hobby = "Singing" },
            new User { Id = Guid.NewGuid(), Username = "Alexander Young", Mail = "alexander.young@gmail.com", PhoneNumber = "0188901234", Skillsets = "Machine Learning, TensorFlow", Hobby = "Running" },
            new User { Id = Guid.NewGuid(), Username = "Amelia King", Mail = "amelia.king@gmail.com", PhoneNumber = "0199012345", Skillsets = "SQL, ETL, Data Warehousing", Hobby = "Yoga" },
            new User { Id = Guid.NewGuid(), Username = "Henry Scott", Mail = "henry.scott@gmail.com", PhoneNumber = "0110123456", Skillsets = "Bash, Linux, Ansible", Hobby = "Trekking" },
            new User { Id = Guid.NewGuid(), Username = "Evelyn Green", Mail = "evelyn.green@gmail.com", PhoneNumber = "0121234567", Skillsets = "AI, LLMs, OpenAI API", Hobby = "Origami" }
        );
    }
}