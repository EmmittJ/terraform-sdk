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
/// Block type for auto_scale_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentAutoScaleProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_scale_profile";

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformArgument("max_capacity")]
    public required TerraformValue<double> MaxCapacity
    {
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformArgument("min_capacity")]
    public required TerraformValue<double> MinCapacity
    {
        get => new TerraformReference<double>(this, "min_capacity");
        set => SetArgument("min_capacity", value);
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

}

/// <summary>
/// Block type for frontend_private in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentFrontendPrivateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_private";

    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationMethod is required")]
    [TerraformArgument("allocation_method")]
    public required TerraformValue<string> AllocationMethod
    {
        get => new TerraformReference<string>(this, "allocation_method");
        set => SetArgument("allocation_method", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    [TerraformArgument("ip_address")]
    public required TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for frontend_public in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentFrontendPublicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_public";

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformArgument("ip_address")]
    public TerraformList<string>? IpAddress
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ip_address").ResolveNodes(ctx));
        set => SetArgument("ip_address", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentIdentityBlock : TerraformBlock
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
/// Block type for logging_storage_account in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermNginxDeploymentLoggingStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_storage_account";

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [TerraformArgument("container_name")]
    public TerraformValue<string>? ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface";

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxDeploymentTimeoutsBlock : TerraformBlock
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
/// Block type for web_application_firewall in .
/// Nesting mode: list
/// </summary>
public class AzurermNginxDeploymentWebApplicationFirewallBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_application_firewall";

    /// <summary>
    /// The activation_state_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActivationStateEnabled is required")]
    [TerraformArgument("activation_state_enabled")]
    public required TerraformValue<bool> ActivationStateEnabled
    {
        get => new TerraformReference<bool>(this, "activation_state_enabled");
        set => SetArgument("activation_state_enabled", value);
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
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    [TerraformArgument("automatic_upgrade_channel")]
    public TerraformValue<string>? AutomaticUpgradeChannel
    {
        get => new TerraformReference<string>(this, "automatic_upgrade_channel");
        set => SetArgument("automatic_upgrade_channel", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformArgument("capacity")]
    public TerraformValue<double>? Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    [TerraformArgument("diagnose_support_enabled")]
    public TerraformValue<bool>? DiagnoseSupportEnabled
    {
        get => new TerraformReference<bool>(this, "diagnose_support_enabled");
        set => SetArgument("diagnose_support_enabled", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformArgument("email")]
    public TerraformValue<string>? Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("managed_resource_group")]
    public TerraformValue<string> ManagedResourceGroup
    {
        get => new TerraformReference<string>(this, "managed_resource_group");
        set => SetArgument("managed_resource_group", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for auto_scale_profile.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("auto_scale_profile")]
    public TerraformList<AzurermNginxDeploymentAutoScaleProfileBlock> AutoScaleProfile { get; set; } = new();

    /// <summary>
    /// Block for frontend_private.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("frontend_private")]
    public TerraformList<AzurermNginxDeploymentFrontendPrivateBlock> FrontendPrivate { get; set; } = new();

    /// <summary>
    /// Block for frontend_public.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendPublic block(s) allowed")]
    [TerraformArgument("frontend_public")]
    public TerraformList<AzurermNginxDeploymentFrontendPublicBlock> FrontendPublic { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermNginxDeploymentIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for logging_storage_account.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformArgument("logging_storage_account")]
    public TerraformList<AzurermNginxDeploymentLoggingStorageAccountBlock> LoggingStorageAccount { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("network_interface")]
    public TerraformList<AzurermNginxDeploymentNetworkInterfaceBlock> NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNginxDeploymentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for web_application_firewall.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebApplicationFirewall block(s) allowed")]
    [TerraformArgument("web_application_firewall")]
    public TerraformList<AzurermNginxDeploymentWebApplicationFirewallBlock> WebApplicationFirewall { get; set; } = new();

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    [TerraformArgument("dataplane_api_endpoint")]
    public TerraformValue<string> DataplaneApiEndpoint
    {
        get => new TerraformReference<string>(this, "dataplane_api_endpoint");
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformArgument("ip_address")]
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    [TerraformArgument("nginx_version")]
    public TerraformValue<string> NginxVersion
    {
        get => new TerraformReference<string>(this, "nginx_version");
    }

}
