
# react-native-billards-tournament

## Getting started

`$ npm install react-native-billards-tournament --save`

### Mostly automatic installation

`$ react-native link react-native-billards-tournament`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-billards-tournament` and add `RNBillardsTournament.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBillardsTournament.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBillardsTournamentPackage;` to the imports at the top of the file
  - Add `new RNBillardsTournamentPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-billards-tournament'
  	project(':react-native-billards-tournament').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-billards-tournament/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-billards-tournament')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBillardsTournament.sln` in `node_modules/react-native-billards-tournament/windows/RNBillardsTournament.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Billards.Tournament.RNBillardsTournament;` to the usings at the top of the file
  - Add `new RNBillardsTournamentPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBillardsTournament from 'react-native-billards-tournament';

// TODO: What to do with the module?
RNBillardsTournament;
```
  