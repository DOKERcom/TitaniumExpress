using System.Collections.ObjectModel;
using System.Windows;
using TitaniumExpress.Core.Common;
using TitaniumExpress.Core.DomainModels;
using TitaniumExpress.Core.Interfaces.View;

namespace TitaniumExpress.View.ViewModels;

public class MainViewModel : ViewModelBase, IMainViewModel
{
    private readonly IMainModel _model;

    private UserDomainModel _user;

    public MainViewModel(IMainModel model, UserDomainModel user)
    {
        _model = model;

        _user = user;
    }

    public UserDomainModel User { get => _user; set => Set(ref _user, value); }

    //public ObservableCollection<string> Logs { get => _user; set => Set(ref _user, value); }



    private RelayCommand? _btnWorkerClickCommand;
    public RelayCommand BtnWorkerClickCommand => _btnWorkerClickCommand ??= new RelayCommand(AddMethod, () => true);

    private void AddMethod() => MessageBox.Show("Temp", "TempMessage");
}