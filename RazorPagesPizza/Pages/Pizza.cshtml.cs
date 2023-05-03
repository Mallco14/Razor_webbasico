using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;
namespace RazorPagesPizza.Pages
{public class PizzaModel : PageModel
{
    public List<Pizza> pizzas = new();
    [BindProperty]
    public Pizza NewPizza { get; set; } = new();

    public void OnGet()
    {
        pizzas = PizzaService.GetAll();//Esto sirve para poder llamar a la lista
    }
    
    public string GlutenFreeText(Pizza pizza)
    {
        return pizza.IsGlutenFree ? "Gluten Free": "Not Gluten Free";
    }

    /* Incorporar un controlador */
                        /* Valida si los datos son correctos */
    public IActionResult OnPost()
    {   /* Valida si los datos son correctos */
        if (!ModelState.IsValid)
        {
            return Page();
        }
        /* Se pasan al servicio */
        PizzaService.Add(NewPizza);
        return RedirectToAction("Get");
    }

    public IActionResult OnPostDelete(int id)
    {
        PizzaService.Delete(id);
        return RedirectToAction("Get");
    }
}

}

