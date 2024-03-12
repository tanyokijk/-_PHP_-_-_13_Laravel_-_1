namespace ГК_PHP_ПЗ_Модуль_13_Laravel_ч_1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
