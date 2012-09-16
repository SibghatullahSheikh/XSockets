using XSockets.Core.XSocket.Event.Arguments;
using XSockets.Core.XSocket.Event.Attributes;

namespace XSocketHandler.Tutorial
{
    /// <summary>
    /// Create your own eventhandlers with the HandlerEvent attribute.
    /// </summary>
    public partial class DemoController
    {
        /// <summary>
        /// Will be triggered if the event is named 'hellome'
        /// You can ofcourse pass in parameters, shown in DemoController.Bindings
        /// </summary>
        [HandlerEvent("HelloMe")]
        public void OnHelloMeMessage()
        {
            //Send a message back to the caller
            this.Send(new { Message = "Hello Me From XSockets.NET" }.AsTextArgs("HelloMe"));
        }
    }
}
