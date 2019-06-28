# Docker 101 - An introduction to Docker

## Installation
1. Go to https://www.docker.com/products/docker-desktop and click **Download Desktop**
2. Sign up with Docker Hub
3. Download and install Docker Desktop
4. Restart your machine.
5. After restarting the Docker icon should appear in your system tray
---
## Getting Started
1. Open a Powershell window
2. Type `docker --version` to check that Docker has installed successfully
3. Type `docker run -d -p 8080:80 --name nginxtest nginx` - this will download the *nginx* web server image and spin up a container mapping local port 8080 to port 80 in the container.
4. Check this worked by listing the running containers using `docker container ls`
5. Once the container is up and running, browse to http://localhost:8080 and you should see the nginx test page.
6. To stop the container run `docker container stop nginxtest`
---
## Example Code
The code samples from the Lunch & Learn session are in this repository under:
#### HTML
Example pages for the web server volume mountin demo.
#### Demo
Example website used to demonstrate building and hosing a simple ASP.NET Core website with Docker containers.
#### Compose
Full example using **docker-compose** to spin up a sample multi-tier application with a web site, API and database.
To run this sample...
1. Open a Powershell window and change to the `compose` folder.
2. Run `.\build-images.ps1` to build the three images
3. Run `docker-compose up -d` to spin up 3 containers (in detached mode) relating to the images you've just built.
4. Browse to http://localhost:4000/ to test the application. 
5. Once finished use `docker-compose down` to tear down the containers.

#### Optional:
*Run multiple versions of each container using the docker-compose option --scale. For example, to run 2 web servers and 3 app servers:*

    docker-compose up --scale web=2 --scale app=3  

## Useful Commands
### List all images
    docker image ls
### List all containers 
    docker container ls -a
### Stop a container
    docker container stop <container id or name>
### Remove a stopped container
    docker container rm <container id or name>
### Stop and remove a container
    docker container rm -f <container id or name>
### Stop all containers
    docker stop $(docker ps -a -q)
### Run a container
    docker run -p ext_port:int_port --name <container_name> <image_name>
_Examples_  
`docker run -p 8080:80 --name nginxtest nginx`  
`docker run -p 8079:80 --name apachetest httpd`
### Run a container in the background (daemon mode)
    docker run -d -p 8079:80 --name apachetest httpd
### Run a container with a mounted volume
    docker run --name <container_name> -p ext_port:int_port -v <host_folder>:<container_folder> <image_name>
_Example_  
`docker run --name my-nginx -p 8080:80 -v ${PWD}\html:/usr/share/nginx/html:ro -d nginx`  
 
**NB:** `{PWD}` is the present working directory in Powershell
### Run SQL Server
    docker run --name testmssql -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Password01!' -p 48944:1433 -d mcr.microsoft.com/mssql/server
	