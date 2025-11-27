using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceInputs;

public class NamespaceInputFromLiteralUpdateDto : NamespaceInputFromLiteralCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
