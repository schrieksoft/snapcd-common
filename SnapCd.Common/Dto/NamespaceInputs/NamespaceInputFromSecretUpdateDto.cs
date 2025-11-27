using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceInputs;

public class NamespaceInputFromSecretUpdateDto : NamespaceInputFromSecretCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
