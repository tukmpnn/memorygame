
<div id="top"></div>

# Memory Game - aka a Matching Game
## About The Project

This project is the result of my school's GUI-course(Winforms) proof of skill project where I chose to create a Matching Game with the following requirements (*hyperlinks point to folder [UI-Sample-images](/UI-sample-images/)*):
* struct must be used
* different components and their events must be used in different ways
* Menus must be used in some way
* Interaction with filesystem
* [Exception handling](/UI-sample-images/gamesetting_errored.PNG), [*(Image after handling error)*](/UI-sample-images/gamesetting_errored_after.PNG)

Matching game specific requirements:
* Option for 1v1
* Option to specify number of cards in play
* Input for player names
* Leaderboard with player details
* *Matching game game logic implemented(multiple requirements)*
    - [*eg. randomized playfield*](/UI-sample-images/Mp_AllRevealed.PNG)

## Completed Features
Form system where user experience flow can be listed as follows:
* [Main Menu](/UI-sample-images/Menu.PNG) where one chooses to
    - [Play Single-player](/UI-sample-images/Sp_Game_HitnRevealed.PNG)
    - [Play 1v1](/UI-sample-images/Mp_Game_HitnRevealed.PNG)
    - [View the 1v1 Leaderboard](/UI-sample-images/Leaderboard.PNG)
    - Exit
* [Game setup](/UI-sample-images/Mp_Setup.PNG) where one chooses the settings of the game. Features include:
    - Select values for timers (round/switchover)
    - Number of cards in play
    - Card back image
    - Player and card back colours
* Game form where the player(s) play the game with the option to [exit / restart / pause the game](/UI-sample-images/ingame_menu.PNG)
* After game is complete the [Victory Screen](/UI-sample-images/Mp_VictoryScreen2.PNG) is shown with relevant message
    - User can choose to restart the game or to exit.

The application interacts with the filesystem by saving the previously set game settings to file, having different files for Single-layer and 1v1-games (*.json). Similarly the 1v1 Leaderboard is also saved to a .json file.

## About the creation process and planning
This was thrown together in late 2021 within 7 days of caffeine fuelled coding spree without any foreplaning or flowcharting. During summer 2022 the project was refactored to a presentable form by changing the UI from Finnish to English and cleaning up the things that had been in the back of my head ever since handing in the project; the only new feature was the completion of the ability chose a different card back (support for this was built in already in 2021, but not completed due to not being necessary for completion of the task).

---
## Built With

* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
* [.NET Framework 4.7.2 Windows Forms](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms?view=netframework-4.7.2)

#### Nuget packages

* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/13.0.1)

---
## Roadmap & Contributing
This is a stagnant project and no community contributions are expected. One is free to fork this in accordance with the license of the project and thus continue the further development or usage of the repository contents.

---
## License

Distributed under the MIT Licence where applicable. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>
