namespace MVCProject.Models
{
    public class ErrorViewModel
    {
        // Hatanın ayırt edici kimliği
        public string RequestId { get; set; } = string.Empty;

        // RequestId varsa gösterilecek
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
