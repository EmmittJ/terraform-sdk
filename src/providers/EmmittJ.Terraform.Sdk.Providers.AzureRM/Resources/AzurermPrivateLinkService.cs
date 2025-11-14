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
/// Block type for nat_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermPrivateLinkServiceNatIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nat_ip_configuration";

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
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    [TerraformArgument("primary")]
    public required TerraformValue<bool> Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformArgument("private_ip_address")]
    public TerraformValue<string>? PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_address_version attribute.
    /// </summary>
    [TerraformArgument("private_ip_address_version")]
    public TerraformValue<string>? PrivateIpAddressVersion
    {
        get => new TerraformReference<string>(this, "private_ip_address_version");
        set => SetArgument("private_ip_address_version", value);
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateLinkServiceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_private_link_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPrivateLinkService : TerraformResource
{
    public AzurermPrivateLinkService(string name) : base("azurerm_private_link_service", name)
    {
    }

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    [TerraformArgument("auto_approval_subscription_ids")]
    public TerraformSet<string>? AutoApprovalSubscriptionIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "auto_approval_subscription_ids").ResolveNodes(ctx));
        set => SetArgument("auto_approval_subscription_ids", value);
    }

    /// <summary>
    /// The destination_ip_address attribute.
    /// </summary>
    [TerraformArgument("destination_ip_address")]
    public TerraformValue<string>? DestinationIpAddress
    {
        get => new TerraformReference<string>(this, "destination_ip_address");
        set => SetArgument("destination_ip_address", value);
    }

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    [TerraformArgument("enable_proxy_protocol")]
    public TerraformValue<bool>? EnableProxyProtocol
    {
        get => new TerraformReference<bool>(this, "enable_proxy_protocol");
        set => SetArgument("enable_proxy_protocol", value);
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    [TerraformArgument("fqdns")]
    public TerraformList<string>? Fqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "fqdns").ResolveNodes(ctx));
        set => SetArgument("fqdns", value);
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
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    [TerraformArgument("load_balancer_frontend_ip_configuration_ids")]
    public TerraformSet<string>? LoadBalancerFrontendIpConfigurationIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "load_balancer_frontend_ip_configuration_ids").ResolveNodes(ctx));
        set => SetArgument("load_balancer_frontend_ip_configuration_ids", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    [TerraformArgument("visibility_subscription_ids")]
    public TerraformSet<string>? VisibilitySubscriptionIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "visibility_subscription_ids").ResolveNodes(ctx));
        set => SetArgument("visibility_subscription_ids", value);
    }

    /// <summary>
    /// Block for nat_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NatIpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 NatIpConfiguration block(s) allowed")]
    [TerraformArgument("nat_ip_configuration")]
    public required TerraformList<AzurermPrivateLinkServiceNatIpConfigurationBlock> NatIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPrivateLinkServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformArgument("alias")]
    public TerraformValue<string> Alias
    {
        get => new TerraformReference<string>(this, "alias");
    }

}
