using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupRunnerRoleAssignmentDto : GroupRunnerRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}