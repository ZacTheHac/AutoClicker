# Auto Clicker

* Enter the process name (Exe name without the *.exe)
* Enter the window name to limit number of results (Partial Matching)
* Once you click start, the program will bring focus to that window and count down from 5, giving you time to line up your action.
* At the end of the countdown, the program will bring focus back to itself and begin clicking in the background
* When you want to stop, click "Stop" and it will stop the action.

The default values target Minecraft specifically

***

## Minecraft-Specific Instructions:


Disable Pause on Lost Focus by pressing <kbd>F3 + P</kbd> in-game

Alternatively, with minecraft closed:
* Access your .minecraft folder by opening explorer and paste this into the address bar: '%appdata%\\.minecraft'
* Open options.txt and set "pauseOnLostFocus" to "false"
* Save changes

## Core Files:
  * [Main.cs](https://github.com/ZacTheHac/AutoClicker/blob/master/AutoClicker/Main.cs) does all of the work. The rest is boilerplate stuff or special case items for say multiple instances.
  * [AutoClicker.exe](https://github.com/ZacTheHac/AutoClicker/blob/master/AutoClicker.exe) is a precompiled version of the program. Works fine as a standalone with no installation.