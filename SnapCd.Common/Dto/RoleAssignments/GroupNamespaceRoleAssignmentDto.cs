using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupNamespaceRoleAssignmentDto : GroupNamespaceRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}