﻿namespace Chrome.Models;

public class MenuUiItem
{
    public Guid UiId { get; init; } = Guid.NewGuid();
    public IMenuModel? Parent { get; set; }
    public List<MenuModel?> Children { get; set; } = new();
}