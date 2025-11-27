using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.SourceRefresherPreselections;

public class SourceRefresherPreselectionUpdateDto : SourceRefresherPreselectionCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
