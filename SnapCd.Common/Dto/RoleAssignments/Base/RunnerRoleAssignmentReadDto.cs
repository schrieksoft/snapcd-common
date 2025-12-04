using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class RunnerRoleAssignmentReadDto : RunnerRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}