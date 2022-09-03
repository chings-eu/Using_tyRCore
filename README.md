# Using_tyRCore
Setup Visual Studio for Using tyRCore

As an external application for Autodesk Revit, tyRCore loads instantly each of your F# source codes each time when you save your changes and click on its individual command button without restarting your Revit! This repository **Using_tyRCore** provides a set-up Visual Studio solution as a template, with the fitting folder and naming structure for coding in F# by using tyRCore add-in in Autodesk Revit.

Visit [tailoryourbim.com] for more information and check [this blog entry][Compile F# Codes Without Restarting Revit] for information about _tyRCore_.

Here are a few screenshots introducing how to install tyRCore into your system and run your F# codes instantly in Autodesk Revit right after you save them.

## Install tyRCore

* With a right click, run this setup program as administrator.  
<p align="center"><img src="/assets/img/1_01_Run%20install%20as%20admin.png" width="400"></p>

* Recommended is to install the add-in for current user account.  
<p align="center"><img src="/assets/img/1_02_Install%20for%20current%20user.png" width="300"></p>

* License  
<p align="center"><img src="/assets/img/1_03_Agree%20on%20license.png" width="400"></p>

* Check the install path in the following page.  
<p align="center"><img src="/assets/img/1_04_Info%20before%20installation.png" width="400"></p>

* Default path: Add-In folder for Revit 2022  
<p align="center"><img src="/assets/img/1_05_Default%20install%20path.png" width="400"></p>

* Start menu group  
<p align="center"><img src="/assets/img/1_06_Setup%20menu.png" width="400"></p>

* Ready to install  
<p align="center"><img src="/assets/img/1_07_Click%20install.png" width="400"></p>

* Install is running.  
<p align="center"><img src="/assets/img/1_08_Installing.png" width="400"></p>

* Information after installation. Including how to uninstall.  
<p align="center"><img src="/assets/img/1_09_Thank%20you%20note.png" width="400"></p>

* Click finish to end the installation.  
<p align="center"><img src="/assets/img/1_10_Finishing.png" width="400"></p>

* Here are the distributed files after installation.  
<p align="center"><img src="/assets/img/1_11_Distrubuted%20files.png" width="400"></p>

## Load Your F# Codes in Revit
### First loading the external application
* Allow Revit to load tyRCore everytime it starts up.  
<p align="center"><img src="/assets/img/2_01_Always%20load.png" width="400"></p>


### There are two places where you can call the loading command:
* As a standalone add-in  
![Pushbutton standalone](/assets/img/2_02_Button%20in%20Add-Ins%20Tab.png)  

* Included in the _tyRevt_ tab.  
![Pushbutton tyR tab](/assets/img/2_03_Button%20in%20tyR%20Tab.png)

The reason that we need a button also under the external tools pulldown-button is that we can then call and load our F# source codes independently, without opening any Revit document first, for we might want sometimes to run our external command formlessly. 

And Now, you can fire up with a click on either of these two buttons, and choose the *_cmd_* folder for turning your codes into command buttons!

### Loading your codes is simple:
* Tell tyRCore how many ribbon tab you're about to load.  
<p align="center"><img src="/assets/img/3_01_How%20many%20ribbons.png" width="400"></p>

* Choose command folder to be loaded as a ribbon tab.  
<p align="center"><img src="/assets/img/3_02_Folder%20structure.png" height="400"></p>

* Loaded as structured ribbon tab  
![Ribbon tab](/assets/img/3_03_Loaded%20ribbon%20tab.png)

* Visual Solution explorer  
<p align="center"><img src="/assets/img/3_04_Solution%20explorer.png" width="400"></p>

* Next time, if you add a new one or change the name of the existing command, just hit the loading button again with the same selected folder.

## Work with Visual Studio
It'll then all go smoothly, after all the setups are done.  
Now you'll see that your source codes are loaded into pushbuttons on the ribbon tab, whose name contains the name of your solution, and everytime after you change and save your codes, just hit the same button again, and you'll see your change immediately!

## Furthermore
For more information, just visit us at [tailoryourbim.com](http://tailoryourbim.com) and leave us some feedback.  
If you like it, buy us a coffee! Much appreciated!  

Stay tuned!

[Compile F# Codes Without Restarting Revit]: https://tailoryourbim.com/revitexternalcommand/compile-f-codes-without-restarting-revit/
