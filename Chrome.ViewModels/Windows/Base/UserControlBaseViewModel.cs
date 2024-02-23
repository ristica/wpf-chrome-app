﻿using Chrome.Common.Contracts;
using Chrome.Dependencies.Contracts;
using Chrome.ViewModels.Base;
using Chrome.ViewModels.Commands.Common;

namespace Chrome.ViewModels.Windows.Base;

public abstract class UserControlBaseViewModel(IDependencyContainer container, string window) : ViewModel
{
    protected readonly IDependencyContainer Container = container;
    private readonly IUserControl? _userControl = container.Resolve<IUserControl>(window);

    private IUserControlParentViewModel? CurrentWindowViewModel { get; set; }
    public required string WindowTitle { get; set; }

    public CloseWindowCommand? CloseWindowCommand { get; private set; }
    public MinimizeWindowCommand? MinimizeWindowCommand { get; private set; }
    public MaximizeWindowCommand? MaximizeWindowCommand { get; private set; }
    public ActivateWindowCommand? ActivateWindowCommand { get; private set; }
    public LeaveWindowCommand? LeaveWindowCommand { get; private set; }
    public DragStartWindowCommand? DragStartWindowCommand { get; private set; }
    public DragStopWindowCommand? DragStopWindowCommand { get; private set; }
    public MarkerActivateCommand? MarkerActivateCommand { get; private set; }
    public MarkerDeactivateCommand? MarkerDeactivateCommand { get; private set; }

    public IUserControl? GetUserControl() => this._userControl;

    protected void SetWindowInstanceViewModel(IUserControlParentViewModel? vm)
    {
        this.CurrentWindowViewModel = vm;
        this._userControl?.SetDataContext<IUserControlParentViewModel>(this.CurrentWindowViewModel);

        this.RegisterCommands();
    }

    private void RegisterCommands()
    {
        CloseWindowCommand = new CloseWindowCommand(CurrentWindowViewModel);
        MinimizeWindowCommand = new MinimizeWindowCommand(CurrentWindowViewModel);
        MaximizeWindowCommand = new MaximizeWindowCommand(CurrentWindowViewModel);

        ActivateWindowCommand = new ActivateWindowCommand(CurrentWindowViewModel);
        LeaveWindowCommand = new LeaveWindowCommand(CurrentWindowViewModel);

        DragStartWindowCommand = new DragStartWindowCommand(CurrentWindowViewModel);
        DragStopWindowCommand = new DragStopWindowCommand(CurrentWindowViewModel);

        MarkerActivateCommand = new MarkerActivateCommand(CurrentWindowViewModel);
        MarkerDeactivateCommand = new MarkerDeactivateCommand(CurrentWindowViewModel);
    }
}