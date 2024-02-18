using Chrome.Constants;
using Chrome.Models;

namespace Chrome.ViewModels.Design_Data;

public static class CarouselMenuGenerator
{
    public static List<MenuModel> Generate()
    {
        return
        [
            //new MenuModel
            //{
            //    Id = Guid.NewGuid(),
            //    Order = 1,
            //    HeaderDe = "Datei",
            //    ParentIdDe = "Datei",
            //    HasChildren = true,
            //    IsChild = false,
            //    NeedsOneOfRoles = GetDefaultRoles()
            //},

            //new MenuModel
            //{
            //    Id = Guid.NewGuid(),
            //    Order = 1,
            //    HeaderDe = "Beenden",
            //    HasChildren = false,
            //    IsChild = true,
            //    ParentIdDe = "Datei",
            //    NeedsOneOfRoles = GetDefaultRoles()
            //},

            //new MenuModel
            //{
            //    Id = Guid.NewGuid(),
            //    Order = 2,
            //    HeaderDe = "Letzten 15 Kunden welche bearbeitet wurden",
            //    HasChildren = false,
            //    IsChild = true,
            //    ParentIdDe = "Datei",
            //    NeedsOneOfRoles = GetDefaultRoles()
            //},

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 2,
                HeaderDe = "Übersicht",
                HeaderEn = "Overview",
                ParentIdDe = "Übersicht",
                ParentIdEn = "Overview",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "Übersicht Aktionen",
                HeaderEn = "Available tasks",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Übersicht",
                ParentIdEn = "Overview",
                UiMenuIdentifier = MenuIdentifiers.Uebersicht.UbersichtAktionen,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 2,
                HeaderDe = "Web Eingänge",
                HeaderEn = "Web applications",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Übersicht",
                ParentIdEn = "Overview",
                UiMenuIdentifier = MenuIdentifiers.Uebersicht.WebEingaenge,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 3,
                HeaderDe = "Excel Gewinnspiel",
                HeaderEn = "Excel lottery",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Übersicht",
                ParentIdEn = "Overview",
                UiMenuIdentifier = MenuIdentifiers.Uebersicht.ExcelGewinnspiel,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 3,
                HeaderDe = "Aktionen",
                ParentIdDe = "Aktionen",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "Neue Aktion",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Aktionen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 2,
                HeaderDe = "Aktionsdetails bearbeiten",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Aktionen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 3,
                HeaderDe = "CRM-Light Kundensuche",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Aktionen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 4,
                HeaderDe = "OPTIVO Bounces",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Aktionen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 4,
                HeaderDe = "CFM",
                ParentIdDe = "CFM",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "Kundensuche",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 2,
                HeaderDe = "Kundenneuanlage",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 3,
                HeaderDe = "Neuanlage pro Store",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 4,
                HeaderDe = "Neuanlage Einkaufsgesellschaften",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 5,
                HeaderDe = "Neuanlage pro Einkaufsgesellschaft (BORG ID)",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 6,
                HeaderDe = "CFM Log",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 7,
                HeaderDe = "Kundengruppierungen",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 8,
                HeaderDe = "Kunden-Beziehungen",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 9,
                HeaderDe = "Postretouren",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 10,
                HeaderDe = "Historische Postretouren",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 11,
                HeaderDe = "Karten u. Tagesausweise",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 5,
                HeaderDe = "Kreditmanagement",
                ParentIdDe = "Kreditmanagement",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "Bankstammdaten",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 2,
                HeaderDe = "Kundenbankdaten",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 3,
                HeaderDe = "Zahlungsbedingungen",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 4,
                HeaderDe = "Log Zahlungsbedingungen",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 5,
                HeaderDe = "Auswertung Kreditkunden / Rechnungsarten",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 6,
                HeaderDe = "Auswertung Monats- u. Einzelrechnungskunden",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 7,
                HeaderDe = "Kassensperren",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 6,
                HeaderDe = "Kreditantrag",
                ParentIdDe = "Kreditantrag",
                HasChildren = false,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 7,
                HeaderDe = "DSGVO",
                ParentIdDe = "DSGVO",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "Anonym. Voraussetzungen",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "DSGVO",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 2,
                HeaderDe = "Anonym. Freigeben",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "DSGVO",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 3,
                HeaderDe = "Anonym. Kunden",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "DSGVO",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 4,
                HeaderDe = "Anonym. Einkaufsberechtigte",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "DSGVO",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 8,
                HeaderDe = "Archiv",
                ParentIdDe = "Archiv",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "Kundenarchiv",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Archiv",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 9,
                HeaderDe = "Tabellen",
                ParentIdDe = "Tabellen",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "Branchen",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 2,
                HeaderDe = "Branchen Stichwortverzeichnis",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 3,
                HeaderDe = "Kundenberater",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 4,
                HeaderDe = "Einzugseinheiten",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 5,
                HeaderDe = "Distrikte-Einzugseinheiten",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 6,
                HeaderDe = "National Grid",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 10,
                HeaderDe = "Administration",
                ParentIdDe = "Administration",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "Aktions- Typ Verwaltung",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 2,
                HeaderDe = "Benutzerrollen",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 3,
                HeaderDe = "Berechtigungen",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 4,
                HeaderDe = "Definition Web Aktionen",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 5,
                HeaderDe = "Kundennummern reservieren",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 6,
                HeaderDe = "Strassenkatalog",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 7,
                HeaderDe = "Zielgruppen",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 8,
                HeaderDe = "Locks",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 9,
                HeaderDe = "Monatsrechnung",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 10,
                HeaderDe = "Privileges",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 11,
                HeaderDe = "Delegation",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 12,
                HeaderDe = "OPTIVIO Reset Counter",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 13,
                HeaderDe = "Rollen Test",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 14,
                HeaderDe = "Kundenbildschirm",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 11,
                HeaderDe = "Fenster",
                ParentIdDe = "Fenster",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "Screenshot",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Fenster",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 12,
                HeaderDe = "Optionen",
                ParentIdDe = "Optionen",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "Scanner",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "Optionen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 13,
                HeaderDe = "?",
                ParentIdDe = "?",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 1,
                HeaderDe = "About",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "?",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 2,
                HeaderDe = "Dokumente",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "?",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 3,
                HeaderDe = "Manuals",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "?",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new MenuModel
            {
                Id = Guid.NewGuid(),
                Order = 4,
                HeaderDe = "Releasenotes",
                HasChildren = false,
                IsChild = true,
                ParentIdDe = "?",
                NeedsOneOfRoles = GetDefaultRoles()
            }
        ];
    }

    private static string GetDefaultRoles()
    {
        return "Admin;Reader";
    }
}