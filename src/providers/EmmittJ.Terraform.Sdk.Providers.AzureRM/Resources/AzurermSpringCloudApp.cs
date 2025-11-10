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
        set => SetProperty("mount_options", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformProperty<string> MountPath
    {
        set => SetProperty("mount_path", value);
    }

    /// <summary>
    /// The read_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ReadOnlyEnabled
    {
        set => SetProperty("read_only_enabled", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformProperty<string> ShareName
    {
        set => SetProperty("share_name", value);
    }

    /// <summary>
    /// The storage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageName is required")]
    public required TerraformProperty<string> StorageName
    {
        set => SetProperty("storage_name", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("backend_protocol", value);
    }

    /// <summary>
    /// The read_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ReadTimeoutInSeconds
    {
        set => SetProperty("read_timeout_in_seconds", value);
    }

    /// <summary>
    /// The send_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SendTimeoutInSeconds
    {
        set => SetProperty("send_timeout_in_seconds", value);
    }

    /// <summary>
    /// The session_affinity attribute.
    /// </summary>
    public TerraformProperty<string>? SessionAffinity
    {
        set => SetProperty("session_affinity", value);
    }

    /// <summary>
    /// The session_cookie_max_age attribute.
    /// </summary>
    public TerraformProperty<double>? SessionCookieMaxAge
    {
        set => SetProperty("session_cookie_max_age", value);
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
        set => SetProperty("mount_path", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGb is required")]
    public required TerraformProperty<double> SizeInGb
    {
        set => SetProperty("size_in_gb", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("fqdn");
        SetOutput("url");
        SetOutput("addon_json");
        SetOutput("https_only");
        SetOutput("id");
        SetOutput("is_public");
        SetOutput("name");
        SetOutput("public_endpoint_enabled");
        SetOutput("resource_group_name");
        SetOutput("service_name");
        SetOutput("tls_enabled");
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    public TerraformProperty<string> AddonJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("addon_json");
        set => SetProperty("addon_json", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformProperty<bool> HttpsOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("https_only");
        set => SetProperty("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The is_public attribute.
    /// </summary>
    public TerraformProperty<bool> IsPublic
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_public");
        set => SetProperty("is_public", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicEndpointEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_endpoint_enabled");
        set => SetProperty("public_endpoint_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TlsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tls_enabled");
        set => SetProperty("tls_enabled", value);
    }

    /// <summary>
    /// Block for custom_persistent_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSpringCloudAppCustomPersistentDiskBlock>? CustomPersistentDisk
    {
        set => SetProperty("custom_persistent_disk", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermSpringCloudAppIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for ingress_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressSettings block(s) allowed")]
    public List<AzurermSpringCloudAppIngressSettingsBlock>? IngressSettings
    {
        set => SetProperty("ingress_settings", value);
    }

    /// <summary>
    /// Block for persistent_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistentDisk block(s) allowed")]
    public List<AzurermSpringCloudAppPersistentDiskBlock>? PersistentDisk
    {
        set => SetProperty("persistent_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudAppTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
