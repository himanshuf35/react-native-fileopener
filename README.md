
# react-native-file-opener

## Getting started

`$ npm install react-native-file-opener --save`

### Mostly automatic installation

`$ react-native link react-native-file-opener`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-file-opener` and add `RNFileOpener.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNFileOpener.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNFileOpenerPackage;` to the imports at the top of the file
  - Add `new RNFileOpenerPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-file-opener'
  	project(':react-native-file-opener').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-file-opener/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-file-opener')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNFileOpener.sln` in `node_modules/react-native-file-opener/windows/RNFileOpener.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using File.Opener.RNFileOpener;` to the usings at the top of the file
  - Add `new RNFileOpenerPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNFileOpener from 'react-native-file-opener';

// TODO: What to do with the module?
RNFileOpener;
```
  