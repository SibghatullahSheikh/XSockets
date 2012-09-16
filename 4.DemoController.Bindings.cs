using System.Collections.Generic;
using System.Diagnostics;
using XSockets.Core.XSocket.Event.Attributes;
using XSockets.Core.XSocket.Event.Interface;

namespace XSocketHandler.Tutorial
{
    /// <summary>
    /// Model binding.
    /// </summary>
    public partial class DemoController
    {
        /// <summary>
        /// To hit this method trigger a event named 'noBinding'
        /// and pass in JSON = {}
        /// </summary>
        [HandlerEvent("noBinding")]
        public void Demo0()
        {
            Debug.WriteLine("noBinding");
            Debug.WriteLine("triggered without any parameters");
            Debug.WriteLine("");
        }

        /// <summary>
        /// Will be triggered if the event is named 'hellome'
        /// </summary>
        /// <param name="args"></param>
        [HandlerEvent("defaultBinding")]
        public void Demo1(ITextArgs args)
        {
            Debug.WriteLine("DefaultBinding");
            Debug.WriteLine("Event:{0}, Data:{1}", args.@event, args.data);
            Debug.WriteLine("");
        }

        /// <summary>
        /// To hit this method trigger a event named 'parameterBinding'
        /// and pass in JSON = {number:123, text:'some text'}
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        [HandlerEvent("parameterBinding")]
        public void Demo2(int number, string text)
        {
            Debug.WriteLine("ParameterBinding");
            Debug.WriteLine("Text:{0}, Number:{1}", text, number);
            Debug.WriteLine("");
        }

        [HandlerEvent("singleParameterBinding")]
        public void Demo2_1(int number)
        {
            Debug.WriteLine("SingleParameterBinding");
            Debug.WriteLine("Number:{0}", number);
            Debug.WriteLine("");
        }

        /// <summary>
        /// To hit this method trigger a event named 'modelBinding'
        /// and pass in JSON = {age:35,Name:'Sidney Kwanza'}
        /// </summary>
        /// <param name="person"></param>
        [HandlerEvent("modelBinding")]
        public void Demo3(Person person)
        {
            Debug.WriteLine("ModelBinding");
            Debug.WriteLine("Age:{0}, Name:{1}", person.Age, person.Name);
            Debug.WriteLine("");
        }

        /// <summary>
        /// To hit this method trigger a event named 'modelBinding'
        /// and pass in JSON = { Name: 'Uffe', Age: 35, Skills: [{ Name: 'C#', Level: 5 }, { Name: 'JavaScript', Level: 5 }] }}
        /// </summary>
        /// <param name="person"></param>
        [HandlerEvent("modelBindingComplex")]
        public void Demo31(Person person)
        {
            Debug.WriteLine("ModelBinding");
            Debug.WriteLine("Age:{0}, Name:{1}", person.Age, person.Name);
            foreach (var skill in person.Skills)
            {
                Debug.WriteLine("Skill:{0}, Level:{1}", skill.Name, skill.Level);
            }
            Debug.WriteLine("");
        }

        /// <summary>
        /// A combination of strongly typed and parameters.
        /// To hit this method trigger a event named 'modelAndParameterBinding'
        /// and pass in JSON = {person:{Name:'Sidney',Age:35},number:123,text:'xsockets'}
        /// NOTE: The order of your JSON object will not matter, it will be serialized into the order the serverside needs it.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="number"></param>
        /// <param name="text"></param>
        [HandlerEvent("modelAndParameterBinding")]
        public void Demo4(int number, Person person, string text)
        {
            Debug.WriteLine("ModelAndParameterBinding");
            Debug.WriteLine("Text:{0}, Number:{1}", text, number);
            Debug.WriteLine("Age:{0}, Name:{1}", person.Age, person.Name);
            Debug.WriteLine("");
        }

        /// <summary>
        /// To hit this method trigger a event named 'modelBinding'
        /// and pass in JSON = {person:{age:35,Name:'Sidney Kwanza',Skills:[{Name:'C#',Level:3},{Name:'Java',Level:4}]},number:123,text:'xsockets'}
        /// NOTE: The order of your JSON object will not matter, it will be serialized into the order the serverside needs it.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="number"> </param>
        /// <param name="text"> </param>
        [HandlerEvent("modelAndParameterBindingComplex")]
        public void Demo41(int number, string text, Person person)
        {
            Debug.WriteLine("ModelBinding");
            Debug.WriteLine("Text:{0}, Number:{1}", text, number);
            Debug.WriteLine("Age:{0}, Name:{1}", person.Age, person.Name);
            foreach (var skill in person.Skills)
            {
                Debug.WriteLine("Skill:{0}, Level:{1}", skill.Name, skill.Level);
            }
            Debug.WriteLine("");
        }

        /// <summary>     
        /// To hit this method trigger a event named 'modelBindingList'
        /// and pass in JSON = [{Name:'Sidney',Age:30},{Name:'Uffe',Age:35},{Name:'Magnus',Age:38}]
        /// </summary>
        [HandlerEvent("modelBindingList")]
        public void Demo5(IList<Person> people)
        {
            Debug.WriteLine("ModelBindingList");
            foreach (var person in people)
            {
                Debug.WriteLine("Age:{0}, Name:{1}", person.Age, person.Name);
            }
            Debug.WriteLine("");
        }

        
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IList<Skill> Skills { get; set; }
    }

    public class Skill
    {
        public string Name { get; set; }
        public int Level { get; set; }
    }
}
