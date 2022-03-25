using Enterspeed.Plugins.UmbracoCms.V8.MediaPicker3.Converters;
using Enterspeed.Source.UmbracoCms.V8.Components.DataPropertyValueConverter;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Enterspeed.Plugins.UmbracoCms.V8.MediaPicker3.Composers
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class EnterspeedMediaPicker3Composer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.EnterspeedPropertyValueConverters()
                .Append<MediaPicker3PropertyValueConverter>(); 







        }
    }
}