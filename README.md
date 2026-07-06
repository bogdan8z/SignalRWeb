# Real-Time Notifications with SignalR

A minimal ASP.NET Core application demonstrating real-time notifications using SignalR.

## Overview

This sample app uses SignalR to broadcast messages from either:

- the backend API (`POST /message`) with a `new messages` event
- the frontend test page (`wwwroot/testSignalR.html`) with a `refresh-list` event

## Features

- ASP.NET Core SignalR hub implementation
- HTTP endpoint for sending hub messages
- static test page for client-side SignalR messaging
- lightweight .NET 6.0 setup

## Prerequisites

- .NET 6 SDK installed
- a browser to open `wwwroot/testSignalR.html`

## Run locally

1. Open the repository folder in a terminal.
2. Run the app:

```bash
dotnet run
```

3. Open the browser and navigate to the app URL shown in the terminal.

## Usage

### Backend message flow

Send a POST request to the message endpoint:

```bash
curl -X POST http://localhost:5000/message \
  -H "Content-Type: application/json" \
  -d '{"message":"Hello from backend"}'
```

This sends a SignalR event with the title `new messages`.

### Frontend test page

Open `wwwroot/testSignalR.html` in your browser. Use the `Send Message` button to dispatch a SignalR message from the client. That action sends an event with the title `refresh-list`.

## Project structure

- `Program.cs` – ASP.NET Core startup and SignalR configuration
- `SignalR/MessagesHub.cs` – SignalR hub implementation
- `Controllers/MessageController.cs` – API endpoint for backend messages
- `wwwroot/testSignalR.html` – simple client-side SignalR test page
- `Model/MessageModel.cs` – message request model

## Notes

- The app is built for demonstration and learning, not production use.
- Adjust the hub client method names as needed when integrating into a real application.

## Useful links

- [Tutorial: Get started with ASP.NET Core SignalR](https://learn.microsoft.com/en-us/aspnet/core/tutorials/signalr?view=aspnetcore-7.0&tabs=visual-studio)
- [Understanding SignalR From Scratch](https://www.c-sharpcorner.com/article/understanding-signalr-from-scratch/)
- [Introduction to SignalR](https://learn.microsoft.com/en-us/aspnet/signalr/overview/getting-started/introduction-to-signalr)
- [Tutorial: Real-time chat with SignalR 2](https://learn.microsoft.com/en-us/aspnet/signalr/overview/getting-started/tutorial-getting-started-with-signalr)
- [SignalR / WebSocket Concepts : in ASP.NET Core 3.1 ](https://dev.to/jwp/asp-net-core-3-1-websocket-concepts-4018)
- [Creating a chatroom using WebSockets and SignalR](https://insights.it-minds.dk/tech/creating-a-chatroom-using-websockets-and-signalr)
- [ASP.NET Core SignalR JavaScript client](https://learn.microsoft.com/en-us/aspnet/core/signalr/javascript-client?view=aspnetcore-7.0&tabs=visual-studio)
- [ASP.NET Core SignalR & SignalR Debugging Tool](https://medium.com/@dwivedi.gourav/asp-net-core-signalr-signalr-debugging-tool-a82dc5230035)
- [Building Real-Time Applications With SignalR & .NET 7](https://www.youtube.com/watch?v=9_pRk7PwkpY)
- [Test your hub](https://gourav-d.github.io/SignalR-Web-Client/dist)