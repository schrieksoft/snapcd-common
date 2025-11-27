namespace SnapCd.Common.Dto.Secrets;

/// <summary>
/// DTO for creating a new Secret (POST operations).
/// </summary>
public class SecretCreateDto
{
    public string Name { get; set; } = null!;
}
