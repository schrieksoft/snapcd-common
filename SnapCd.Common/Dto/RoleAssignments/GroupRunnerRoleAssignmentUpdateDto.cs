using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupRunnerRoleAssignmentUpdateDto : GroupRunnerRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
