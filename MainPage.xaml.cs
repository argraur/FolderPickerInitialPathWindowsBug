using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Storage;

namespace FolderPickerInitialPath
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnInitialPathPickerClicked(object sender, EventArgs e)
        {
            var result = await FolderPicker.PickAsync(InitialPath.Text, CancellationToken.None);
            if (result != null && result.Folder != null)
            {
                await Toast.Make(result.Folder.Path).Show();
            }
        }

        private async void OnNoInitialPathPickerClicked(object sender, EventArgs e)
        {
            var result = await FolderPicker.PickAsync(CancellationToken.None);
            if (result != null && result.Folder != null)
            {
                await Toast.Make(result.Folder.Path).Show();
            }
        }
    }

}
