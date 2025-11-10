using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auto_scale_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentAutoScaleProfileBlock : TerraformBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformProperty<double> MaxCapacity
    {
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        set => SetProperty("min_capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for frontend_private in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentFrontendPrivateBlock : TerraformBlock
{
    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationMethod is required")]
    public required TerraformProperty<string> AllocationMethod
    {
        set => SetProperty("allocation_method", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformProperty<string> IpAddress
    {
        set => SetProperty("ip_address", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for frontend_public in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentFrontendPublicBlock : TerraformBlock
{
    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IpAddress
    {
        set => SetProperty("ip_address", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentIdentityBlock : TerraformBlock
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
/// Block type for logging_storage_account in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermNginxDeploymentLoggingStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerName
    {
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxDeploymentTimeoutsBlock : TerraformBlock
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
/// Block type for web_application_firewall in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentWebApplicationFirewallBlock : TerraformBlock
{
    /// <summary>
    /// The activation_state_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActivationStateEnabled is required")]
    public required TerraformProperty<bool> ActivationStateEnabled
    {
        set => SetProperty("activation_state_enabled", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public List<TerraformProperty<object>>? Status
    {
        set => SetProperty("status", value);
    }

}

/// <summary>
/// Manages a azurerm_nginx_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNginxDeployment : TerraformResource
{
    public AzurermNginxDeployment(string name) : base("azurerm_nginx_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dataplane_api_endpoint");
        SetOutput("ip_address");
        SetOutput("nginx_version");
        SetOutput("automatic_upgrade_channel");
        SetOutput("capacity");
        SetOutput("diagnose_support_enabled");
        SetOutput("email");
        SetOutput("id");
        SetOutput("location");
        SetOutput("managed_resource_group");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("tags");
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public TerraformProperty<string> AutomaticUpgradeChannel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("automatic_upgrade_channel");
        set => SetProperty("automatic_upgrade_channel", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double> Capacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("capacity");
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DiagnoseSupportEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("diagnose_support_enabled");
        set => SetProperty("diagnose_support_enabled", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string> Email
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email");
        set => SetProperty("email", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> ManagedResourceGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_resource_group");
        set => SetProperty("managed_resource_group", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for auto_scale_profile.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNginxDeploymentAutoScaleProfileBlock>? AutoScaleProfile
    {
        set => SetProperty("auto_scale_profile", value);
    }

    /// <summary>
    /// Block for frontend_private.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNginxDeploymentFrontendPrivateBlock>? FrontendPrivate
    {
        set => SetProperty("frontend_private", value);
    }

    /// <summary>
    /// Block for frontend_public.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendPublic block(s) allowed")]
    public List<AzurermNginxDeploymentFrontendPublicBlock>? FrontendPublic
    {
        set => SetProperty("frontend_public", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermNginxDeploymentIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for logging_storage_account.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public List<AzurermNginxDeploymentLoggingStorageAccountBlock>? LoggingStorageAccount
    {
        set => SetProperty("logging_storage_account", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNginxDeploymentNetworkInterfaceBlock>? NetworkInterface
    {
        set => SetProperty("network_interface", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNginxDeploymentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for web_application_firewall.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebApplicationFirewall block(s) allowed")]
    public List<AzurermNginxDeploymentWebApplicationFirewallBlock>? WebApplicationFirewall
    {
        set => SetProperty("web_application_firewall", value);
    }

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    public TerraformExpression DataplaneApiEndpoint => this["dataplane_api_endpoint"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    public TerraformExpression NginxVersion => this["nginx_version"];

}
