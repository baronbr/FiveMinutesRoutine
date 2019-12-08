using System.IO;
using Android.App;
using Android.Content.PM;
using Android.OS;
using CarouselView.FormsPlugin.Android;
using Prism;
using Prism.Ioc;
using Android.Runtime;
using FFImageLoading.Forms.Platform;
using Xamd.ImageCarousel.Forms.Plugin.Droid;

namespace FiveMinutesRoutines.Droid
{
    [Activity(Label = "FiveMinutesRoutines", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
           
            base.OnCreate(bundle);
            string dbName = "app_db.sqlite";
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fullPath = Path.Combine(folderPath, dbName);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            
            LoadApplication(new App(new AndroidInitializer(), fullPath));
            ImageCarouselRenderer.Init();
            //CarouselViewRenderer.Init();
            CachedImageRenderer.Init(true);




            //Aurora.ComponentLoader.Init("PCUXVI7yJwkBVAXzLBtaC0+1V6X3jZsD9/01xOBBoXY8n16e83pdx0S3umX7DXg/HRo2LUvTAUGCb55qKqgSZLEMQmS213miUOVSsfDWL60yyKj/1RtsgUQpyOrNw8fiCsFa2jKVBskq8QC7/P612nQUVcAOruKdmOoTZJrSe6U=");

            // LoadApplication(new App(fullPath));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
        }
    }
}

