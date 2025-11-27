using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceExtraFiles;

public class NamespaceExtraFileUpdateDto : NamespaceExtraFileCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
