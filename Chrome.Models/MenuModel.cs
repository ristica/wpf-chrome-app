using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chrome.Models;

public sealed class MenuModel : IMenuModel
{
    private bool _isFavorite;

    public Guid Id { get; init; }
    public string UiMenuIdentifier { get; set; } = string.Empty;
    public int Order { get; set; }
    public required string HeaderDe { get; set; }
    public string? HeaderEn { get; set; }
    public bool IsChild { get; set; }
    public string? ParentIdDe { get; set; }
    public string? ParentIdEn { get; set; }
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

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}