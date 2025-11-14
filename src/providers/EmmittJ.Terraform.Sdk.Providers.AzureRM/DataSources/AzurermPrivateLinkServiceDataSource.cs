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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateLinkServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_private_link_service.
/// </summary>
public class AzurermPrivateLinkServiceDataSource : TerraformDataSource
{
    public AzurermPrivateLinkServiceDataSource(string name) : base("azurerm_private_link_service", name)
    {
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPrivateLinkServiceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformArgument("alias")]
    public TerraformValue<string> Alias
    {
        get => new TerraformReference<string>(this, "alias");
    }

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    [TerraformArgument("auto_approval_subscription_ids")]
    public TerraformList<string> AutoApprovalSubscriptionIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "auto_approval_subscription_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    [TerraformArgument("enable_proxy_protocol")]
    public TerraformValue<bool> EnableProxyProtocol
    {
        get => new TerraformReference<bool>(this, "enable_proxy_protocol");
    }

    /// <summary>
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    [TerraformArgument("load_balancer_frontend_ip_configuration_ids")]
    public TerraformList<string> LoadBalancerFrontendIpConfigurationIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "load_balancer_frontend_ip_configuration_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The nat_ip_configuration attribute.
    /// </summary>
    [TerraformArgument("nat_ip_configuration")]
    public TerraformList<object> NatIpConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "nat_ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    [TerraformArgument("visibility_subscription_ids")]
    public TerraformList<string> VisibilitySubscriptionIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "visibility_subscription_ids").ResolveNodes(ctx));
    }

}
