using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserRunnerRoleAssignmentReadDto : UserRunnerRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}