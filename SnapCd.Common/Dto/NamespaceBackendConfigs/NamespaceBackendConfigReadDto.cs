using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceBackendConfigs;

public class NamespaceBackendConfigReadDto : NamespaceBackendConfigCreateDto, IDto
{
    public Guid Id { get; set; }
}