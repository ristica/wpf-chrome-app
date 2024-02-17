using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chrome.Models;

public interface IMenuModel : INotifyPropertyChanged
{
    Guid Id { get; }
    int Order { get; set; }
    string Header { get; set; }
    bool IsChild { get; set; }
    string? ParentId { get; set; }
    bool HasChildren { get; set; }
    string NeedsOneOfRoles { get; set; }
}

public class MenuModel : IMenuModel
{
    private bool _isFavorite;
    public Guid Id { get; set; }
    public int Order { get; set; }
    public string Header { get; set; } = string.Empty;
    public bool IsChild { get; set; }
    public string? ParentId { get; set; }
    public bool HasChildren { get; set; }
    public string NeedsOneOfRoles { get; set; } = string.Empty;

    public bool IsFavorite
    {
        get => _isFavorite;
        set
        {
            _isFavorite = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}