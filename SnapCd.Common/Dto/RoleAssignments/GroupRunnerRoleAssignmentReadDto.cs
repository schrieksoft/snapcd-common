using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupRunnerRoleAssignmentReadDto : GroupRunnerRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}