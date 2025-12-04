using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupNamespaceRoleAssignmentReadDto : GroupNamespaceRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}