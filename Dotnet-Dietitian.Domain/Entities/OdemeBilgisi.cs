namespace Dotnet_Dietitian.Domain.Entities;

public class OdemeBilgisi : BaseEntity
{
    public Guid HastaId { get; set; }
    public Guid ?AbonelikId { get; set; }// Nullable, ��nk� abonelik hemen olu�turulmayabilir
    public decimal Tutar { get; set; }
    public DateTime Tarih { get; set; }
    public string? OdemeTuru { get; set; }
    public string? Aciklama { get; set; }
    public string? IslemReferansNo { get; set; }
    
    // Navigation properties
    public virtual Hasta Hasta { get; set; }
    public virtual Abonelik? Abonelik { get; set; }
}
