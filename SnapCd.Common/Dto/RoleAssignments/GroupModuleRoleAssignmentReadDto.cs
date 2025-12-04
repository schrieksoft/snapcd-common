using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupModuleRoleAssignmentReadDto : GroupModuleRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}