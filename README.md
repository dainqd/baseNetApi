READ

** LOGIN INFORMATION (username/password):

- User: user / 123456
- Admin: dainq / 123456

**SETTING

You need to run it locally by following these steps:
1. Download and install Xampp (choose the version with PHP 8.1): https://www.apachefriends.org/download.html (for MacOS, use MAMP)
2. Open Xampp and start Apache & MySQL
3. In your browser go to http://localhost/phpmyadmin and create a new database with collation utf8mb4_unicode_ci then import the attached .sql file (optional)
4. Download the source code and open it on your IDE (such as PHPStorm)
6. Install dependencies: install composer using Visual Studio application(https://visualstudio.microsoft.com/fr/) or Rider(https://www.jetbrains.com/rider/)
6. Clone the project at GitHub: https://github.com/dainqd/baseNetApi
7. Open the editor and download the required libraries in the next step
8. At the NuGet download port of the editor, download the following NugetPackage with the command: dotnet add package + Nuget name + --version
  <p> Pomelo.EntityFrameworkCore.MySql ( -- version 6.0.2) </p>
  <p> BCrypt.Net-Next( -- version 4.0.3) </p>
 <p>  Swashbuckle.AspNetCore( -- version 6.2.3)</p>
 <p>  Microsoft.EntityFrameworkCore.Design ( --version 6.0.8)</p>
 <p>  Microsoft.EntityFrameworkCore( --version 6.0.8)</p>
 <p>  Microsoft.AspNetCore.Authentication.JwtBearer( --version 6.0.8)</p>
 <p>  AutoMapper.Extensions.Microsoft.DependencyInjection( --version 6.0.0) </p>
  <p> AutoMapper( --version 8.0.0) </p>
9. At the appsetting.json file, make a connection to the database and run the following commands:
    <p> dotnet tool install --global dotnet-ef</p>
   <p> dotnet ef migrations add InitialCreate</p>
   <p>dotnet ef database update </p>
10. Launch the project