namespace WhiteGold.Domain.Entities;

public class Customer
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string CustomerCode { get; set; } = string.Empty;

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int LoyaltyPoints { get; set; } = 0;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}
