using SnapCd.Common.Dto.ModuleInputs.Base;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromNamespaceCreateDto : ModuleInputCreateDto
{
    public Guid NamespaceInputId { get; set; }
}
