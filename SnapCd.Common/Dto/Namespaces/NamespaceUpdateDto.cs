using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.Namespaces;

public class NamespaceUpdateDto : NamespaceCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}