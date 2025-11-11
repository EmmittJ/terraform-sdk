using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateLinkServiceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPrivateLinkServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Alias => new TerraformReference(this, "alias");

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    [TerraformPropertyName("auto_approval_subscription_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AutoApprovalSubscriptionIds => new TerraformReference(this, "auto_approval_subscription_ids");

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    [TerraformPropertyName("enable_proxy_protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableProxyProtocol => new TerraformReference(this, "enable_proxy_protocol");

    /// <summary>
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_frontend_ip_configuration_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> LoadBalancerFrontendIpConfigurationIds => new TerraformReference(this, "load_balancer_frontend_ip_configuration_ids");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The nat_ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("nat_ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NatIpConfiguration => new TerraformReference(this, "nat_ip_configuration");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    [TerraformPropertyName("visibility_subscription_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> VisibilitySubscriptionIds => new TerraformReference(this, "visibility_subscription_ids");

}
