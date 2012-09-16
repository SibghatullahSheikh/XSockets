# XSockets.NET - Examples

XSockets.NET is a realtime communication platform.
XSockets.NET is available on [nuget](http://nuget.org/packages/xsockets)
This examples will show you the basics in XSockets.NET JavaScript API and the server side API for building plugins.

## JavaScript - A first example...

Send a custom message with an event named "mytest" to the server.
    
    ws.trigger('mytest',{Message:'Hello World'});
    
Listen for the 'mytest' message
    
    ws.bind('mytest',function(data){
        console.log(data);
    });
    
## C# - A first example

If you do not listen for messages (or intercept them) on the server, they will pass right through and will be sent to everyone listening for them.
But here we show howto create a simple plugin intercepting our 'mytest' message.

    //Export so that the class can be detected by the plugin framework
    [Export(typeof(IXBaseSocket))]
    //Set the Alias -> MyXSocketController could be named anything
    //The Alias is the name you will connect to
    [XBaseSocketMetadata("Demo", Constants.GenericTextBufferSize)]
    //We would probably name the class the same thing as the Alias, but we dont just to show that it doesnt matter
    public partial class DemoController : XBaseSocket
    {

	/// <summary>
        /// To hit this method trigger a event named 'mytest'
        /// and pass in JSON = {Message:'your message'}
        /// </summary>
        /// <param name="Message"></param>
        [HandlerEvent("mytest")]
        public void DemoMyTest(string Message)
        {
            Debug.WriteLine("SingleParameterBinding");
            Debug.WriteLine("Message:{0}", Message);
            Debug.WriteLine("");

            //Will send the message to all clients listening.
            this.SendToAll(new {Message=Message},"mytest");
        }
     
        /// <summary>
        /// This method is required since its abstract in XBaseSocket
        /// </summary>
        /// <returns></returns>
        public override IXBaseSocket NewInstance()
        {
            //Return a new instance of your plugin.
            return new DemoController();
        }
    }

## A working project...

You can download the project found under the src directory and try more examples.