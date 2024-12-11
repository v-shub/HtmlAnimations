using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using MudBlazor;

namespace BlazorApp.Models
{
    public class ThemeManagerModel
    {
        public bool IsDarkMode {  get; set; }
        public string PrimaryColor {  get; set; }
    }
}
