using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class NamespaceRoleAssignmentDto : NamespaceRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}