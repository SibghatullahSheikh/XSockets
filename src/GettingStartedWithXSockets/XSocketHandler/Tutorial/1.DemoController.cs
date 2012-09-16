using XSockets.Core.Globals;
using XSockets.Core.XSocket;
using XSockets.Core.XSocket.Interface;
using XSockets.Plugin.Framework.Attributes;

namespace XSocketHandler.Tutorial
{
    //Export so that the class can be detected by the plugin framework
    [Export(typeof(IXBaseSocket))]
    //Set the Alias -> MyXSocketController could be named anything
    //The Alias is the name you will connect to
    [XBaseSocketMetadata("Demo", Constants.GenericTextBufferSize)]
    //We would probably name the class the same thing as the Alias, but we dont just to show that it doesnt matter
    public partial class DemoController : XBaseSocket
    {
        /// <summary>
        /// This is a custom property that will be used for filtering etc
        /// </summary>
        public string UserName { get; set; }
     
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
}
