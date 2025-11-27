using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Secrets;

/// <summary>
/// DTO for Secret responses (GET operations).
/// </summary>
public class SecretDto : SecretCreateDto, IDto
{
    public Guid Id { get; set; }
}
