namespace SnapCd.Common.Dto.RoleAssignments;

/// <summary>
/// Unified DTO for creating all role assignment types (User, ServicePrincipal, Group) across all scopes (Organization, Stack, Namespace, Module).
/// Uses discriminator-based routing in the service layer to determine the specific entity type.
/// </summary>
public class RoleAssignmentCreateDto
{

    /// <summary>
    /// The ID of the principal (User, ServicePrincipal, or Group) receiving the role.
    /// Computed column in database based on discriminator.
    /// </summary>
    public Guid PrincipalId { get; set; }

    /// <summary>
    /// The ID of the resource (Organization, Stack, Namespace, or Module) where the role is assigned.
    /// Computed column in database based on discriminator.
    /// </summary>
    public Guid ResourceId { get; set; }

    /// <summary>
    /// The type of principal (User, ServicePrincipal, or Group) receiving the role.
    /// Combined with ResourceDiscriminator to determine the specific entity type.
    /// </summary>
    public RoleAssignmentPrincipalDiscriminator PrincipalDiscriminator { get; set; }

    /// <summary>
    /// The type of resource (Organization, Stack, Namespace, or Module) where the role is assigned.
    /// Combined with PrincipalDiscriminator to determine the specific entity type.
    /// </summary>
    public ResourceDiscriminator ResourceDiscriminator { get; set; }

    /// <summary>
    /// The role being assigned, unified across all role enums (OrganizationRole, StackRole, NamespaceRole, ModuleRole).
    /// Mapper validates that the role is valid for the given discriminator.
    /// </summary>
    public AllRoles RoleName { get; set; }
}
