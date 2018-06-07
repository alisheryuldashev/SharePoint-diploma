In this lab, I had to create a farm solution that would create a web part to allow a subsite creation. 
When activated on a site, users of the site should be able to create new sub sites with pre-set document library (called Assignments) and 2 site columns (Submitted / Grade) using JSOM API.
To get the XML of site columns required for my web part, I used a PowerShell script to retrieve the Schema XML.
My solution package, when deployed, will modify the site collection it is deployed to in the following way:
1. 3 files will get uploaded to the Site Assets library in the site collection. 
2. A web part, called Create Student Site, will be added to the site collection and will point to the files in step 1.

![farm solution](https://user-images.githubusercontent.com/14170402/41109446-4b56cae2-6a34-11e8-977f-972b884f4d72.gif)

Important: Access to the source code is restricted for privacy reasons. If you are a prospective employer and would like to see my source code, please contact me for more information.
