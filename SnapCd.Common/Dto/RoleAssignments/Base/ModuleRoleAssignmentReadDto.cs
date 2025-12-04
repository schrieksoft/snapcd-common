using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class ModuleRoleAssignmentReadDto : ModuleRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}