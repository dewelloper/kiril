using System;

namespace Markum.Cloud.BusinessObjects.Attributes
{
    public class SolusVmQueryAttribute : Attribute
    {
        public string Name { get; set; }
        public SolusVmQueryAttribute(string name)
        {
            this.Name = name;
        }
    }
}
