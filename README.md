# SnakeGame

So this is my first (small) attempt at a C# project.
I'm following the Snake Game tutorial I found <a href="https://www.mooict.com/c-tutorial-create-a-classic-snake-game-in-visual-studio/" target="_blank">` here. `</a>
The tutorial is a lot of cut-and-paste with all the logic writen for you, so it's a bit simple.
![Tutorial](https://github.com/dmstringer/SnakeGame/blob/main/readmepics/image-60.png)

I wanted to challenge myself a little bit, so I decided to add some up-dowm controls to the form to allow the player to change a few of the settings between games.
I added up-downs to change the size of the snake head/body pieces.
And I added one for the speed setting to see how fast I could make the game run ;), then set the 3 controls to be disabled during gameplay.

Then added code within the startGame method to change the Width, Height and Speed members of the Settings class based on the values in the added controls.

![Updated](https://github.com/dmstringer/SnakeGame/blob/main/readmepics/after.png)
