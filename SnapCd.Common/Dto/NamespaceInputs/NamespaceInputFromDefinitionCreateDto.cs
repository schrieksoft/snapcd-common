using SnapCd.Common.Dto.NamespaceInputs.Base;

namespace SnapCd.Common.Dto.NamespaceInputs;

public class NamespaceInputFromDefinitionCreateDto : NamespaceInputCreateDto
{
    public DefinitionInputType DefinitionName { get; set; }
}
