using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Controls;

namespace MyNotePad.Util
{
    public static class Helper
    {
        public class PageHelper
        {
            public static RadBusyIndicator radBusyIndicator;
            public static ContentControl MainContent;
            public static void LoadingAnimationSwitch(bool isShow)
            {
                radBusyIndicator.IsActive = isShow;
            }
            public static void RedirectTo(object page)
            {
                MainContent.Content = page;
            }
        }
    }
}
