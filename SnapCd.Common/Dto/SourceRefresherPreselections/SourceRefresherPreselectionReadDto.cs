using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.SourceRefresherPreselections;

public class SourceRefresherPreselectionReadDto : SourceRefresherPreselectionCreateDto, IDto
{
    public Guid Id { get; set; }
}