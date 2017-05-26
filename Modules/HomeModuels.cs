using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/contact/create"] = _ => {
        return View["new-contact-form.cshtml"];
      };
      Post["/contact/new"] = _ => {
        Contact newContact = new Contact(Request.Form["contactFirstName"], Request.Form["contactLastName"], Request.Form["contactAddress"], Request.Form["contactPhone"]);
        List<Contact> allContacts = Contact.GetAllContacts();
        return View["new-contact-confirmed.cshtml", newContact];
      };

    }
  }
}
