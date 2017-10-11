using Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bartab.Model;
using Bartab.Assets;

namespace ViewModel
{
    public class UserContentViewModel
    {
        private UserContentModel UCM = new UserContentModel();

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

        public void LoadVarer()
        {
            try
            {
                var temp = UCM.LoadVarer();
                foreach (Vare item in temp)
                {
                    vare.Add(item);
                }
            }
            catch (Exception e)
            { }

        }

        public void LoadDrink()
        {
            //drink load
        }

        public void LoadUser()
        {
            try
            {
                var semester = UCM.semester();
                var temp = UCM.LoadUsers();
                foreach (User item in temp)
                {
                    var UserSemesterTemp = item.Semester.Split(',');
                    if (Convert.ToInt32(UserSemesterTemp[UserSemesterTemp.Length - 2]) == semester)
                    {
                        brugere.Add(item);
                        brugereCombo.Add(item.VærelseNr + " " + item.Fornavn);
                    }
                }
            }
            catch (Exception e)
            { }
        }

        public bool BuySplit()
        {
            int result = 0;
            foreach (var item in IndkobListe)
            {
                result+=UCM.Buy(BrugerId, item.Id, item.Amount, item.Price);
            }
            return result==0;
        }
    }
}
