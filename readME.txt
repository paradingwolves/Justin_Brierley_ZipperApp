----- Commands You Will Need To Build This Project -----

1. Install-Package Microsoft.EntityFrameworkCore.SqlServer --Version 3.1
2. add-migration ZipperApp -Context ZipperAppContext
3. update-database -Context ZipperAppContext



What is this project? 

- This is a website for the fictional company "Zip It!". This application was built using MVC architecture. 
- included are employee/About Us pages, as well as a product catalogue that uses CRUD operations.
- i was aiming at having 3 column layouts on each desktop view, then a 2 column layout on tablets, and eventually 
a single column layout on mobile phones


------ > PROPERTIES OF A ZIPPER < ------
    1. Name
    2. Material
    3. Teeth Size       
                        - XS
                        - S
                        - M
                        - L
                        - XL

    4. Category - magic
                - fashion
    5. Price
    7. Colour

----------------------------------------
 i have discovered that zippers are very boring so to spice it up, i made a Magic category for zippers
 
 to limit possibilities of an SQL Injection attack, Category and Teeth Size user inputs will be a select list
 
 rather than display products in a table (boring), i have decided to display my products in divs
 
i didn't want my colour scheme to be obnoxious, so i stayed with lighter colours and shades throughout the website
