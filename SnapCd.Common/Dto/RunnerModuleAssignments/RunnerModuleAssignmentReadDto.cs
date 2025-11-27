using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RunnerModuleAssignments;

public class RunnerModuleAssignmentReadDto : RunnerModuleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}