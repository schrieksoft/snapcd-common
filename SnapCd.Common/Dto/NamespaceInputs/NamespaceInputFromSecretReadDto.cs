using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceInputs;

public class NamespaceInputFromSecretReadDto : NamespaceInputFromSecretCreateDto, IDto
{
    public Guid Id { get; set; }
}