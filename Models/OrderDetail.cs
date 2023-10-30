using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ZavrsniRad.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public bool isInTheCart { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public Order Order { get; set; }
    }
}
