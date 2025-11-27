using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupModuleRoleAssignmentDto : GroupModuleRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}