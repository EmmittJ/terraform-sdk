using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateLinkServiceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPrivateLinkServiceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Alias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "alias");

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    [TerraformPropertyName("auto_approval_subscription_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AutoApprovalSubscriptionIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "auto_approval_subscription_ids");

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    [TerraformPropertyName("enable_proxy_protocol")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableProxyProtocol => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_proxy_protocol");

    /// <summary>
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_frontend_ip_configuration_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> LoadBalancerFrontendIpConfigurationIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "load_balancer_frontend_ip_configuration_ids");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The nat_ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("nat_ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NatIpConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "nat_ip_configuration");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    [TerraformPropertyName("visibility_subscription_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VisibilitySubscriptionIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "visibility_subscription_ids");

}
