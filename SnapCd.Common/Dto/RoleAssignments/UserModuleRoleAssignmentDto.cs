using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserModuleRoleAssignmentDto : UserModuleRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}