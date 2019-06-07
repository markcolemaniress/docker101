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
1. Open a Powershell window and change to the `compose\database` folder.
2. Run `docker build -t dockerdemodb .` (don't forget the . at the end - this specifies to use the dockerfile in the current directory.) This will build the database image.
3. Change into the `compose\app` folder.
4. Run `docker build -t dockerdemoapp .` to build the API application image.
5. Change into the `compose\web` folder.
6. Run `docker build -t dockerdemoweb .` to build the website image.
7. Change into the `compose` folder.
8. Run `docker-compose up -d` to spin up 3 containers (in detached mode) relating to the images you've just built.
9. Browse to http://localhost:8302/ to test the application. 
10. Once finished use `docker-compose down` to tear down the containers.


