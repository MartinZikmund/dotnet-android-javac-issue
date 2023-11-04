using AndroidApp2;
using Microsoft.UI.Xaml.Controls;

namespace Alchemy.Views;

public abstract partial class ViewBase<TViewModel> : Page
    where TViewModel : PageViewModel
{
    protected ViewBase()
    {
    }
}
