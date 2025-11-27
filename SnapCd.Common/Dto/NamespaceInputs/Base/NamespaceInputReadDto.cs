using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceInputs.Base;

public class NamespaceInputReadDto : NamespaceInputCreateDto, IDto
{
    public Guid Id { get; set; }
}