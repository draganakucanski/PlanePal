using PlanePal.DTOs.Blob;
using PlanePal.Enums;
using System.Text.Json.Serialization;

namespace PlanePal.DTOs.User
{
    public class DocumentDetailsDTO
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public IdDocumentTypeEnum DocumentType { get; set; }

        public DateTime ExpirationDate { get; set; }
        public string DocumentNumber { get; set; }
        public BlobDTO BlobDto { get; set; }
    }
}