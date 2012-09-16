using XSockets.Core.XSocket.Event.Attributes;
using XSockets.Core.XSocket.Event.Interface;
using XSockets.Core.XSocket.Helpers;

namespace XSocketHandler.Tutorial
{
    /// <summary>
    /// Sending data...
    /// We can send JSON, Object, ITextArgs or IBinaryArgs
    /// This means we can send 
    /// - pure JSON, 
    /// - any object (strongly typed or anonymous)
    /// - the built in ITextArgs
    /// - the built in IBinaryArgs
    /// </summary>
    public partial class DemoController
    {
        /// <summary>
        /// Will be triggered if the event is named 'hellome'
        /// </summary>
        /// <param name="args"></param>
        [HandlerEvent("sendDefaultBinding")]
        public void Demo7(ITextArgs args)
        {
            //Will just return the argument passed in to the client that sent the data
            this.Send(args);
        }

        /// <summary>
        /// To hit this method trigger a event named 'parameterBinding'
        /// and pass in JSON = {number:123, text:'some text'}
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        [HandlerEvent("sendParameterBinding")]
        public void Demo8(int number, string text)
        {
            
        }

        ///// <summary>
        ///// To hit this method trigger a event named 'modelBinding'
        ///// and pass in JSON = {age:35,Name:'Sidney Kwanza'}
        ///// </summary>
        ///// <param name="person"></param>
        //[HandlerEvent("modelBinding")]
        //public void Demo3(Person person)
        //{
        //    Debug.WriteLine("ModelBinding");
        //    Debug.WriteLine("Age:{0}, Name:{1}", person.Age, person.Name);
        //    Debug.WriteLine("");
        //}

        ///// <summary>
        ///// To hit this method trigger a event named 'modelBinding'
        ///// and pass in JSON = { Name: 'Uffe', Age: 35, Skills: [{ Name: 'C#', Level: 5 }, { Name: 'JavaScript', Level: 5 }] }}
        ///// </summary>
        ///// <param name="person"></param>
        //[HandlerEvent("modelBindingComplex")]
        //public void Demo31(Person person)
        //{
        //    Debug.WriteLine("ModelBinding");
        //    Debug.WriteLine("Age:{0}, Name:{1}", person.Age, person.Name);
        //    foreach (var skill in person.Skills)
        //    {
        //        Debug.WriteLine("Skill:{0}, Level:{1}", skill.Name, skill.Level);
        //    }
        //    Debug.WriteLine("");
        //}

        ///// <summary>
        ///// A combination of strongly typed and parameters.
        ///// To hit this method trigger a event named 'modelAndParameterBinding'
        ///// and pass in JSON = {person:{Name:'Sidney',Age:35},number:123,text:'xsockets'}
        ///// NOTE: The order of your JSON object will not matter, it will be serialized into the order the serverside needs it.
        ///// </summary>
        ///// <param name="person"></param>
        ///// <param name="number"></param>
        ///// <param name="text"></param>
        //[HandlerEvent("modelAndParameterBinding")]
        //public void Demo4(int number, Person person, string text)
        //{
        //    Debug.WriteLine("ModelAndParameterBinding");
        //    Debug.WriteLine("Text:{0}, Number:{1}", text, number);
        //    Debug.WriteLine("Age:{0}, Name:{1}", person.Age, person.Name);
        //    Debug.WriteLine("");
        //}

        ///// <summary>
        ///// To hit this method trigger a event named 'modelBinding'
        ///// and pass in JSON = {person:{age:35,Name:'Sidney Kwanza',Skills:[{Name:'C#',Level:3},{Name:'Java',Level:4}]},number:123,text:'xsockets'}
        ///// NOTE: The order of your JSON object will not matter, it will be serialized into the order the serverside needs it.
        ///// </summary>
        ///// <param name="person"></param>
        ///// <param name="number"> </param>
        ///// <param name="text"> </param>
        //[HandlerEvent("modelAndParameterBindingComplex")]
        //public void Demo41(int number, string text, Person person)
        //{
        //    Debug.WriteLine("ModelBinding");
        //    Debug.WriteLine("Text:{0}, Number:{1}", text, number);
        //    Debug.WriteLine("Age:{0}, Name:{1}", person.Age, person.Name);
        //    foreach (var skill in person.Skills)
        //    {
        //        Debug.WriteLine("Skill:{0}, Level:{1}", skill.Name, skill.Level);
        //    }
        //    Debug.WriteLine("");
        //}

        ///// <summary>     
        ///// To hit this method trigger a event named 'modelBindingList'
        ///// and pass in JSON = [{Name:'Sidney',Age:30},{Name:'Uffe',Age:35},{Name:'Magnus',Age:38}]
        ///// </summary>
        //[HandlerEvent("modelBindingList")]
        //public void Demo5(IList<Person> people)
        //{
        //    Debug.WriteLine("ModelBindingList");
        //    foreach (var person in people)
        //    {
        //        Debug.WriteLine("Age:{0}, Name:{1}", person.Age, person.Name);
        //    }
        //    Debug.WriteLine("");
        //}

        ///// <summary>
        ///// NOTE: It´s not possible to debug.writeline dynamics, but set a breakpoint and you´ll see 
        ///// that the dynamic will reflect your json whatever you send in.
        ///// </summary>
        ///// <param name="json"></param>
        //[HandlerEvent("dynamicBinding")]
        //public void Demo6(dynamic json)
        //{
        //    //var jsonString = XSocketHelper.Serialize(json);
        //    Debug.WriteLine("dynamicBinding");

        //    //Debug.WriteLine(jsonString);
        //    foreach (var d in (Dictionary<string, dynamic>)(json))
        //    {
        //        //Debug.WriteLine("Key:{0}, Value:{1}", d.Key, d.Value.ToString());                
        //    }
        //    Debug.WriteLine("");
        //}
    }
}
