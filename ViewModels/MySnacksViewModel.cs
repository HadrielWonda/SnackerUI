using CommunityToolkit.Mvvm.ComponentModel;
using SnackerUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackerUI.ViewModels;

public partial class MySnacksViewModel : ObservableObject 
{
    [ObservableProperty]
    List<Snack> snacks;

    public MySnacksViewModel()
    {
        LoadSnacks();
    }

    private void LoadSnacks()
    {
        Snacks = new()
        {
            new Snack(
                Name: "Wales Treat 1",
                Description:"Wales first treat for you",
                StartDateTime: DateTime.UtcNow.AddDays(1),
                EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(1),
                Image: new Uri("https://imgbb.com/"),
                Savoury: new List<string> {"Food1","Food2","Food3"},
                Sweet:new List<string> {"Sweet1","Sweet2","Sweet3"}),
             new Snack(
                Name: "Wales Treat 2",
                Description:"Wales next treat for you 😋😋😋",
                StartDateTime: DateTime.UtcNow.AddDays(1),
                EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(1),
                Image: new Uri("https://imgbb.com/"),
                Savoury: new List<string> {"FoodA","FoodB","FoodC"},
                Sweet:new List<string> {"SweetA","SweetB","SweetC"})
        }
    }
}
