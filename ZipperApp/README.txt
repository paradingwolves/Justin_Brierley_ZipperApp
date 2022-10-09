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

-- 10:25PM --
successfully added the zipper model
now time to *scaffold*


-- 12:51AM --
-- the date is now 2022-10-09, and after a long reset, we finally have a successful scaffold!
  -> problem: i forgot to add the connection string for ZipperAppContext in appsettings.json
  -> problem: was making a typo in the Startup.ConfigureServices method
