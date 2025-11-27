using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RunnerServicePrincipalAssignments;

public class RunnerServicePrincipalAssignmentUpdateDto : RunnerServicePrincipalAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
