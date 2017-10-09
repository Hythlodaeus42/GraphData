### Overview
This app builds a 3D model of data lineage in Unity, which can then be deployed to a Hololens.

### Model
The model represents data flows from source system to file to tables which support business functions. Nodes are placed into layers to show the progression of data through the solution.

### Graph data
There is a Data folder (not part of the Unity project) that contains the nodes and edges of the graph. There is an R script that applies a Fruchterman Reingold algorithm to layout the system nodes in 2D. The third dimension is supplied by the node layer. The resultant csv files are embedded as Resources in the Unity app. 

### Features
Voice commands:
* Spin - rotates the entire model
* Stop - stops the rotation
* Labels - toggles the node labels.

### Software
* Windows 10 Pro 64-bit 
* Unity 2017.1.1f1 (64-bit)
* Hololens Emulator

A setup guide can be found here:
https://developer.microsoft.com/en-us/windows/mixed-reality/install_the_tools

### Build Instructions
Create a folder called App to build the Unity app for hololens. The App folder is set to be ignored by Git. 

Open the App in Visual Studio and build and deploy to the Hololens device or emulator.

### To Do
* Add search functionality (ideally using voice)
* Highlight nodes and edges for ancestors and descendants
* Label each object (partially done)
* Show edge direction
* Gaze and gestures to select an object
* Display more information about a selected object
* Add spatial mapping
* Improve object placement for Hololens
