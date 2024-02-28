z<a name="readme-top"></a>
<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->


<!-- PROJECT LOGO -->

<p align="center">
<img width="300" height="125" src="https://i.imgur.com/w5hcUtR.png">
</p>

<div align="center">

<h3 align="center">Lines, Curves & Splines</h3>

  <p align="center">
    A Unity Engine package for creating 2D lines, quadratic curves and any variation spline you can think of. 
    <br />
    <br />
    <a href="https://github.com//ryan-io/CommandPipeline/issues">Report Bug</a>
    ·
    <a href="https://github.com//ryan-io/CommandPipeline/issues">Request Feature</a>
  </p>
</div>

---
<!-- TABLE OF CONTENTS -->

<details align="center">
  <summary>Table of Contents</summary>
  <ol>
  <li>
      <a href="#overview">Overview</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites-and-dependencies">Prerequisites and Dependencies</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage & Examples</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments-and-credit">Acknowledgments</a></li>
  </ol>
</details>

---

<!-- ABOUT THE PROJECT -->

# Overview

This package was originally started in 2018 as a hobby project and used in a couple of game jams as well as a number of side projects. I've used it in animation curves, pathfinding and integration with other Unity projects. At it's core, this project is based on the absolutely fabulous guides written by [Catlike Coding](https://catlikecoding.com/).  

The goals for this project were:
- Create an API for generating geometries
- Make a simple and intuitive editor 
- Serialize generated data
- Drag and drop this project and/or serialized data into another project

<p align="right">(<a href="#readme-top">back to top</a>)</p>

# Built With
- JetBrains Rider
- Unity 2021.1.27f1 (upgraded to this version)
- Odin Inspector

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- GETTING STARTED -->
# Getting Started

1) Create an empty game object
2) Add a Line2D, Curve2D or Spline2D component depending on your needs
	![[Pasted image 20240122080458.png]]
	![[Pasted image 20240122080359.png]]
	![[Pasted image 20240122080433.png]]
3) For serializing & deserializing data, add a PolyMonoHook component
	![[Pasted image 20240122080620.png]]
<p align="right">(<a href="#readme-top">back to top</a>)</p>


# Prerequisites and Dependencies

- Unity 2021.1.27f1 (upgraded to this version)
- JetBrains Rider or Microsoft Visual Studio
- For a more modernized inspector, any version of [Odin Inspector](https://odininspector.com/)

##### Please feel free to contact me with any issues or concerns in regards to the dependencies defined above. We can work around the majority of them if needed.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

# Installation

- Clone or fork this repository. Once done, add a reference to this library in your project
- Download the latest dll and create a reference to it in your project
- Install via UPM

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->
# Usage

#### It will help to disable your skybox temporarily while working with these components

#### After you add a component to a new game object, ensure 'Gizmos' are toggled on and then select this game object. This will make the scene gizmos visible.
![[Pasted image 20240122082855.png]]

##### Line2D

The Line2D inspector will look like the following:
![[Pasted image 20240122081055.png]]


The Line2D gizmos initially look like the following:
![[Pasted image 20240122082710.png]]

- Settings
	- Name: used as an identifier for serialized data
	- Labels: whether or not to display labels in your scene
		- Toggled ON
			![[Pasted image 20240122083143.png]]
		- Toggled OFF
			![[Pasted image 20240122083213.png]]
	- Tangent Lines: no effect when toggled for Line2D component
	- Root Handles: toggles gizmo to move the components transform
		- Root handle arbitrarily starts at point '0'
		- Toggled ON
			![[Pasted image 20240122204412.png]]
		- Toggled OFF
			![[Pasted image 20240122204324.png]]
- Settings Buttons
	- Reset Root Position: will reset the game object's transform position to (0,0,0). Use this if you've changed the object's position and want to simply reset it to '0'.
	- Reset Root Rotation: will reset the game object's transform rotation to (0,0,0). Use this if you've changed the object's rotation and want to simply reset it to '0'.
	- Reset Root Scale: will reset the game object's transform scale to (1,1,1). Use this if you've changed the object's rotation and want to simply reset it to '1'.

- Polynomial Shape
	- Points: a serialized list containing all point you've added. For a Line2D component, this will only be two points: 'start' and 'end'.

- Point Extraction
	- Steps: will add a set of interpolated points between the 'start' point and 'end' point of your line. The use case for this is to and intermediary points that can be used (for example) to randomly stop a patrolling character when moving between 'start' and 'end'.
	- Auto Update: when toggled ON, this will automatically recalculate the 'steps' between 'start' and 'end'. When toggled OFF, you are free to change the 'steps' setting without a recalculation of the interpolated points. Saving the points will recalculate the interpolated points.
	- Point Radius: the size of the points gizmo within your scene. This setting is solely for visibility.
	- Extracted Point: a list of the points containing your 'start', 'end' and all 'steps'. This is the data that is serialized and deserialized.

- Colors
	- Spline Color: the color of the line, curve or spline gizmo
	- Points Color: the color of the points gizmo.

##### Curve2D

The Curve2D inspector will look like the following:
![[Pasted image 20240124072237.png]]


The Curve2D gizmos initially look like the following for a quadratic curve:
![[Pasted image 20240124072314.png]]

And like the following for a cubic curve:
![[Pasted image 20240124072409.png]]

- Settings
	- Name: used as an identifier for serialized data
	- Polynomial
		- Quadratic: instantiates a new polynomial that is quadratic in nature. This creates a single tangent point for you to modify.
		- Cubic: instantiates a new polynomial that is cubic in nature. This creates two tangent points for you to modify.
	- Labels: whether or not to display labels in your scene
		- Toggled ON
			![[Pasted image 20240122083143.png]]
		- Toggled OFF
			![[Pasted image 20240122083213.png]]
	- Tangent Lines: toggles the display of tangent lines
		- ON
			![[Pasted image 20240124072905.png]]
		- OFF
			![[Pasted image 20240124072935.png]]
	- Tangent Handles: clicking a tangent point will bring up a transform gizmo that allows you to move the point(s) around as you see fit. ![[tangent-demonstration.gif]]
	- Root Handles: toggles gizmo to move the components transform
		- Root handle arbitrarily starts at point '0'
		- Toggled ON
			![[Pasted image 20240122204412.png]]
		- Toggled OFF
			![[Pasted image 20240122204324.png]]
- Settings Buttons
	- Reset Root Position: will reset the game object's transform position to (0,0,0). Use this if you've changed the object's position and want to simply reset it to '0'.
	- Reset Root Rotation: will reset the game object's transform rotation to (0,0,0). Use this if you've changed the object's rotation and want to simply reset it to '0'.
	- Reset Root Scale: will reset the game object's transform scale to (1,1,1). Use this if you've changed the object's rotation and want to simply reset it to '1'.

- Polynomial Shape
	- Points: a serialized list containing all point you've added. 
	- For a Curve2D quadratic component, there will be three points: 'start', 'end' and 'tangent'. 
	- For a Curve2D cubic, there will be four points: 'start', 'end', tangent1' and 'tangent2'. 
	- These points can be moved via gizmos or directly setting their positions within the inspector.

- Point Extraction
	- Steps: will add a set of interpolated points between the 'start' point and 'end' point of your line. The use case for this is to and intermediary points that can be used (for example) to randomly stop a patrolling character when moving between 'start' and 'end'.
	- Auto Update: when toggled ON, this will automatically recalculate the 'steps' between 'start' and 'end'. When toggled OFF, you are free to change the 'steps' setting without a recalculation of the interpolated points. Saving the points will recalculate the interpolated points.
	- Point Radius: the size of the points gizmo within your scene. This setting is solely for visibility.
	- Extracted Point: a list of the points containing your 'start', 'end' and all 'steps'. This is the data that is serialized and deserialized.

- Colors
	- Spline Color: the color of the line, curve or spline gizmo
	- Points Color: the color of the points gizmo.

##### Spline2D

- Spline is the most versatile and flexible component to work with.

The Spline2D inspector will look like the following:
![[Screenshot 2024-01-29 082314.png]]


The Spline2D gizmos initially look like the following with no additional points or curves added:
![[Screenshot 2024-01-29 082457.png]]

And like the following when additional points and curves are added:
![[Screenshot 2024-01-29 082635.png]]

- Settings
	- Name: used as an identifier for serialized data
	- Labels: whether or not to display labels in your scene
		- Toggled ON
			![[Pasted image 20240122083143.png]]
		- Toggled OFF
			![[Pasted image 20240122083213.png]]
	- Tangent Lines: toggles the display of tangent lines
		- ON
			![[Pasted image 20240124072905.png]]
		- OFF
			![[Pasted image 20240124072935.png]]
	- Loop Spline: 'YES' forces the spline to be a closed shape. 'NO' allows for an opened ended spline
		- When toggled 'YES':
			![[Screenshot 2024-01-29 082750.png]]
	- Root Handles: toggles gizmo to move the components transform
		- Root handle arbitrarily starts at point '0'
		- Toggled ON
			![[Pasted image 20240122204412.png]]
		- Toggled OFF
			![[Pasted image 20240122204324.png]]
- Settings Buttons
	- Reset Root Position: will reset the game object's transform position to (0,0,0). Use this if you've changed the object's position and want to simply reset it to '0'.
	- Reset Root Rotation: will reset the game object's transform rotation to (0,0,0). Use this if you've changed the object's rotation and want to simply reset it to '0'.
	- Reset Root Scale: will reset the game object's transform scale to (1,1,1). Use this if you've changed the object's rotation and want to simply reset it to '1'.

- Polynomial Shape
	- Curved Connections
		![[Screenshot 2024-01-29 083002.png]]
	- Curve connections affect how each adjacent tangent interacts with each other. There are three choices: free, aligned and mirrored. 
	- An adjacent tangent is defined in ascending order; meaning tangent 1 -> tangent 2, tangent 2 -> tangent 3 and so on.
		- If 'Loop Spline' is toggled to 'YES', then the final tangent's adjacent will be tangent 1.
			- I.E. if the final tangent is tangent 8, then tangent 8 -> tangent 1
	- Free: free breaks adjacency. It allows the selected tangent to be transformed freely. The adjacent tangent will not be change  with this option.

- Point Extraction
	- Steps: will add a set of interpolated points between the 'start' point and 'end' point of your line. The use case for this is to and intermediary points that can be used (for example) to randomly stop a patrolling character when moving between 'start' and 'end'.
	- Auto Update: when toggled ON, this will automatically recalculate the 'steps' between 'start' and 'end'. When toggled OFF, you are free to change the 'steps' setting without a recalculation of the interpolated points. Saving the points will recalculate the interpolated points.
	- Point Radius: the size of the points gizmo within your scene. This setting is solely for visibility.
	- Extracted Point: a list of the points containing your 'start', 'end' and all 'steps'. This is the data that is serialized and deserialized.

- Colors
	- Spline Color: the color of the line, curve or spline gizmo
	- Points Color: the color of the points gizmo.

<!-- ROADMAP -->
# Roadmap

There is currently no future features planned.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTRIBUTING -->
# Contributing

Contributions are absolutely welcome. This is an open source project. 

1. Fork the repository
2. Create a feature branch
```Shell
git checkout -b feature/your-feature-branch
```
3. Commit changes on your feature branch
```Shell
git commit -m 'Summary feature'
```
4. Push your changes to your branch
```Shell
git push origin feature/your-feature-branch
```
5. Open a pull request to merge/incorporate your feature

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->
# License

Distributed under the MIT License.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- CONTACT -->
# Contact

<p align="center">
<b><u>RyanIO</u></b> 
<br/><br/> 
<a href = "mailto:ryan.io@programmer.net?subject=[RIO]%20Procedural%20Generator%20Project" >[Email]</a>
<br/>
[LinkedIn]
<br/>
<a href="https://github.com/ryan-io">[GitHub]</a></p>

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ACKNOWLEDGMENTS -->
# Acknowledgments and Credit

* [Stephen Cleary's Blog](https://blog.stephencleary.com/)
	* In particular, his blog on [Async Events in OOP](https://blog.stephencleary.com/2013/02/async-oop-5-events.html) provided me with inspiration for this.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/github_username/repo_name.svg?style=for-the-badge
[contributors-url]: https://github.com/github_username/repo_name/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/github_username/repo_name.svg?style=for-the-badge
[forks-url]: https://github.com/github_username/repo_name/network/members
[stars-shield]: https://img.shields.io/github/stars/github_username/repo_name.svg?style=for-the-badge
[stars-url]: https://github.com/github_username/repo_name/stargazers
[issues-shield]: https://img.shields.io/github/issues/github_username/repo_name.svg?style=for-the-badge
[issues-url]: https://github.com/github_username/repo_name/issues
[license-shield]: https://img.shields.io/github/license/github_username/repo_name.svg?style=for-the-badge
[license-url]: https://github.com/github_username/repo_name/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/linkedin_username
[product-screenshot]: images/screenshot.png
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com
