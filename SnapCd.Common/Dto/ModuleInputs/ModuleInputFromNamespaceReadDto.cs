using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromNamespaceReadDto : ModuleInputFromNamespaceCreateDto, IDto
{
    public Guid Id { get; set; }
}