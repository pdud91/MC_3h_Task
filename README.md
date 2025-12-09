> This project is the result of my attempt at doing a task which details were given to me the moment the timer has started.
> The main requirement was that completing it - and a few other things not disclosed here - had to be done in under 3 hours.
> This project - from creating the repository to pushing the last change - took me around 2 hours and 30 minutes.

# The task details

## Main requirements

Create a small 2D game using Unity and the default Unity assets, that has the following features:
1. Main Menu 
    - 3 buttons: Play, Settings, Exit that can be clicked on and navigated between using the keyboard 
    - the exit button should shut down the game 
    - the settings button should take you to the Settings screen and the Play button should start the game 
2. Settings screen
    - there should be 2 checkboxes: Checkbox 1 and Checkbox 2 
    - no functionality is required besides checking them and unchecking 
    - no data needs to be saved 
    - there should also be a Back button 
    - the escape button should take you back to Main Menu 
3. Play 
    - the camera background cleared to a green solid color 
    - the camera should be at default (0, 0, -10) position 
    - player and enemies should be rendered as sprites at scale (0.2, 0.2, 0.2) using Unity’s default Circle sprite 
    - using the keyboard the player should be able to control their character within the screen 
    - 1000 enemy characters should be running away from the player 
    - enemies should not leave the screen 
    - when the player touches an enemy character the enemy should stop moving 
    - the escape button should take you back to Main Menu 

## Additional requirements 

4. The player should be able to navigate through the game using a mouse or keyboard alone 
5. The UI should be implemented using uGUI

# Post mortem

## Issues

- I had unexpected issues after creating a new project via “Universal 2D” template - a lot of basic packages were missing and I had to add them in manually. It cost precious minutes to fix as it was unexpected and it took time to import the assets then commit the changes.
- I had a few bugs that needed rectifying, but nothing major.
- When it came to keeping the player and enemies inside the view, I thought of simply blocking in the area with 2d colliders as walls, but then I realized it wouldn’t work if the aspect ratio changed. Instead, I opted for calculating bounds of the Viewport and manually restricting each unit’s movement.
- EnemyManager calls the handmade Error when Scene is unloaded. It’s because it’s destroyed before Enemies, who then try to use the Unsubscribe method. I didn’t have time to fix it.

## Possible improvements

- I would polish a lot of things, e.g. add new visuals (e.g. enemies changing color when immobilised), sounds and music, new functionality (e.g. score system, noise to enemy movement).
- I would also want to optimize the code to make the game’s performance high and stable.
- I would probably switch to the new Input system, to make compatibility for more devices easier to implement.
- I would probably refactor the code, to make it easier to scale and manage long-term.

