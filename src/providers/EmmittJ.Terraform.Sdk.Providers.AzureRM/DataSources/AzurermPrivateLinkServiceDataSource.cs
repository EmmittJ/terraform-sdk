using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPrivateLinkServiceDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_private_link_service.
/// </summary>
public partial class AzurermPrivateLinkServiceDataSource : TerraformDataSource
{
    public AzurermPrivateLinkServiceDataSource(string name) : base("azurerm_private_link_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPrivateLinkServiceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Alias { get; }

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    [TerraformProperty("auto_approval_subscription_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AutoApprovalSubscriptionIds { get; }

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    [TerraformProperty("enable_proxy_protocol")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableProxyProtocol { get; }

    /// <summary>
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    [TerraformProperty("load_balancer_frontend_ip_configuration_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> LoadBalancerFrontendIpConfigurationIds { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The nat_ip_configuration attribute.
    /// </summary>
    [TerraformProperty("nat_ip_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NatIpConfiguration { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    [TerraformProperty("visibility_subscription_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> VisibilitySubscriptionIds { get; }

}
