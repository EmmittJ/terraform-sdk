using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudServiceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_spring_cloud_service.
/// </summary>
public class AzurermSpringCloudServiceDataSource : TerraformDataSource
{
    public AzurermSpringCloudServiceDataSource(string name) : base("azurerm_spring_cloud_service", name)
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
    public TerraformBlock<AzurermSpringCloudServiceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The config_server_git_setting attribute.
    /// </summary>
    [TerraformPropertyName("config_server_git_setting")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConfigServerGitSetting => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "config_server_git_setting");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The outbound_public_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_public_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> OutboundPublicIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "outbound_public_ip_addresses");

    /// <summary>
    /// The required_network_traffic_rules attribute.
    /// </summary>
    [TerraformPropertyName("required_network_traffic_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RequiredNetworkTrafficRules => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "required_network_traffic_rules");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
