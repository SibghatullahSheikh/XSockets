# XSockets.NET - Stockticker

XSockets.NET is a realtime communication platform that runs on .NET 4.0 and Mono.
XSockets.NET is available on [nuget](http://nuget.org/packages/xsockets)

## About this sample...
This sample is based on the SignalR [stockticker][1] sample built by Damien Edwards.
We took all code from that sample and replaced the hub from SignalR with a XSockets controller. One difference between the samples is that you can stop listening for stocks in the XSockets sample. This is easily done since XSockets only send to clients that are subscribers. 


  [1]: http://www.asp.net/signalr/overview/getting-started/tutorial-server-broadcast-with-aspnet-signalr