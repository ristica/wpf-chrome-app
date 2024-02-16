using Chrome.Common.Contracts;
using Chrome.Views.Contracts;

namespace Chrome.ViewModels.Contracts;

public interface ITestViewModel : IParentViewModel
{
    ITestView GetView();
}