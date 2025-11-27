using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ServicePrincipals;

/// <summary>
/// DTO for updating an existing ServicePrincipal (PUT operations).
/// </summary>
public class ServicePrincipalUpdateDto : ServicePrincipalCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
