using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceBackendConfigs;

public class NamespaceBackendConfigUpdateDto : NamespaceBackendConfigCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
