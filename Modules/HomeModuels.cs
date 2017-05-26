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
        List<Contact> allContacts = Contact.GetAllContacts();
        return View["index.cshtml", allContacts];
      };
      Get["/contact/create"] = _ => {
        return View["new-contact-form.cshtml"];
      };
      Post["/contact/new"] = _ => {
        Contact newContact = new Contact(Request.Form["contactFirstName"], Request.Form["contactLastName"], Request.Form["contactAddress"], Request.Form["contactPhone"]);
        return View["new-contact-confirmed.cshtml", newContact];
      };
      Get["/contact/{id}"] = param => {
          Contact contact = Contact.FindContact(param.id);
          return View["/contact-details.cshtml", contact];
      };

    }
  }
}
