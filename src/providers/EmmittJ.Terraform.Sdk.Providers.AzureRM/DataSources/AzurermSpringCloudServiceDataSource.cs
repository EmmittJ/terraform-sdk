using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudServiceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_spring_cloud_service.
/// </summary>
public partial class AzurermSpringCloudServiceDataSource : TerraformDataSource
{
    public AzurermSpringCloudServiceDataSource(string name) : base("azurerm_spring_cloud_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSpringCloudServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The config_server_git_setting attribute.
    /// </summary>
    [TerraformProperty("config_server_git_setting")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ConfigServerGitSetting { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The outbound_public_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("outbound_public_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> OutboundPublicIpAddresses { get; }

    /// <summary>
    /// The required_network_traffic_rules attribute.
    /// </summary>
    [TerraformProperty("required_network_traffic_rules")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RequiredNetworkTrafficRules { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

}
