using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RunnerServicePrincipalAssignments;

public class RunnerServicePrincipalAssignmentReadDto : RunnerServicePrincipalAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}