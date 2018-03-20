KeyBinder is an application that allows users to edit their key configurations
for videogames in one place. Due to the nature of how videogame designers use
key bindings, each game has to be manually added and programmed into the application.
I explored several different games while researching, and while some games have a 
clear and easily modified file that would be perfect for this application, there are
many games that hide their keybindings in ways that make them inaccessable. 

For this project, I chose two games that I frequently play, that incidentally had
fairly manageable (well, somewhat managable as I came to findout) configuration files.

The two games I programmed in are called Killing Floor and the much newer sequel, Killing Floor 2.
Killing floor was by much easier to impliment because it stored the key bindings in a format
similar to "M=Attack"

In case you are unfamiliar with what this application is doing, let me write up a quick 
synopsis of what I was trying to achieve. 
By "binding the keys", what I am saying is that when I play the game, if I press a specific
button on my keyboard or mouse, it will perform a specific action. 
For instance, if I click my mouse, it will fire a gun in the game. With this 
application, you could change this setting to where if you press Z on the keyboard it would fire
the weapon instead of pressing your mouse. 
Modifying keys in PC gaming is important because keyboards are less ergononic for playing games,
aned every user has a different preference to where they want the keys that they would like 
to be. 
When you play the game, it is often cumbersome to deal with binding the keys, as often 
times the game will have an update that will lose your keybindings, and you will then
have to go reassign them.

===Testing My Application ===
I have included a folder called "Test Files" within the rood of my application.

I have included in this folder the following files:
KFInput.ini
KFInput-Copy.ini (the copies are to compare against after applying new settings)
User.ini
User-Copy.ini




An actual user who wanted to utilize my application would have to A. Have Killing Floor or Killing Floor2
installed on their computer, and B. Navigate through their folders to find those files. 
While I was hoping to automatically detect the files for ease of use, this proved
to be an unrealistic task, as the exact location of these files can be in different places.

For the vast majority of people, the files will be located in the same place (If they were using Steam
(the most popular game client for purchasing and playing games) to install the game that is, but not every
user will have installed the game with steam/

To test my application, you can open up one of the configuration files and take a look at what text exists
there prior to editing the files. The files included are barebones, in that all of the user-assignable
keys are empty. After choosing keys and applying those changes, take a look at the files again and the settings
will have been applied.

 
====Important NOTES=======

 The KillingFloor2 configuration file (Titled KFInput.ini) has a lot of information in it that is irrelivant and unassignable
by the user. When you edit this file, it may appear as if nothing changed, but all of the changes that have occurred
are in the last ~70 lines, and it is mostly reassigning definitions for the keys which are way towards
the bottom of the file.


===>The game Killing Floor is designed to work with the configuration file User.ini

===>The game Killing Floor 2 is designed to work with the configuration file KFInput.ini

While it does not actually matter that much in terms of what the file will ultimately look like if you
select the wrong file in the application ( I used a template system that is stored within the application
to generate the files), it would result in incosistencies in the names of the files 
application to avoid parsing over existing text and risk breaking the game) 