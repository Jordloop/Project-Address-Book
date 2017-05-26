using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => { // HOME PAGE
        List<Contact> allContacts = Contact.GetAllContacts();
        return View["index.cshtml", allContacts]; //  DISPLAYS LIST OF ALL CONTACTS
      };
      Get["/contact/create"] = _ => { //  FROM HOME PAGE TO CONTACT/CREATE
        return View["new-contact-form.cshtml"];
      };
      Post["/contact/new"] = _ => { // FROM CONTACT/CREATE TO CONTACT/NEW. COLLECTS DATA FROM FORM WITH ACTION="/CONTACT/NEW"
        Contact newContact = new Contact(Request.Form["contactFirstName"], Request.Form["contactLastName"], Request.Form["contactAddress"], Request.Form["contactPhone"]);  //  INSTANTIATES A CONTACT OBJECT USING INPUTED DATA
        return View["new-contact-confirmed.cshtml", newContact];  //  DISPLAYS PROPERTIES OF NEWLY CREATED CONTACT OBJECT
      };
      Get["/contact/{id}"] = param => { //FROM HOME PAGE TO CONTACT/{DYNAMIC ID}
          Contact contact = Contact.FindContact(param.id);  //  FINDS CONTACT ID BASED ON CONTACT CLICKED
          return View["/contact-details.cshtml", contact];  //  DISPLAYS DETAILS OF CLICKED CONTACT
      };
      Post["/contacts/clear"] = _ => {  //  FROM HOME PAGE TO CONTACTS/CLEAR. LISTENS FOR CLICK FROM FORM WITH ACTION="CONTACTS/CLEAR"
        Contact.ClearAllContacts(); //  REMOVES ALL CONTACTS FROM LIST OF CREATED CONTACTS
        return View["all-contacts-cleared.cshtml"]; // DISPLAYS CONFIRMATION THAT ALL CONTACTS HAVE BEEN CLEARED
      };

    }
  }
}
