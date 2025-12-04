using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_persistent_disk in AzurermSpringCloudApp.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppCustomPersistentDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_persistent_disk";

    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    public TerraformSet<string>? MountOptions
    {
        get => GetArgument<TerraformSet<string>>("mount_options");
        set => SetArgument("mount_options", value);
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
    /// The read_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("read_only_enabled");
        set => SetArgument("read_only_enabled", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformValue<string> ShareName
    {
        get => GetRequiredArgument<TerraformValue<string>>("share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// The storage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageName is required")]
    public required TerraformValue<string> StorageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_name");
        set => SetArgument("storage_name", value);
    }

}


/// <summary>
/// Block type for identity in AzurermSpringCloudApp.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppIdentityBlock : TerraformBlock
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
/// Block type for ingress_settings in AzurermSpringCloudApp.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppIngressSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress_settings";

    /// <summary>
    /// The backend_protocol attribute.
    /// </summary>
    public TerraformValue<string>? BackendProtocol
    {
        get => GetArgument<TerraformValue<string>>("backend_protocol");
        set => SetArgument("backend_protocol", value);
    }

    /// <summary>
    /// The read_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? ReadTimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("read_timeout_in_seconds");
        set => SetArgument("read_timeout_in_seconds", value);
    }

    /// <summary>
    /// The send_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SendTimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("send_timeout_in_seconds");
        set => SetArgument("send_timeout_in_seconds", value);
    }

    /// <summary>
    /// The session_affinity attribute.
    /// </summary>
    public TerraformValue<string>? SessionAffinity
    {
        get => GetArgument<TerraformValue<string>>("session_affinity");
        set => SetArgument("session_affinity", value);
    }

    /// <summary>
    /// The session_cookie_max_age attribute.
    /// </summary>
    public TerraformValue<double>? SessionCookieMaxAge
    {
        get => GetArgument<TerraformValue<double>>("session_cookie_max_age");
        set => SetArgument("session_cookie_max_age", value);
    }

}


/// <summary>
/// Block type for persistent_disk in AzurermSpringCloudApp.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppPersistentDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "persistent_disk";

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformValue<string>? MountPath
    {
        get => GetArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGb is required")]
    public required TerraformValue<double> SizeInGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("size_in_gb");
        set => SetArgument("size_in_gb", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSpringCloudApp.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_spring_cloud_app Terraform resource.
/// Manages a azurerm_spring_cloud_app resource.
/// </summary>
public partial class AzurermSpringCloudApp(string name) : TerraformResource("azurerm_spring_cloud_app", name)
{
    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    public TerraformValue<string> AddonJson
    {
        get => GetArgument<TerraformValue<string>>("addon_json") ?? AsReference("addon_json");
        set => SetArgument("addon_json", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsOnly
    {
        get => GetArgument<TerraformValue<bool>>("https_only");
        set => SetArgument("https_only", value);
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
    /// The is_public attribute.
    /// </summary>
    public TerraformValue<bool>? IsPublic
    {
        get => GetArgument<TerraformValue<bool>>("is_public");
        set => SetArgument("is_public", value);
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
    /// The public_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_endpoint_enabled");
        set => SetArgument("public_endpoint_enabled", value);
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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_enabled");
        set => SetArgument("tls_enabled", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

    /// <summary>
    /// CustomPersistentDisk block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSpringCloudAppCustomPersistentDiskBlock>? CustomPersistentDisk
    {
        get => GetArgument<TerraformList<AzurermSpringCloudAppCustomPersistentDiskBlock>>("custom_persistent_disk");
        set => SetArgument("custom_persistent_disk", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermSpringCloudAppIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermSpringCloudAppIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// IngressSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressSettings block(s) allowed")]
    public TerraformList<AzurermSpringCloudAppIngressSettingsBlock>? IngressSettings
    {
        get => GetArgument<TerraformList<AzurermSpringCloudAppIngressSettingsBlock>>("ingress_settings");
        set => SetArgument("ingress_settings", value);
    }

    /// <summary>
    /// PersistentDisk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistentDisk block(s) allowed")]
    public TerraformList<AzurermSpringCloudAppPersistentDiskBlock>? PersistentDisk
    {
        get => GetArgument<TerraformList<AzurermSpringCloudAppPersistentDiskBlock>>("persistent_disk");
        set => SetArgument("persistent_disk", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudAppTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudAppTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
