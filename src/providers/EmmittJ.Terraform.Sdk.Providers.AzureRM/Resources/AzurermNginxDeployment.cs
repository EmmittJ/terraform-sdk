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
        get => GetRequiredProperty<TerraformProperty<double>>("max_capacity");
        set => WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        get => GetRequiredProperty<TerraformProperty<double>>("min_capacity");
        set => WithProperty("min_capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("allocation_method");
        set => WithProperty("allocation_method", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformProperty<string> IpAddress
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ip_address");
        set => WithProperty("ip_address", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("ip_address");
        set => WithProperty("ip_address", value);
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
        get => GetProperty<TerraformProperty<string>>("container_name");
        set => WithProperty("container_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
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
        get => GetRequiredProperty<TerraformProperty<bool>>("activation_state_enabled");
        set => WithProperty("activation_state_enabled", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public List<TerraformProperty<object>>? Status
    {
        get => GetProperty<List<TerraformProperty<object>>>("status");
        set => WithProperty("status", value);
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
        this.WithOutput("dataplane_api_endpoint");
        this.WithOutput("ip_address");
        this.WithOutput("nginx_version");
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public TerraformProperty<string>? AutomaticUpgradeChannel
    {
        get => GetProperty<TerraformProperty<string>>("automatic_upgrade_channel");
        set => this.WithProperty("automatic_upgrade_channel", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double>? Capacity
    {
        get => GetProperty<TerraformProperty<double>>("capacity");
        set => this.WithProperty("capacity", value);
    }

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DiagnoseSupportEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("diagnose_support_enabled");
        set => this.WithProperty("diagnose_support_enabled", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => this.WithProperty("email", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? ManagedResourceGroup
    {
        get => GetProperty<TerraformProperty<string>>("managed_resource_group");
        set => this.WithProperty("managed_resource_group", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for auto_scale_profile.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNginxDeploymentAutoScaleProfileBlock>? AutoScaleProfile
    {
        get => GetProperty<List<AzurermNginxDeploymentAutoScaleProfileBlock>>("auto_scale_profile");
        set => this.WithProperty("auto_scale_profile", value);
    }

    /// <summary>
    /// Block for frontend_private.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNginxDeploymentFrontendPrivateBlock>? FrontendPrivate
    {
        get => GetProperty<List<AzurermNginxDeploymentFrontendPrivateBlock>>("frontend_private");
        set => this.WithProperty("frontend_private", value);
    }

    /// <summary>
    /// Block for frontend_public.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendPublic block(s) allowed")]
    public List<AzurermNginxDeploymentFrontendPublicBlock>? FrontendPublic
    {
        get => GetProperty<List<AzurermNginxDeploymentFrontendPublicBlock>>("frontend_public");
        set => this.WithProperty("frontend_public", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermNginxDeploymentIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermNginxDeploymentIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for logging_storage_account.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public List<AzurermNginxDeploymentLoggingStorageAccountBlock>? LoggingStorageAccount
    {
        get => GetProperty<List<AzurermNginxDeploymentLoggingStorageAccountBlock>>("logging_storage_account");
        set => this.WithProperty("logging_storage_account", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNginxDeploymentNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetProperty<List<AzurermNginxDeploymentNetworkInterfaceBlock>>("network_interface");
        set => this.WithProperty("network_interface", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNginxDeploymentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNginxDeploymentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for web_application_firewall.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebApplicationFirewall block(s) allowed")]
    public List<AzurermNginxDeploymentWebApplicationFirewallBlock>? WebApplicationFirewall
    {
        get => GetProperty<List<AzurermNginxDeploymentWebApplicationFirewallBlock>>("web_application_firewall");
        set => this.WithProperty("web_application_firewall", value);
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
