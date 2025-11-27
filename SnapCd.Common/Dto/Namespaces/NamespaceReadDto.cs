using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Namespaces;

public class NamespaceReadDto : NamespaceCreateDto, IDto
{
    public Guid Id { get; set; }
}