
# react-native-cloverleaf-parking-service

## Getting started

`$ npm install react-native-cloverleaf-parking-service --save`

### Mostly automatic installation

`$ react-native link react-native-cloverleaf-parking-service`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-cloverleaf-parking-service` and add `RNCloverleafParkingService.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNCloverleafParkingService.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNCloverleafParkingServicePackage;` to the imports at the top of the file
  - Add `new RNCloverleafParkingServicePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-cloverleaf-parking-service'
  	project(':react-native-cloverleaf-parking-service').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-cloverleaf-parking-service/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-cloverleaf-parking-service')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNCloverleafParkingService.sln` in `node_modules/react-native-cloverleaf-parking-service/windows/RNCloverleafParkingService.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Cloverleaf.Parking.Service.RNCloverleafParkingService;` to the usings at the top of the file
  - Add `new RNCloverleafParkingServicePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNCloverleafParkingService from 'react-native-cloverleaf-parking-service';

// TODO: What to do with the module?
RNCloverleafParkingService;
```
  