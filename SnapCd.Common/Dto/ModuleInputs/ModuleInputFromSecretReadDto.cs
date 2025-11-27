using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromSecretReadDto : ModuleInputFromSecretCreateDto, IDto
{
    public Guid Id { get; set; }
}