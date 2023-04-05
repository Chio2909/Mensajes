using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MnsjAn.Resources
{
    [ContentProperty("Text")]
    public  class Translate : IMarkupExtension
    {
        private const string ResourceId = "MnsjAn.Resources.AppResources";
        public string Text { get; set; }


        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null) return null;
            ResourceManager resourceManager = new ResourceManager(ResourceId, typeof(Translate).GetTypeInfo().Assembly);
            return resourceManager.GetString(Text, CultureInfo.CurrentCulture);
        }
    }
}
