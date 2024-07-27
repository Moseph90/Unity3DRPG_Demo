This demo is nearly complete with a few caveats. There are 3 bugs that I need to adress, they are listed in this readme. There is one particular bug that is game breaking which has to do with the dragon at the top of hill. It's listed in the bugs section. I suggest you read it so that you don't crash Unity. Here are the controls and what you need to know to play the game:

Just enter into Unity and go into the Scenes folder and choose which scene you want to start with and press play. As of now there are no compilation errors or anything so you should be good to go. 
There are 3 scenes in the Scenes folder. One is for the main menu, the other is the game over menu and the other is the game scene. You can choose whichever one as they all flow together nicely, however
I would recommend starting from the game scene because for some reason the shaders don't load properly when you start from the main menu. I suspect that will change when I make an actual build. Just know that when you start from the game scene, you have to click into the game for the mouse cursor to be hidden.

Controls:

-Look around: Mouse

-Movement: WASD or Arrows

-Jump: Space

-Pause Game: P

-Heavy Punch Attack: Left Mouse Button

-Axe Attack: Right Mouse Button

-Fire Ball Attack: Left Control

There is a siver coin in the game that if you pick up, will end the game. I don't know why I put that there but I decided not to remove it.

Incomplete mecahnics (not bugs but still need to fnish):

-Enemy Targeting is not implemented yet and so killing enemies, especially the dragon at the top of the hill in the middle of the level, is difficult to say the least. I will be implementing it soon.
There is also no defensive spells or anything and so it's just offense for now. It's still possible to kill the dragon but it's very difficult.

 -Have not implemented a jump or swim animations, although you can both jump and swim.

 -Swimming works fine, but if you jump in the water, the player's downward velocity will put him below the surface and because I have not yet implemented an upward force to the swimming, you just stay there.

Bugs:

 -As the axe weapon is stored inside of the player, it can sometimes hit things causing them damage. Need to have the axe in hand during every animation or at least disable collisions until we attack.

 -When fighting the dragon, if you leave the fight area, Unity crashes. I haven't figured out why yet. I know that the issue is in the enemy dragon script because when the dragon dies, this doesn't happen. But I still don't have an anwer as to why.

-Some of the crossfade animations can cause problems when calling them as it usually waits for the previous animation to end, and so I think the corss fade is causing issures. It's mostly good though.
