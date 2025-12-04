using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for container in AzurermContainerGroup.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container";

    /// <summary>
    /// The commands attribute.
    /// </summary>
    public TerraformList<string> Commands
    {
        get => GetArgument<TerraformList<string>>("commands") ?? AsReference("commands");
        set => SetArgument("commands", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformValue<double> Cpu
    {
        get => GetRequiredArgument<TerraformValue<double>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The cpu_limit attribute.
    /// </summary>
    public TerraformValue<double>? CpuLimit
    {
        get => GetArgument<TerraformValue<double>>("cpu_limit");
        set => SetArgument("cpu_limit", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("environment_variables");
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => GetRequiredArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    public required TerraformValue<double> Memory
    {
        get => GetRequiredArgument<TerraformValue<double>>("memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    public TerraformValue<double>? MemoryLimit
    {
        get => GetArgument<TerraformValue<double>>("memory_limit");
        set => SetArgument("memory_limit", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The secure_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? SecureEnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("secure_environment_variables");
        set => SetArgument("secure_environment_variables", value);
    }

    /// <summary>
    /// LivenessProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LivenessProbe block(s) allowed")]
    public TerraformList<AzurermContainerGroupContainerBlockLivenessProbeBlock>? LivenessProbe
    {
        get => GetArgument<TerraformList<AzurermContainerGroupContainerBlockLivenessProbeBlock>>("liveness_probe");
        set => SetArgument("liveness_probe", value);
    }

    /// <summary>
    /// Ports block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermContainerGroupContainerBlockPortsBlock>? Ports
    {
        get => GetArgument<TerraformSet<AzurermContainerGroupContainerBlockPortsBlock>>("ports");
        set => SetArgument("ports", value);
    }

    /// <summary>
    /// ReadinessProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadinessProbe block(s) allowed")]
    public TerraformList<AzurermContainerGroupContainerBlockReadinessProbeBlock>? ReadinessProbe
    {
        get => GetArgument<TerraformList<AzurermContainerGroupContainerBlockReadinessProbeBlock>>("readiness_probe");
        set => SetArgument("readiness_probe", value);
    }

    /// <summary>
    /// Security block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerGroupContainerBlockSecurityBlock>? Security
    {
        get => GetArgument<TerraformList<AzurermContainerGroupContainerBlockSecurityBlock>>("security");
        set => SetArgument("security", value);
    }

    /// <summary>
    /// Volume block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerGroupContainerBlockVolumeBlock>? Volume
    {
        get => GetArgument<TerraformList<AzurermContainerGroupContainerBlockVolumeBlock>>("volume");
        set => SetArgument("volume", value);
    }

}

/// <summary>
/// Block type for liveness_probe in AzurermContainerGroupContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlockLivenessProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "liveness_probe";

    /// <summary>
    /// The exec attribute.
    /// </summary>
    public TerraformList<string>? Exec
    {
        get => GetArgument<TerraformList<string>>("exec");
        set => SetArgument("exec", value);
    }

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// The initial_delay_seconds attribute.
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// The period_seconds attribute.
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// The success_threshold attribute.
    /// </summary>
    public TerraformValue<double>? SuccessThreshold
    {
        get => GetArgument<TerraformValue<double>>("success_threshold");
        set => SetArgument("success_threshold", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerGroupContainerBlockLivenessProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<AzurermContainerGroupContainerBlockLivenessProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

}

/// <summary>
/// Block type for http_get in AzurermContainerGroupContainerBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlockLivenessProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// The http_headers attribute.
    /// </summary>
    public TerraformMap<string>? HttpHeaders
    {
        get => GetArgument<TerraformMap<string>>("http_headers");
        set => SetArgument("http_headers", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The scheme attribute.
    /// </summary>
    public TerraformValue<string>? Scheme
    {
        get => GetArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

}

/// <summary>
/// Block type for ports in AzurermContainerGroupContainerBlock.
/// Nesting mode: set
/// </summary>
public class AzurermContainerGroupContainerBlockPortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ports";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}

/// <summary>
/// Block type for readiness_probe in AzurermContainerGroupContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlockReadinessProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "readiness_probe";

    /// <summary>
    /// The exec attribute.
    /// </summary>
    public TerraformList<string>? Exec
    {
        get => GetArgument<TerraformList<string>>("exec");
        set => SetArgument("exec", value);
    }

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// The initial_delay_seconds attribute.
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// The period_seconds attribute.
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// The success_threshold attribute.
    /// </summary>
    public TerraformValue<double>? SuccessThreshold
    {
        get => GetArgument<TerraformValue<double>>("success_threshold");
        set => SetArgument("success_threshold", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerGroupContainerBlockReadinessProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<AzurermContainerGroupContainerBlockReadinessProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

}

/// <summary>
/// Block type for http_get in AzurermContainerGroupContainerBlockReadinessProbeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlockReadinessProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// The http_headers attribute.
    /// </summary>
    public TerraformMap<string>? HttpHeaders
    {
        get => GetArgument<TerraformMap<string>>("http_headers");
        set => SetArgument("http_headers", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The scheme attribute.
    /// </summary>
    public TerraformValue<string>? Scheme
    {
        get => GetArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

}

/// <summary>
/// Block type for security in AzurermContainerGroupContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlockSecurityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security";

    /// <summary>
    /// The privilege_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivilegeEnabled is required")]
    public required TerraformValue<bool> PrivilegeEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("privilege_enabled");
        set => SetArgument("privilege_enabled", value);
    }

}

/// <summary>
/// Block type for volume in AzurermContainerGroupContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlockVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume";

    /// <summary>
    /// The empty_dir attribute.
    /// </summary>
    public TerraformValue<bool>? EmptyDir
    {
        get => GetArgument<TerraformValue<bool>>("empty_dir");
        set => SetArgument("empty_dir", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformValue<string> MountPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformMap<string>? Secret
    {
        get => GetArgument<TerraformMap<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    public TerraformValue<string>? ShareName
    {
        get => GetArgument<TerraformValue<string>>("share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountKey
    {
        get => GetArgument<TerraformValue<string>>("storage_account_key");
        set => SetArgument("storage_account_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// GitRepo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepo block(s) allowed")]
    public TerraformList<AzurermContainerGroupContainerBlockVolumeBlockGitRepoBlock>? GitRepo
    {
        get => GetArgument<TerraformList<AzurermContainerGroupContainerBlockVolumeBlockGitRepoBlock>>("git_repo");
        set => SetArgument("git_repo", value);
    }

}

/// <summary>
/// Block type for git_repo in AzurermContainerGroupContainerBlockVolumeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlockVolumeBlockGitRepoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git_repo";

    /// <summary>
    /// The directory attribute.
    /// </summary>
    public TerraformValue<string>? Directory
    {
        get => GetArgument<TerraformValue<string>>("directory");
        set => SetArgument("directory", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformValue<string>? Revision
    {
        get => GetArgument<TerraformValue<string>>("revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for diagnostics in AzurermContainerGroup.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "diagnostics";

    /// <summary>
    /// LogAnalytics block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalytics is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LogAnalytics block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogAnalytics block(s) allowed")]
    public required TerraformList<AzurermContainerGroupDiagnosticsBlockLogAnalyticsBlock> LogAnalytics
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerGroupDiagnosticsBlockLogAnalyticsBlock>>("log_analytics");
        set => SetArgument("log_analytics", value);
    }

}

/// <summary>
/// Block type for log_analytics in AzurermContainerGroupDiagnosticsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupDiagnosticsBlockLogAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_analytics";

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    public TerraformValue<string>? LogType
    {
        get => GetArgument<TerraformValue<string>>("log_type");
        set => SetArgument("log_type", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The workspace_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceKey is required")]
    public required TerraformValue<string> WorkspaceKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_key");
        set => SetArgument("workspace_key", value);
    }

}


/// <summary>
/// Block type for dns_config in AzurermContainerGroup.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupDnsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_config";

    /// <summary>
    /// The nameservers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Nameservers is required")]
    public TerraformList<string>? Nameservers
    {
        get => GetArgument<TerraformList<string>>("nameservers");
        set => SetArgument("nameservers", value);
    }

    /// <summary>
    /// The options attribute.
    /// </summary>
    public TerraformSet<string>? Options
    {
        get => GetArgument<TerraformSet<string>>("options");
        set => SetArgument("options", value);
    }

    /// <summary>
    /// The search_domains attribute.
    /// </summary>
    public TerraformSet<string>? SearchDomains
    {
        get => GetArgument<TerraformSet<string>>("search_domains");
        set => SetArgument("search_domains", value);
    }

}


/// <summary>
/// Block type for identity in AzurermContainerGroup.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for image_registry_credential in AzurermContainerGroup.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupImageRegistryCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_registry_credential";

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => GetRequiredArgument<TerraformValue<string>>("server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The User Assigned Identity to use for Container Registry access.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for init_container in AzurermContainerGroup.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupInitContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "init_container";

    /// <summary>
    /// The commands attribute.
    /// </summary>
    public TerraformList<string> Commands
    {
        get => GetArgument<TerraformList<string>>("commands") ?? AsReference("commands");
        set => SetArgument("commands", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("environment_variables");
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => GetRequiredArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The secure_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? SecureEnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("secure_environment_variables");
        set => SetArgument("secure_environment_variables", value);
    }

    /// <summary>
    /// Security block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerGroupInitContainerBlockSecurityBlock>? Security
    {
        get => GetArgument<TerraformList<AzurermContainerGroupInitContainerBlockSecurityBlock>>("security");
        set => SetArgument("security", value);
    }

    /// <summary>
    /// Volume block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerGroupInitContainerBlockVolumeBlock>? Volume
    {
        get => GetArgument<TerraformList<AzurermContainerGroupInitContainerBlockVolumeBlock>>("volume");
        set => SetArgument("volume", value);
    }

}

/// <summary>
/// Block type for security in AzurermContainerGroupInitContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupInitContainerBlockSecurityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security";

    /// <summary>
    /// The privilege_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivilegeEnabled is required")]
    public required TerraformValue<bool> PrivilegeEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("privilege_enabled");
        set => SetArgument("privilege_enabled", value);
    }

}

/// <summary>
/// Block type for volume in AzurermContainerGroupInitContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupInitContainerBlockVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume";

    /// <summary>
    /// The empty_dir attribute.
    /// </summary>
    public TerraformValue<bool>? EmptyDir
    {
        get => GetArgument<TerraformValue<bool>>("empty_dir");
        set => SetArgument("empty_dir", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformValue<string> MountPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformMap<string>? Secret
    {
        get => GetArgument<TerraformMap<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    public TerraformValue<string>? ShareName
    {
        get => GetArgument<TerraformValue<string>>("share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountKey
    {
        get => GetArgument<TerraformValue<string>>("storage_account_key");
        set => SetArgument("storage_account_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// GitRepo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepo block(s) allowed")]
    public TerraformList<AzurermContainerGroupInitContainerBlockVolumeBlockGitRepoBlock>? GitRepo
    {
        get => GetArgument<TerraformList<AzurermContainerGroupInitContainerBlockVolumeBlockGitRepoBlock>>("git_repo");
        set => SetArgument("git_repo", value);
    }

}

/// <summary>
/// Block type for git_repo in AzurermContainerGroupInitContainerBlockVolumeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupInitContainerBlockVolumeBlockGitRepoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git_repo";

    /// <summary>
    /// The directory attribute.
    /// </summary>
    public TerraformValue<string>? Directory
    {
        get => GetArgument<TerraformValue<string>>("directory");
        set => SetArgument("directory", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformValue<string>? Revision
    {
        get => GetArgument<TerraformValue<string>>("revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermContainerGroup.
/// Nesting mode: single
/// </summary>
public class AzurermContainerGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_container_group Terraform resource.
/// Manages a azurerm_container_group resource.
/// </summary>
public partial class AzurermContainerGroup(string name) : TerraformResource("azurerm_container_group", name)
{
    /// <summary>
    /// The dns_name_label attribute.
    /// </summary>
    public TerraformValue<string>? DnsNameLabel
    {
        get => GetArgument<TerraformValue<string>>("dns_name_label");
        set => SetArgument("dns_name_label", value);
    }

    /// <summary>
    /// The dns_name_label_reuse_policy attribute.
    /// </summary>
    public TerraformValue<string>? DnsNameLabelReusePolicy
    {
        get => GetArgument<TerraformValue<string>>("dns_name_label_reuse_policy");
        set => SetArgument("dns_name_label_reuse_policy", value);
    }

    /// <summary>
    /// The exposed_port attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ExposedPort
    {
        get => GetArgument<TerraformSet<TerraformMap<object>>>("exposed_port") ?? AsReference("exposed_port");
        set => SetArgument("exposed_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultUserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_user_assigned_identity_id");
        set => SetArgument("key_vault_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_profile_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> NetworkProfileId
    {
        get => GetArgument<TerraformValue<string>>("network_profile_id") ?? AsReference("network_profile_id");
        set => SetArgument("network_profile_id", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    public required TerraformValue<string> OsType
    {
        get => GetRequiredArgument<TerraformValue<string>>("os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<string>? Priority
    {
        get => GetArgument<TerraformValue<string>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The restart_policy attribute.
    /// </summary>
    public TerraformValue<string>? RestartPolicy
    {
        get => GetArgument<TerraformValue<string>>("restart_policy");
        set => SetArgument("restart_policy", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => GetArgument<TerraformSet<string>>("zones");
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
        => AsReference("ip_address");

    /// <summary>
    /// Container block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    public required TerraformList<AzurermContainerGroupContainerBlock> Container
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerGroupContainerBlock>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// Diagnostics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Diagnostics block(s) allowed")]
    public TerraformList<AzurermContainerGroupDiagnosticsBlock>? Diagnostics
    {
        get => GetArgument<TerraformList<AzurermContainerGroupDiagnosticsBlock>>("diagnostics");
        set => SetArgument("diagnostics", value);
    }

    /// <summary>
    /// DnsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public TerraformList<AzurermContainerGroupDnsConfigBlock>? DnsConfig
    {
        get => GetArgument<TerraformList<AzurermContainerGroupDnsConfigBlock>>("dns_config");
        set => SetArgument("dns_config", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermContainerGroupIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermContainerGroupIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// ImageRegistryCredential block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerGroupImageRegistryCredentialBlock>? ImageRegistryCredential
    {
        get => GetArgument<TerraformList<AzurermContainerGroupImageRegistryCredentialBlock>>("image_registry_credential");
        set => SetArgument("image_registry_credential", value);
    }

    /// <summary>
    /// InitContainer block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerGroupInitContainerBlock>? InitContainer
    {
        get => GetArgument<TerraformList<AzurermContainerGroupInitContainerBlock>>("init_container");
        set => SetArgument("init_container", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
