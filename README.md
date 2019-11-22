# Web-Dev-Bootcamp - Web Application Development #

**Web-Dev-Bootcamp** is an application build with visual studio code. It's a CRUD Application of Students, Teachers & Classes.

## Team Members Information ##

1. Het Kansara (N01330009)
2. Kshitija Patel (N01363715)
3. Dhanpreet Singh (N01403913)

## How to configure the project? ##

1. Clone Git Repository - Using GIT CLI
    * Open Terminal
    * `git clone https://github.com/hetkansara/Web-Dev-Bootcamp.git`
2. Navigate to project directory - `Web-Dev-Bootcamp`
3. Open project with [`Visual Studio`](https://visualstudio.microsoft.com/downloads/)
4. Configure your mysql database credentials in `SCHOOLDB.cs`
    ### SCHOOLDB ###
    ![SCHOOLDB.cs](https://i.ibb.co/GnSK2GW/Screenshot-50.png)
5. Run `Login.aspx`
    > `Username`: Admin
    > 
    > `Password`: Admin  

## Wireframes ##
   ### Login
   ![Login Page](https://i.ibb.co/3TKh3H6/Screenshot-53.png)

   ### List Page
   ![List Page](https://i.ibb.co/sVv4zfw/Screenshot-55.png)

## Structure of Project(Code Organization) ##

### Dependencies ###
    * Visual Studio 
    * MySQL Server

### Frontend ###
`Login.aspx` is the landing page of the web application. `Student.aspx` is the home page containing all the listing pages. It will render the list by using the variable(`listType`) passed in the url. Another variable(`loginid`) is also passed in all the pages. If that variable is not present in the url, website will show the error page.

All CSS files are at `Content/` folder and all Scripts are located in `Content/Scripts` folder.

There are many Javascript files which are bundled together with `Webpack`, which combines all of them and outputs a `app.bundle.js` which is included in `index.html`.

### Backend ###
We have a `School` database in the backend. The structure of the database is as given below.

### Students Table ###

| STUDENTID | STUDENTFNAME | STUDENTLNAME | STUDENTNUMBER | ENROLLMENTDATE |
| ------- | ----------- | ----- | ------- | ------ |
| 1 | Sarah | Valdez | N1678 | 2018-06-18 |
| 2 | Jennifer | Faulkner | N1679 | 2018-08-02 |

### Teachers Table ###

| TEACHERID | TEACHERFNAME | TEACHERLNAME | EMPLOYEENUMBER | HIREDATE |
| ------- | ----------- | ----- | ------- | ------ |
| 1 | Alexander | Bennett | T378 | 2016-08-05 |
| 2 | Caitlin | Cummings | T381 | 2016-08-05 |

### Classes Table ###

| CLASSID | CLASSCODE | TEACHERID | STARTDATE | FINISHDATE | CLASSNAME |
| ------- | ----------- | ----- | ------- | ------ | -------- |
| 1 | http5101 | 1 | T378 | 2018-09-04 | Web Application Development |
| 2 | http5102 | 2 | T381 | 2018-09-04 | Project Management |
