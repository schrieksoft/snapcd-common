using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceInputs;

public class NamespaceInputFromDefinitionUpdateDto : NamespaceInputFromDefinitionCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
