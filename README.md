# Social-Metaverse-with-MultiplayerVR

Would it not be awesome to watch your favorite movie with your friends in the metaverse?

![title-pic](https://github.com/saha0073/Social-Metaverse-with-MultiplayerVR/blob/main/outdoor_screeshot.png)
Created this MultiplayerVR social metaverse, similar to the popular Bigscreen VR app in VR headsets.

Besides 3D rendering, if there is one most essential feature of the metaverse, it should be multiplayer. Used Photon PUN, which is probably the most popular Unity package for implementing the multiplayer feature. It lets you see the avatar of your friends, interact with objects, and also allows you to talk with Photon voice. 

Integrated video streaming, which can facilitate watching movies together in multiplayer mode. It can also be used as college metaverse for attending live lectures with fellow students.

## Techniques Used:
* GameEngine: Unity3D 2020.3.36
* Tech Stack: C#
* Packages: LightShaft, XR Interaction Toolkit, Photon 
* Multiplayer features: Photon multiplayer, Photon voice, RPC calls, avatar selection

## Recording of the social metaverse in Quest2
The `./Recordings` folder contains several recordings during the gameplay. Below is a demo of watching Batman Dark Knight in the metaverse with Oculus VR!

<p align="center"><img src="https://github.com/saha0073/Social-Metaverse-with-MultiplayerVR/blob/main/Recordings/outdoor_school_gif.gif" style="width:80%"\></p>

## To run the Unity application
* Clone the repo and open the project in Unity 2020.3.36
* Download LightShaft package from Unity Asset Store, and import in your project
* Play the LoginScene, then HomeScene will start automatically, and finally choose netween outdoor, or school world

This project has been inspred by the MultiplayerVR course of [Tevfik](https://www.udemy.com/course/multiplayer-virtual-reality-vr-development-with-unity/). Happy Learning!
