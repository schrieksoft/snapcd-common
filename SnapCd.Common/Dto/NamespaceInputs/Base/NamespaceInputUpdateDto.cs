using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceInputs.Base;

public class NamespaceInputUpdateDto : NamespaceInputCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
