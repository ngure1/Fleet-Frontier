## FLEET FRONTIER
### Database configuration
1. Assuming you have docker installed ...run the following comand to pull the mysql image
```bash
  docker pull mysql
```
2. After the download is complete run the following command to start an instance of the image
```bash
docker run --name student-test-server -e MYSQL_ROOT_PASSWORD=default123 -p 33062:3306 -d mysql
```
3. Ensure the container ``student-test-server`` is running and connect it to either mysql workbench or your favourite software to run the sql commands.
 **NB:Make sure you use the server as localhost, port as 33062, username as root and password as default123**
4. After connecting it successfully open the [db_config](./db_config/) folder and run the commands in [fleet_finder.sql](./db_config/fleet_finder.sql) in the software you connected the server to.
<!-- 
6. Open the project in your terminal and run the following commands:
##### To restore the dependencies
```bash
dotnet restore
```
##### To build the project. 
```bash
dotnet build
```  -->
<!-- 
7. Now open the solution in vusual studio and run it...hopefully it works &#x1F480; -->