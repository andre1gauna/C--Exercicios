using System;
using System.ComponentModel.DataAnnotations;

namespace WebEscola.Domain.Models
{
    public class PageFilter
    {
        [Range(1, int.MaxValue, ErrorMessage = "Insira um número válido! ( mínimo: 1, máximo: 50)")]
        public int PageNumber { get; set; } = 1;

        [Range(1, int.MaxValue, ErrorMessage = "Insira um número válido! ( mínimo: 1, máximo: 50)")]
        public int PageLength { get; set; } = 50;
    }
}