using appContacto.Models;
using appContacto.ViewModels;
using System.Collections.Generic;

namespace appContacto.ViewsModels
{
    public class MainViewModel
    {
        #region Properties
        public List<Contact> ContactList { get; set; }
        #endregion

        #region ViewModel
        public ContactViewModel contacViewModel { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.contacViewModel = new ContactViewModel();
        }
        #endregion

        #region singleton
        private static MainViewModel instance;
        public  static MainViewModel GetInstance()
        {
            if(instance==null)
            {
                instance = new MainViewModel();
            }
            return (instance);
        }
        #endregion


    }
}
