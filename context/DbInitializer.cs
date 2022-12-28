using baseNetApi.models;
using Microsoft.EntityFrameworkCore;

namespace baseNetApi.context;

public class DbInitializer
{
    private readonly ModelBuilder modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        this.modelBuilder = modelBuilder;
    }
    
    public void Seed()
    {
        modelBuilder.Entity<User>().HasData(
            new User()
            {
                id = 1, role = Role.Admin, username = "dainq",email = "admin@gmail.com",
                firstName = "Dai", lastName = "Ngo",
                phoneNumber = "0989889889", address = "Hai Phong",
                birthday = "10-02-2003", gender = "Male",
                password = BCrypt.Net.BCrypt.HashPassword("123456")
            },
            new User(){
                id = 2, role = Role.User, username = "user",email = "user@gmail.com",
                firstName = "User", lastName = "New",
                phoneNumber = "0968886868", address = "Ha Noi",
                birthday = "01-01-2003", gender = "Male",
                password = BCrypt.Net.BCrypt.HashPassword("123456")
                
            }
        );
    }
}