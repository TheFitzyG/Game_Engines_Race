# Game_Engines_Bungeejump

Concept
- Kalleidescopic bungee jump
- uses spring joint on player's feet.
- jump into generative Kallidascope.
- Interesting way to explore a generative enviroment.

How does it work
- Colourfull wavey floor using Shader graph to randomise a colour pattern. the colour is then interpreted as a height fo the mesh to be adjusted to.
- 20 sided sphere, UV cut on every edge. using shader graph again to adjust the heights and colours of each tri. creating an almost sea urchin effect.
-rotators that move with invisible arms. when staggered and layered, creat interesting patterns between urchins. 
-deep underwater ambiant audio to se the mood for the scene
-bungee jump fot the player's first person view to ride on, creatign a weightless feeling. Activate this by pressing Space (resets with a second press of Space).

everything was developed by me, besides the first person camera controlls which I copied and modified form here: http://wiki.unity3d.com/index.php/SmoothMouseLook

Proud to have leared how much can be done wiht ease using shader graph. 

Build is contained in Builds.zip

Video:
[![YouTube](http://img.youtube.com/vi/VIDEO_ID/0.jpg)](https://www.youtube.com/watch?v=TwP8u1y1x2I)




///////////////////////////////////////////////////////////////////////////////////////////////////////

[Redacted] Changed to a better for feesable Idea.
- variety of randomly generated creatures will race down a hill. 
- the best of each race will be kept on for the next race. 
- the track is randomly generated with each race. It will have many variations in its hills and turns. 
- The goal of this project is to create a system that in theory should generte a perfect creature for traversing the enviroment.

Inspirations:

- Marble racing
- Evolution simulators


