// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace TodoDemo.Strings
{
    using System;
    using System.Reflection;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {

        private static System.Resources.ResourceManager resourceMan;

        private static System.Globalization.CultureInfo resourceCulture;

        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.Equals(null, resourceMan))
                {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("TodoDemo.Strings.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static string LoadingText 
        {
            get 
            {
                return ResourceManager.GetString("LoadingText", resourceCulture);
            }
        }

        internal static string MainPageTitle 
        {
            get 
            {
                return ResourceManager.GetString("MainPageTitle", resourceCulture);
            }
        }
        
        internal static string TodoItemDetailTitle
        {
            get 
            {
                return ResourceManager.GetString("TodoItemDetailTitle", resourceCulture);
            }
        }
        
        internal static string AddButton
        {
            get
            {
                return ResourceManager.GetString("AddButton", resourceCulture);
            }
        }
        
        internal static string DeleteButton
        {
            get
            {
                return ResourceManager.GetString("DeleteButton", resourceCulture);
            }
        }
        
        internal static string DescriptionLabel
        {
            get
            {
                return ResourceManager.GetString("DescriptionLabel", resourceCulture);
            }
        }
        
        internal static string IsDoneLabel
        {
            get
            {
                return ResourceManager.GetString("IsDoneLabel", resourceCulture);
            }
        }
        
        internal static string SaveButton
        {
            get
            {
                return ResourceManager.GetString("SaveButton", resourceCulture);
            }
        }
    }
}
