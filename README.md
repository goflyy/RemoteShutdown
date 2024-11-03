# RemoteShutdown Suite

**RemoteShutdown Suite** is a set of applications that enables remote control of a computer from a mobile device. The project consists of two main parts:
- **RemoteShutdownAPI** – an ASP.NET Core API server that receives requests and performs a specified action (e.g., creating a file as a test instead of shutting down).
- **RemoteShutdownApp** – a mobile application built with .NET MAUI that sends requests to the API server, enabling remote control.

## Repository Contents

- **RemoteShutdownAPI**: An ASP.NET Core Web API that listens for HTTP POST requests to trigger an action on the computer.
- **RemoteShutdownApp**: A mobile application built with .NET MAUI, allowing you to send requests to the API from a mobile device (iOS/Android).

## Features

### RemoteShutdownAPI
- **File creation on the computer** – The API accepts a POST request and responds by creating a `shutdown_log.txt` file in the project directory, logging the date and time of the action.
- **Safe testing** – Instead of shutting down the computer, the API creates a file, enabling safe testing without interrupting the system.

### RemoteShutdownApp
- **Mobile interface** – The app provides a simple interface with a button to send a POST request to the API server.
- **iOS and Android support** – The app runs on both iOS and Android devices, thanks to .NET MAUI.

## Requirements

- **RemoteShutdownAPI**:
  - .NET 6 SDK or later
  - Windows OS (for testing functionality)
  
- **RemoteShutdownApp**:
  - Visual Studio 2022 with .NET MAUI (on Windows or macOS)
  - iOS or Android device (or simulator)

## Installation and Setup

### RemoteShutdownAPI

1. Clone the repository:
   ```bash
   git clone https://github.com/goflyy/RemoteShutdownSuite.git

2. Navigate to the RemoteShutdownAPI directory:
   cd RemoteShutdownSuite/RemoteShutdownAPI

3.Run the API:
  dotnet run --urls "http://0.0.0.0:5262"

4. The API will be listening on port 5262. Ensure that the Windows Firewall allows incoming connections on this port.


### RemoteShutdownApp
Open the RemoteShutdownApp folder in Visual Studio.
Configure the project to send requests to the IP address of the computer running the API, e.g., http://[Computer IP]:5262/api/shutdown.
Run the application on a mobile device or simulator.

### Usage
Start RemoteShutdownAPI on the computer you want to control remotely.
Open RemoteShutdownApp on your mobile device.
Tap the Send Shutdown Request button in the mobile app to send a POST request to the API.
Check the API application directory – a file named shutdown_log.txt should appear, containing the date and time of the request.

### Future Features
Adding a real shutdown functionality after successful testing.
Implementing authorization in the API to secure requests.
Expanding the mobile app with additional control options.
License

