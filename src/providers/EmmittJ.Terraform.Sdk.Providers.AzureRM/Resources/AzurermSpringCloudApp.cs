using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for custom_persistent_disk in .
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
    [TerraformArgument("mount_options")]
    public TerraformSet<string>? MountOptions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "mount_options").ResolveNodes(ctx));
        set => SetArgument("mount_options", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    [TerraformArgument("mount_path")]
    public required TerraformValue<string> MountPath
    {
        get => new TerraformReference<string>(this, "mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// The read_only_enabled attribute.
    /// </summary>
    [TerraformArgument("read_only_enabled")]
    public TerraformValue<bool>? ReadOnlyEnabled
    {
        get => new TerraformReference<bool>(this, "read_only_enabled");
        set => SetArgument("read_only_enabled", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformArgument("share_name")]
    public required TerraformValue<string> ShareName
    {
        get => new TerraformReference<string>(this, "share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// The storage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageName is required")]
    [TerraformArgument("storage_name")]
    public required TerraformValue<string> StorageName
    {
        get => new TerraformReference<string>(this, "storage_name");
        set => SetArgument("storage_name", value);
    }

}

/// <summary>
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for ingress_settings in .
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
    [TerraformArgument("backend_protocol")]
    public TerraformValue<string>? BackendProtocol
    {
        get => new TerraformReference<string>(this, "backend_protocol");
        set => SetArgument("backend_protocol", value);
    }

    /// <summary>
    /// The read_timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("read_timeout_in_seconds")]
    public TerraformValue<double>? ReadTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "read_timeout_in_seconds");
        set => SetArgument("read_timeout_in_seconds", value);
    }

    /// <summary>
    /// The send_timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("send_timeout_in_seconds")]
    public TerraformValue<double>? SendTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "send_timeout_in_seconds");
        set => SetArgument("send_timeout_in_seconds", value);
    }

    /// <summary>
    /// The session_affinity attribute.
    /// </summary>
    [TerraformArgument("session_affinity")]
    public TerraformValue<string>? SessionAffinity
    {
        get => new TerraformReference<string>(this, "session_affinity");
        set => SetArgument("session_affinity", value);
    }

    /// <summary>
    /// The session_cookie_max_age attribute.
    /// </summary>
    [TerraformArgument("session_cookie_max_age")]
    public TerraformValue<double>? SessionCookieMaxAge
    {
        get => new TerraformReference<double>(this, "session_cookie_max_age");
        set => SetArgument("session_cookie_max_age", value);
    }

}

/// <summary>
/// Block type for persistent_disk in .
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
    [TerraformArgument("mount_path")]
    public TerraformValue<string>? MountPath
    {
        get => new TerraformReference<string>(this, "mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGb is required")]
    [TerraformArgument("size_in_gb")]
    public required TerraformValue<double> SizeInGb
    {
        get => new TerraformReference<double>(this, "size_in_gb");
        set => SetArgument("size_in_gb", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_spring_cloud_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudApp : TerraformResource
{
    public AzurermSpringCloudApp(string name) : base("azurerm_spring_cloud_app", name)
    {
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    [TerraformArgument("addon_json")]
    public TerraformValue<string> AddonJson
    {
        get => new TerraformReference<string>(this, "addon_json");
        set => SetArgument("addon_json", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformArgument("https_only")]
    public TerraformValue<bool>? HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
        set => SetArgument("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_public attribute.
    /// </summary>
    [TerraformArgument("is_public")]
    public TerraformValue<bool>? IsPublic
    {
        get => new TerraformReference<bool>(this, "is_public");
        set => SetArgument("is_public", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_endpoint_enabled attribute.
    /// </summary>
    [TerraformArgument("public_endpoint_enabled")]
    public TerraformValue<bool>? PublicEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "public_endpoint_enabled");
        set => SetArgument("public_endpoint_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformArgument("service_name")]
    public required TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_enabled")]
    public TerraformValue<bool>? TlsEnabled
    {
        get => new TerraformReference<bool>(this, "tls_enabled");
        set => SetArgument("tls_enabled", value);
    }

    /// <summary>
    /// Block for custom_persistent_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("custom_persistent_disk")]
    public TerraformList<AzurermSpringCloudAppCustomPersistentDiskBlock> CustomPersistentDisk { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermSpringCloudAppIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for ingress_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressSettings block(s) allowed")]
    [TerraformArgument("ingress_settings")]
    public TerraformList<AzurermSpringCloudAppIngressSettingsBlock> IngressSettings { get; set; } = new();

    /// <summary>
    /// Block for persistent_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistentDisk block(s) allowed")]
    [TerraformArgument("persistent_disk")]
    public TerraformList<AzurermSpringCloudAppPersistentDiskBlock> PersistentDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudAppTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

}
