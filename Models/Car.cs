using System;
using System.ComponentModel.DataAnnotations;

namespace csharp_gregslist.Models
{
  public class Car
  {
    public string Id {get; set;}
    [Required]
    [MaxLength(20)]
    public string Make {get; set;}
    [Required]
    public string Model {get; set;}
    [Required]
    [Range(1910, 9999)]
    public int Year {get; set;}
    [Required]
    [Range(0, int.MaxValue)]
    public int Price {get; set;}
    public string ImgURL {get; set;}
    [MaxLength(1000)]
    public string Description {get; set;}

    public Car(string make, string model, int year, int price, string imgUrl, string description){
      Make = make;
      Model = model;
      Year = year;
      Price = price;
      ImgURL = imgUrl;
      Description = description;
      Id = Guid.NewGuid().ToString();
    }
  }
}