# Rocket_Elevators_Customer_Portal

This repo serves as the base for the new Rocket Elevators Customer Portal created using ASP.NET.

The live site is located at: http://customer-portal-burroughs.herokuapp.com/ .

The GitHub repo for this website can be found at: https://github.com/ACLTearr/Rocket_Elevators_Customer_Portal.git .

The ASP.NET application is deployed on Heroku through the use of a buildpack.

The site can not be accessed until logged in as a user, and a user can only be registered if the email that they are using to register is the email of a customer in the Rocket Elevators MyDQL Database.

Currently, the only registered user is test@test.ca, with a password of Test123! .

In the Profile tab of the site, a user can see all of the information related to the customer that they are linked to in the MySQL database.

In the Products tab, all Rocket Elevators products linked to the logged in customer can be seen.

In the Intervention tab, a customer can submit an intervention on a number of their products, and it will be saved into the database.

All MySQL database manipulation is done through a REST API with a URL of: https://rest-api-burroughs.herokuapp.com and for which the code for the API can be found at the following GitHub repo: https://github.com/ACLTearr/Rest-API-Rocket-Elevators.git .

This API is deployed on Heroku through the use of the same buildpack as the ASP.NET application.