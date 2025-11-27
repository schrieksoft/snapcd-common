using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RunnerModuleAssignments;

public class RunnerModuleAssignmentUpdateDto : RunnerModuleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
