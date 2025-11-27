using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Secrets;

public class MappedSecretDto : MappedSecretCreateDto, IDto
{
    public Guid Id { get; set; }
}