using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Secrets;

public class MappedSecretUpdateDto : MappedSecretCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
