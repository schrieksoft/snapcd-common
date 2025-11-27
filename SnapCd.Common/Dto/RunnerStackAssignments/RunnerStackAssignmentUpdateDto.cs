using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RunnerStackAssignments;

public class RunnerStackAssignmentUpdateDto : RunnerStackAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
