using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RunnerStackAssignments;

public class RunnerStackAssignmentReadDto : RunnerStackAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}