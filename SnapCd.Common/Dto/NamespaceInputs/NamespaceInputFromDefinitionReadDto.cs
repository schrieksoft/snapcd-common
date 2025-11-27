using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceInputs;

public class NamespaceInputFromDefinitionReadDto : NamespaceInputFromDefinitionCreateDto, IDto
{
    public Guid Id { get; set; }
}