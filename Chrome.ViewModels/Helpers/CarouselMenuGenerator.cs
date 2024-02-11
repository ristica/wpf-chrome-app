using Chrome.Models;

namespace Chrome.ViewModels.Helpers;

public class CarouselMenuGenerator
{
    public static List<MenuModel> Generate()
    {
        return
        [
            new()
            {
                Order = 1,
                Header = "Datei",
                ParentId = "Datei",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Beenden",
                HasChildren = false,
                IsChild = true,
                ParentId = "Datei",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 2,
                Header = "Letzten 15 Kunden welche bearbeitet wurden",
                HasChildren = false,
                IsChild = true,
                ParentId = "Datei",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 2,
                Header = "Übersicht",
                ParentId = "Übersicht",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Übersicht Aktionen",
                HasChildren = false,
                IsChild = true,
                ParentId = "Übersicht",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 2,
                Header = "Web Eingänge",
                HasChildren = false,
                IsChild = true,
                ParentId = "Übersicht",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 3,
                Header = "Excel Gewinnspiel",
                HasChildren = false,
                IsChild = true,
                ParentId = "Übersicht",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 3,
                Header = "Aktionen",
                ParentId = "Aktionen",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Neue Aktion",
                HasChildren = false,
                IsChild = true,
                ParentId = "Aktionen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 2,
                Header = "Aktionsdetails bearbeiten",
                HasChildren = false,
                IsChild = true,
                ParentId = "Aktionen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 3,
                Header = "CRM-Light Kundensuche",
                HasChildren = false,
                IsChild = true,
                ParentId = "Aktionen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 4,
                Header = "OPTIVO Bounces",
                HasChildren = false,
                IsChild = true,
                ParentId = "Aktionen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 4,
                Header = "CFM",
                ParentId = "CFM",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Kundensuche",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 2,
                Header = "Kundenneuanlage",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 3,
                Header = "Neuanlage pro Store",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 4,
                Header = "Neuanlage Einkaufsgesellschaften",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 5,
                Header = "Neuanlage pro Einkaufsgesellschaft (BORG ID)",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 6,
                Header = "CFM Log",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 7,
                Header = "Kundengruppierungen",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 8,
                Header = "Kunden-Beziehungen",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 9,
                Header = "Postretouren",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 10,
                Header = "Historische Postretouren",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 11,
                Header = "Karten u. Tagesausweise",
                HasChildren = false,
                IsChild = true,
                ParentId = "CFM",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 5,
                Header = "Kreditmanagement",
                ParentId = "Kreditmanagement",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Bankstammdaten",
                HasChildren = false,
                IsChild = true,
                ParentId = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 2,
                Header = "Kundenbankdaten",
                HasChildren = false,
                IsChild = true,
                ParentId = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 3,
                Header = "Zahlungsbedingungen",
                HasChildren = false,
                IsChild = true,
                ParentId = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 4,
                Header = "Log Zahlungsbedingungen",
                HasChildren = false,
                IsChild = true,
                ParentId = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 5,
                Header = "Auswertung Kreditkunden / Rechnungsarten",
                HasChildren = false,
                IsChild = true,
                ParentId = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 6,
                Header = "Auswertung Monats- u. Einzelrechnungskunden",
                HasChildren = false,
                IsChild = true,
                ParentId = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 7,
                Header = "Kassensperren",
                HasChildren = false,
                IsChild = true,
                ParentId = "Kreditmanagement",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 6,
                Header = "Kreditantrag",
                ParentId = "Kreditantrag",
                HasChildren = false,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 7,
                Header = "DSGVO",
                ParentId = "DSGVO",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Anonym. Voraussetzungen",
                HasChildren = false,
                IsChild = true,
                ParentId = "DSGVO",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 2,
                Header = "Anonym. Freigeben",
                HasChildren = false,
                IsChild = true,
                ParentId = "DSGVO",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 3,
                Header = "Anonym. Kunden",
                HasChildren = false,
                IsChild = true,
                ParentId = "DSGVO",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 4,
                Header = "Anonym. Einkaufsberechtigte",
                HasChildren = false,
                IsChild = true,
                ParentId = "DSGVO",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 8,
                Header = "Archiv",
                ParentId = "Archiv",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Kundenarchiv",
                HasChildren = false,
                IsChild = true,
                ParentId = "Archiv",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 9,
                Header = "Tabellen",
                ParentId = "Tabellen",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Branchen",
                HasChildren = false,
                IsChild = true,
                ParentId = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 2,
                Header = "Branchen Stichwortverzeichnis",
                HasChildren = false,
                IsChild = true,
                ParentId = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 3,
                Header = "Kundenberater",
                HasChildren = false,
                IsChild = true,
                ParentId = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 4,
                Header = "Einzugseinheiten",
                HasChildren = false,
                IsChild = true,
                ParentId = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 5,
                Header = "Distrikte-Einzugseinheiten",
                HasChildren = false,
                IsChild = true,
                ParentId = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 6,
                Header = "National Grid",
                HasChildren = false,
                IsChild = true,
                ParentId = "Tabellen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 10,
                Header = "Administration",
                ParentId = "Administration",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Aktions- Typ Verwaltung",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 2,
                Header = "Benutzerrollen",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 3,
                Header = "Berechtigungen",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 4,
                Header = "Definition Web Aktionen",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 5,
                Header = "Kundennummern reservieren",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 6,
                Header = "Strassenkatalog",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 7,
                Header = "Zielgruppen",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 8,
                Header = "Locks",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 9,
                Header = "Monatsrechnung",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 10,
                Header = "Privileges",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 11,
                Header = "Delegation",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 12,
                Header = "OPTIVIO Reset Counter",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 13,
                Header = "Rollen Test",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 14,
                Header = "Kundenbildschirm",
                HasChildren = false,
                IsChild = true,
                ParentId = "Administration",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 11,
                Header = "Fenster",
                ParentId = "Fenster",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Screenshot",
                HasChildren = false,
                IsChild = true,
                ParentId = "Fenster",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 12,
                Header = "Optionen",
                ParentId = "Optionen",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "Scanner",
                HasChildren = false,
                IsChild = true,
                ParentId = "Optionen",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 13,
                Header = "?",
                ParentId = "?",
                HasChildren = true,
                IsChild = false,
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 1,
                Header = "About",
                HasChildren = false,
                IsChild = true,
                ParentId = "?",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 2,
                Header = "Dokumente",
                HasChildren = false,
                IsChild = true,
                ParentId = "?",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 3,
                Header = "Manuals",
                HasChildren = false,
                IsChild = true,
                ParentId = "?",
                NeedsOneOfRoles = GetDefaultRoles()
            },

            new()
            {
                Order = 4,
                Header = "Releasenotes",
                HasChildren = false,
                IsChild = true,
                ParentId = "?",
                NeedsOneOfRoles = GetDefaultRoles()
            }
        ];
    }

    private static string GetDefaultRoles()
    {
        return "Admin;Reader";
    }
}