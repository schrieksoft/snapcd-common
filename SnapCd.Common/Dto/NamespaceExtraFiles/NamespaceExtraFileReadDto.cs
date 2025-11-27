using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceExtraFiles;

public class NamespaceExtraFileReadDto : NamespaceExtraFileCreateDto, IDto
{
    public Guid Id { get; set; }
}