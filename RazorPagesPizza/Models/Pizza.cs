using System.ComponentModel.DataAnnotations;


namespace RazorPagesPizza.Models;

public class Pizza {
    public int Id {get ; set;}

    [Required]/* esto indica que tienen que tener un valor */
    public string? Name {get; set;}
    public PizzaSize Size {get; set;}
    public bool IsGlutenFree {get; set;}

    [Range(0.01,9999.99)] /* Esto restringue el valor */
    public decimal Price {get; set;}

    public List<Pizza> pizzas = new();

}

public enum PizzaSize {Small, Medium, Large}
