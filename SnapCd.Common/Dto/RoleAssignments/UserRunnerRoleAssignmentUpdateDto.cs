using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserRunnerRoleAssignmentUpdateDto : UserRunnerRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
