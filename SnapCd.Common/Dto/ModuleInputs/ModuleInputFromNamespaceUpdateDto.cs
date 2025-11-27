using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromNamespaceUpdateDto : ModuleInputFromNamespaceCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
