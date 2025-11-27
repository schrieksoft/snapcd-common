using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceInputs;

public class NamespaceInputFromLiteralReadDto : NamespaceInputFromLiteralCreateDto, IDto
{
    public Guid Id { get; set; }
}