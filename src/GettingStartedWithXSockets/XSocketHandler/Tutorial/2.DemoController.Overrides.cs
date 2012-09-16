using XSockets.Core.XSocket.Interface;

namespace XSocketHandler.Tutorial
{
    /// <summary>
    /// Example of howto override methods for messages in the baseclass.
    /// </summary>
    public partial class DemoController
    {
        /// <summary>
        /// Override all incomming text messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void IncommingText(IXBaseSocket sender, XSockets.Core.XSocket.Event.Interface.ITextArgs e)
        {
            base.IncommingText(sender, e);
        }

        /// <summary>
        /// Override all incomming binary messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void IncommingBinary(IXBaseSocket sender, XSockets.Core.XSocket.Event.Interface.IBinaryArgs e)
        {
            base.IncommingBinary(sender, e);
        }

        /// <summary>
        /// Override all error messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void HandleError(object sender, XSockets.Core.XSocket.Event.Arguments.OnErrorArgs e)
        {
            base.HandleError(sender, e);
        }
    }
}
