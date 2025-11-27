using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ServicePrincipals;

/// <summary>
/// DTO for ServicePrincipal responses (GET operations).
/// </summary>
public class ServicePrincipalReadDto : ServicePrincipalCreateDto, IDto
{
    public Guid Id { get; set; }
}
