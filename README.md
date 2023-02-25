The steps to develop the project was as below -

Step #1: At the very beginning, create a folder named "BlazorCodeFirst".
Step #2: Open command prompt and moved to the folder "BlazorCodeFirst".
Step #3: Execute the command "dotnet new blazorwasm --hosted --pwa" . Here PWA = progressive web application.
Step #5: Create common class in shared projects which will be shared in both client and the server. Here models in terms of entity class, view model etc is created.
Step #6: Create data folder in server project where context class and data access layer need to create.
Step #7: Execute "add-migration" from package manage console where server is the selected project..
Step #8: Execute "update-database" where connection string is well configured.
Step #9: To create seed data, execute "add-migration seeddata" where seeder script is created as per the configuration.
Step 10: In order to insert seed data in DB, execute "update-database seeddata".
Step #11: develop as per the requirements.
