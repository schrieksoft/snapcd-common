using System.Text.Json.Serialization;

namespace SnapCd.Common;


public enum InputType
{
    String,
    NotString,
    Number,
    Bool,
    Tuple,
    Object
}

public enum InputKind
{
    Param,
    EnvVar
}

public enum DesiredStateHeadline
{
    Applied,
    Destroyed
}

public enum SourceType
{
    Git,
    Registry,
    S3,
    Http,
    Https,
    Gcs,
    Mercurial,
    Unknown
}

public enum SourceRevisionType
{
    Default,
    SemanticVersionRange
}

public enum WaitForApplyDependencies
{
    Always,
    Never,
    OnFirstApply
}

public enum WaitForDestroyDependencies
{
    Always,
    Never
}

public enum PrincipalDiscriminator
{
    User,
    ServicePrincipal
}

public enum DefinitionInputType
{
    StackId,
    StackName,
    NamespaceId,
    NamespaceName,
    ModuleId,
    ModuleName,
    SourceRevision,
    SourceUrl,
    SourceSubdirectory
}

public enum StateManagementEngine
{
    OpenTofu,
    Terraform,
    Pulumi
}

public enum PulumiCommandTask
{
    Init,
    Plan,
    Apply,
    Destroy,
    Output
}

public enum PulumiFlag
{
    // Init — Login
    CloudUrl,
    LoginLocal,
    LoginCloud,
    DefaultOrg,
    Insecure,
    OidcExpiration,
    OidcOrg,
    OidcTeam,
    OidcToken,
    OidcUser,

    // Init — Stack Select
    StackName,
    SecretsProvider,
    CreateStack,

    // Plan/Apply/Destroy shared
    ConfigFile,
    Debug,
    Diff,
    ExpectNoChanges,
    Json,
    Message,
    Parallel,
    Refresh,
    RunProgram,
    ShowConfig,
    ShowFullOutput,
    ShowReads,
    ShowReplacementSteps,
    ShowSames,
    ShowSecrets,
    SuppressOutputs,
    SuppressProgress,
    TargetDependents,
    ExcludeDependents,
    Neo,

    // Plan only
    ImportFile,

    // Apply only
    ContinueOnError,
    SkipPreview,
    Strict,

    // Destroy only
    ExcludeProtected,
    Remove,

    // Output
    Shell,

    // Global
    Color,
    Verbose,
    Emoji
}

public enum PulumiArrayFlag
{
    PolicyPack,
    PolicyPackConfig,
    AttachDebugger,
    Target,
    Replace,
    Exclude,
    TargetReplace,
    Config
}

public enum ResourceDiscriminator
{
    Organization,
    Stack,
    Namespace,
    Module,
    Runner
}

public enum AllRoles
{
    Owner,
    Contributor,
    Reader,
    IdentityAccessManager,
    JobManager,
    StackCreator,
    NamespaceCreator,
    ModuleCreator,
    SourceChangeNotifier
}

public enum StackTriggerBehaviour
{
    DoNotTrigger,
    TriggerAllImmediately
}

public enum OrganizationRole
{
    Owner,
    Contributor,
    Reader,
    StackCreator,
    IdentityAccessManager,
    JobManager,
    SourceChangeNotifier,
    SubscriptionManager,
}

public enum StackRole
{
    Owner,
    Contributor,
    Reader,
    NamespaceCreator,
    IdentityAccessManager,
    JobManager,
    SourceChangeNotifier
}

public enum NamespaceRole
{
    Owner,
    Contributor,
    Reader,
    ModuleCreator,
    IdentityAccessManager,
    JobManager,
    SourceChangeNotifier
}

public enum ModuleRole
{
    Owner,
    Contributor,
    Reader,
    IdentityAccessManager,
    JobManager,
    SourceChangeNotifier
}

public enum RunnerRole
{
    Owner,
    Contributor,
    Reader,
    IdentityAccessManager
}


public enum GroupMemberDiscriminator
{
    Base,
    User,
    ServicePrincipal,
    Group
}

public enum NamespaceTriggerBehaviour
{
    DoNotTrigger,
    TriggerAllImmediately
}

public enum NamespaceInputUsageMode
{
    UseIfSelected,
    UseByDefault
}

public enum RoleAssignmentPrincipalDiscriminator
{
    Base,
    User,
    ServicePrincipal,
    Group
}

public enum SecretDiscriminator
{
    StackSecret,
    NamespaceSecret,
    ModuleSecret,
    SecretOutput
}

public enum CancellationType
{
    AfterCurrent,
    ImmediateGraceful,
    ImmediateKill
}

public enum NamespaceInputSource
{
    Literal,
    Definition,
    NamespaceSecret
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ModuleInputSource
{
    Literal,
    ModuleOutput,
    NamespaceParam,
    Definition,
    ModuleOutputSet,
    ModuleSecret
}