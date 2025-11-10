using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_persistent_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppCustomPersistentDiskBlock : TerraformBlock
{
    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? MountOptions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("mount_options");
        set => WithProperty("mount_options", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformProperty<string> MountPath
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mount_path");
        set => WithProperty("mount_path", value);
    }

    /// <summary>
    /// The read_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ReadOnlyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("read_only_enabled");
        set => WithProperty("read_only_enabled", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformProperty<string> ShareName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("share_name");
        set => WithProperty("share_name", value);
    }

    /// <summary>
    /// The storage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageName is required")]
    public required TerraformProperty<string> StorageName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_name");
        set => WithProperty("storage_name", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for ingress_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppIngressSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The backend_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? BackendProtocol
    {
        get => GetProperty<TerraformProperty<string>>("backend_protocol");
        set => WithProperty("backend_protocol", value);
    }

    /// <summary>
    /// The read_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ReadTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("read_timeout_in_seconds");
        set => WithProperty("read_timeout_in_seconds", value);
    }

    /// <summary>
    /// The send_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SendTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("send_timeout_in_seconds");
        set => WithProperty("send_timeout_in_seconds", value);
    }

    /// <summary>
    /// The session_affinity attribute.
    /// </summary>
    public TerraformProperty<string>? SessionAffinity
    {
        get => GetProperty<TerraformProperty<string>>("session_affinity");
        set => WithProperty("session_affinity", value);
    }

    /// <summary>
    /// The session_cookie_max_age attribute.
    /// </summary>
    public TerraformProperty<double>? SessionCookieMaxAge
    {
        get => GetProperty<TerraformProperty<double>>("session_cookie_max_age");
        set => WithProperty("session_cookie_max_age", value);
    }

}

/// <summary>
/// Block type for persistent_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppPersistentDiskBlock : TerraformBlock
{
    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformProperty<string>? MountPath
    {
        get => GetProperty<TerraformProperty<string>>("mount_path");
        set => WithProperty("mount_path", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGb is required")]
    public required TerraformProperty<double> SizeInGb
    {
        get => GetRequiredProperty<TerraformProperty<double>>("size_in_gb");
        set => WithProperty("size_in_gb", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputqdn");
        this.WithOutputrl");
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    public TerraformProperty<string>? AddonJson
    {
        get => GetProperty<TerraformProperty<string>>("addon_json");
        set => this.WithProperty("addon_json", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("https_only");
        set => this.WithProperty("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The is_public attribute.
    /// </summary>
    public TerraformProperty<bool>? IsPublic
    {
        get => GetProperty<TerraformProperty<bool>>("is_public");
        set => this.WithProperty("is_public", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_endpoint_enabled");
        set => this.WithProperty("public_endpoint_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_enabled");
        set => this.WithProperty("tls_enabled", value);
    }

    /// <summary>
    /// Block for custom_persistent_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSpringCloudAppCustomPersistentDiskBlock>? CustomPersistentDisk
    {
        get => GetProperty<List<AzurermSpringCloudAppCustomPersistentDiskBlock>>("custom_persistent_disk");
        set => this.WithProperty("custom_persistent_disk", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermSpringCloudAppIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermSpringCloudAppIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for ingress_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressSettings block(s) allowed")]
    public List<AzurermSpringCloudAppIngressSettingsBlock>? IngressSettings
    {
        get => GetProperty<List<AzurermSpringCloudAppIngressSettingsBlock>>("ingress_settings");
        set => this.WithProperty("ingress_settings", value);
    }

    /// <summary>
    /// Block for persistent_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistentDisk block(s) allowed")]
    public List<AzurermSpringCloudAppPersistentDiskBlock>? PersistentDisk
    {
        get => GetProperty<List<AzurermSpringCloudAppPersistentDiskBlock>>("persistent_disk");
        set => this.WithProperty("persistent_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudAppTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudAppTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
