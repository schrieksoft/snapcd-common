using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserRunnerRoleAssignmentDto : UserRunnerRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}