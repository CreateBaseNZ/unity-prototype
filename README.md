# unity-prototype
## Installation and Setup
### Unity Installation
1. Download and install Unity Hub https://unity3d.com/get-unity/download
2. Within Unity Hub, navigate to the _Installs_ tab and click _Add_
3. Select Unity version _2020.3.xf1 (LTS)_ and click _Next_
4. Include the module _WebGL Build Support_ and click _Done_

### Project setup
1. Clone this repository, and find the project folder within Unity Hub.
2. Within the _Projects_ tab in Unity Hub, click _Add Project_ and select the cloned folder.
3. Select the latest Unity version you have available. Make sure it is version _2020.3.xf1 (LTS)_
4. Change the target platform to WebGL.

### Unity WebGL Build
1. Within the Unity editor navigate to _File -> Build Settings..._
2. Choose build settings before clicking _Build and Run_.

## WebGL: Interacting with browser scripting
A Unity instance can be attatched to a canvas through the following code:
```
var myGameInstance = null;
  script.onload = () => {
    createUnityInstance(canvas, config, (progress) => {...}).then((unityInstance) => {
      myGameInstance = unityInstance;
```
### Calling Unity scripts functions from JavaScript
Unity functions may be called through javascript through the following code:
```
unityInstance.SendMessage(objectName, methodName, value);
```
Where **objectName** is the name of an object in your scene; **methodName** is the name of a method in the script, currently attached to that object; **value** can be a string, a number, or can be empty. For example:

```
unityInstance.SendMessage('MyGameObject', 'MyFunction');
unityInstance.SendMessage('MyGameObject', 'MyFunction', 5);

unityInstance.SendMessage('MyGameObject', 'MyFunction', 'MyString');
```
