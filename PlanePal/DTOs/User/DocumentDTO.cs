using PlanePal.Enums;
using System.Text.Json.Serialization;

namespace PlanePal.DTOs.User
{
    public class DocumentDTO
    {
        /// <summary>
        /// Type of identification document (can be passport or identity document).
        /// </summary>
        /// <example>Passport</example>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public IdDocumentTypeEnum DocumentType { get; set; }

        /// <summary>
        /// Expiration date of the identification document.
        /// </summary>
        /// <example>2030-12-31</example>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Document number associated with the identification document.
        /// </summary>
        /// <example>ABC123456</example>
        public string DocumentNumber { get; set; }
    }
}