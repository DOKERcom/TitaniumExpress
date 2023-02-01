using TitaniumExpress.Core.Common;
using TitaniumExpress.Core.DomainModels;

namespace TitaniumExpress.Core.Interfaces.View;

public interface IMainViewModel
{
    UserDomainModel User { get; set; }

    RelayCommand BtnWorkerClickCommand { get; }
}