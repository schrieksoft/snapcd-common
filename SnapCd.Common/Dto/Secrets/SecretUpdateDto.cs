using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Secrets;

/// <summary>
/// DTO for updating an existing Secret (PUT operations).
/// </summary>
public class SecretUpdateDto : SecretCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
