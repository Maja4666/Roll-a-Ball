# **1\. Blogpost: Roll-a-ball**

This tutorial was the first time I worked with Unity, 
so all the features that are in Unity are new. This was furthermore 
also the first game I have made.

Because it being the first game I have developed, 
the tutorial was a good way to learn some of the basic tools and
mechanics in Unity. It went through the process and with the 
videos help explain why and have to make the game from scratch 
with no previous knowledge.

But because of it not saving right the first time, 
the scene that is, I made it again from mainly memories, 
as such for the fact that this was new, I have forgotten
have to make the player move. The user input component which
was what the player object didn’t have assigned to it.
This is a really difficult thing to determent when the
severity and imponent is lost in all the other step in
the tutorial. I figured it out and the player could now
be moved by the user.

## New features

The first thing that I worked on was making the scene a
little bit bigger and adding more walls so that it became
more of a maze. In that I also changed the camara angel to
be more a top-down view to make it easier to see where the
player is. In the maze there are holes that only the player
can get through but the enemy, this makes it a little easier
for the player.

Furthermore, I have added a different collectable which 
first spawns after a specific amount of time. Thereby the
player has to go round the map again to collect the points
necessary to trigger the winning condition. This was done
with a delay script where invoke is used and the game object
is set to active false.