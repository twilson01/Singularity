---------------------------------------------------------------------------
 SPACEBOX 4096 - BLUE CLUSTERS
---------------------------------------------------------------------------

 HOW TO USE:

 Method 1 - Global Settings
 1. Go to Edit --> Render Settings
 2. Drag the material "Spacebox-Bright" to Skybox Material in the Inspector

 Method 2 - Camera Specific
 1. Select your Camera and then click Component --> Rendering --> Skybox
 2. Drag the material "Spacebox-Bright" to Custom Skybox in the Inspector


 HOW TO TEST:

 By default the camera is static so you'll only see a static image when you
 play. You can test the skybox by importing the standard Unity package named
 "Character Controller" and applying the "MouseLook" script (located in the
 folder "Standard Assets\Sources\Scripts") to your camera.


 ** IMPORTANT NOTE ABOUT THE RESOLUTION **

 The textures are provided in the highest resolution possible where each texture
 is 4096x4096 pixels in size. 

 To avoid problems for some users with lower end computers the "Max Size"
 for the textures are set to 1024 in Unity - follow the instructions below to
 increase the resolution!

 Higher resolution may especially be necessary for high end games and if
 camera Field of View (FOV) is low as lower resolution textures will look very
 blurred at a low FOV. 

 Size estimation for distribution (using Standard Unity DXT1 compression):
 * One skybox with 4096x4096 textures use approx. 64MB
 * One skybox with 2048x2048 textures use approx. 16MB
 * One skybox with 1024x1024 textures use approx. 8MB

 HOW TO INCREASE RESOLUTION:

 1. In Hierarchy, select a texture in the Texture folder
 2. In Inspector, change Max Size from 1024 to desired size and click apply
 3. Repeat this process for each texture

---------------------------------------------------------------------------
 Official Web Site: http://soundtrack.imphenzia.com
---------------------------------------------------------------------------
 Copyright 2011 Stefan Persson - Imphenzia Soundtrack
---------------------------------------------------------------------------
