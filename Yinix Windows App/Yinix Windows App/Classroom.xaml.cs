using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.UI.Notifications;
using Microsoft.Windows.AppNotifications;
using Microsoft.Windows.AppNotifications.Builder;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Yinix_Windows_App;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class Classroom : Page
{
    public Classroom()
    {
        InitializeComponent();
    }

    private void Navigate_Back(object sender, RoutedEventArgs e)
    {
        if (this.Frame.CanGoBack)
        {
            this.Frame.GoBack();
        }
    }
    private void NavigateToSettings(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(Settings));
    }
    private void NavigateToHome(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(MainPage));
    }


    private void SubmitAnnouncement(object sender, RoutedEventArgs e)
    {
        string AnnouncementText = AnnouncementTextBox.PlaceholderText;
        AppNotification Notification = new AppNotificationBuilder()
            .AddText("Yinix Announcement")
            .AddText(AnnouncementText)
            .BuildNotification();
        AppNotificationManager.Default.Show(Notification);
    }
}
