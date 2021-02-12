# WebAPI Test For GrapeCity
Hi Team,

Kindly find the project where i have implemented Create, Get, Update and delete blog APIs.
The pictures are attached in the APIscreenshots file for more reference.
Header- "Content-Type":"application/json"
API Links-

#Get: http://localhost:50316/api/blog/   ----List of all the blogs

#Get: http://localhost:50316/api/blog/1  ----A specific blog

#Post: http://localhost:50316/api/blog/create ----Add a new blog
Body: 
{
    "ID":7,
    "BlogHeader":"Added blog 7",
    "BlogBody":"this is the added body"
}

#Post: http://localhost:50316/api/blog/edit ----Edit an existing blog with the number
{
    "ID":7,
    "BlogHeader":"updated blog 7",
    "BlogBody":"this is the added body of the blog 7 and is now being updated."
}

#Delete: http://localhost:50316/api/blog/7 ----Delete a blog


Thanks,
Sarthak Verma
