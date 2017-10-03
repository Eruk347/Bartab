using Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class UserContentViewModel
    {
        public ObservableCollection<OrderItem> IndkobListe;
        public ObservableCollection<User> brugere;
        public List<OrderItem> TempList;
        public ObservableCollection<Vare> vare;
        public ObservableCollection<Drink> drink;
        public ObservableCollection<VareItem> vareItem;
        public int BrugerId;
        public ObservableCollection<string> brugereCombo;

        public UserContentViewModel()
        {
            IndkobListe = new ObservableCollection<OrderItem>();
            brugere = new ObservableCollection<User>();
            vare = new ObservableCollection<Vare>();
            brugereCombo = new ObservableCollection<string>();
            drink = new ObservableCollection<Drink>();
            vareItem = new ObservableCollection<VareItem>();
        }
        
        public async Task LoadVarerAsync()
        {
            //VareItem load
        }

        public async Task LoadDrinkAsync()
        {
            //drink load
        }

        public async Task LoadUserAsync()
        {
            //add bruger-object to brugercombo
        }

        public async Task BuyAsync()//skal måske laves om så der ikke er drinks med. Fremtiden vil vise det
        {
            decimal FuldPris = 0;

            foreach (var item in IndkobListe)
            {
                if (item.ErDrink)
                {
                    for (int i = 0; i < drink.Count; i++)
                    {
                        if (drink[i].Id == item.Id)
                        {
                            for (int j = 0; j < drink[i].Ingrediense.Count; j++)
                            {
                                for (int k = 0; k < vare.Count; k++)
                                {
                                    if (drink[i].Ingrediense[j].Id == vare[k].Id)
                                    {
                                        FuldPris += vare[k].Pris * item.Amount;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < vare.Count; i++)
                    {
                        if (vare[i].Id == item.Id)
                        {
                            FuldPris += vare[i].Pris * item.Amount;
                            break;
                        }
                    }
                }
            }
            //send indkøbsliste og få oprettet ordre
        }
    }
}
