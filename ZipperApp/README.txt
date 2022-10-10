Program Name: ZipItWebApp
Program Author: Justin Brierley
Student ID: 0724299
Date Started: 2022-10-08

------ > PROPERTIES OF A ZIPPER < ------
    1. Name
    2. Material
    3. Teeth Size       - XXS
                        - XS
                        - S
                        - M
                        - L
                        - XL
                        - XXl

    4. Category - industrial
                - sandwich bag
                - fashion
    5. Price
    7. Colour

----------------------------------------

-- 9:10PM --
created the ZipItWebApp
commented out ssl port
added a controller called HelloWorldController.cs

-- 9:25PM -- 
time to create a view
view created
   -->Views/HelloWorld/Welcome.cshtml
   view created for the HelloWorldController
    **testing results: successful**
time to add a zipper model

problem: cannot install EFCore
solution: --Version extension
         --Version 3.1.0 solved my issue

-- 10:25PM --
successfully added the zipper model
now time to *scaffold*


-- 12:51AM --
-- the date is now 2022-10-09, and after a long reset, we finally have a successful scaffold!
  -> problem: i forgot to add the connection string for ZipperAppContext in appsettings.json
  -> problem: was making a typo in the Startup.ConfigureServices method
  -> problem: was not making use of the -Context extension in my package manager console to choose which context i wanted to work with
            -> -Context ZipperAppContext    solved my problem

Date Modified: 2022-10-09

-- 8:35PM --
time to add database
database created 
SeedData.cs class created in Models folder
SeedData has 10 products and their properties
have to run to see if seeding data was successful
        -> seeding: successful

-- 10:00PM --
upload progress to gitHub
time to add Search functionality!
- search by name first
   ->completed
     ->test result: success

- search by category next
    -> success!

Date Modified: 2022-10-10

-- 3:00PM --
I forgot to add a rating field, so I will add that next
    -> success! users can now edit product ratings

-- 3:15PM --
time for validation
    -> validation successfully added

Time for the fun part!! Adding Styles!!
