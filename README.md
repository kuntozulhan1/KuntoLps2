# KuntoLps2

First step :
1. Setup appsettings.Staging.json & appsettings.json in KuntoLps2.Web.Host, changes ConnectionStrings Default to your local database.
2. Right click on KuntoLps2.EntityFrameworkCore, then klik Open in Terminal.
3. if you didn't have file 20231128071657_AddUploadFiles.cs on KuntoLps2.EntityFrameworkCore/Migrations then run 'dotnet ef migrations add AddNewTable'. If the file already exist. You can skip this part.
4. run script dotnet ef database update on Terminal.
5. if the script is running well, it will generate table on your database.

Second step : 
1. Download LPS.postman_collection.json.
2. Right click on KuntoLps2.Web.Host and click 'Set as Startup Project'.
3. then, run the application.

Third step :
1. in Postman, please Register your account using [Post]Register
2. after that, please Log in with the registered account using [Post]Login
3. copy accessToken, and paste that accessToken on Authorization in [Post]Upload File
