using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDashboardGrafanaManagedPrivateEndpointTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_dashboard_grafana_managed_private_endpoint resource.
/// </summary>
public partial class AzurermDashboardGrafanaManagedPrivateEndpoint : TerraformResource
{
    public AzurermDashboardGrafanaManagedPrivateEndpoint(string name) : base("azurerm_dashboard_grafana_managed_private_endpoint", name)
    {
    }

    /// <summary>
    /// The grafana_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrafanaId is required")]
    [TerraformProperty("grafana_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GrafanaId { get; set; }

    /// <summary>
    /// The group_ids attribute.
    /// </summary>
    [TerraformProperty("group_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? GroupIds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_link_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateLinkResourceId is required")]
    [TerraformProperty("private_link_resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrivateLinkResourceId { get; set; }

    /// <summary>
    /// The private_link_resource_region attribute.
    /// </summary>
    [TerraformProperty("private_link_resource_region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateLinkResourceRegion { get; set; }

    /// <summary>
    /// The private_link_service_url attribute.
    /// </summary>
    [TerraformProperty("private_link_service_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateLinkServiceUrl { get; set; }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    [TerraformProperty("request_message")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RequestMessage { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDashboardGrafanaManagedPrivateEndpointTimeoutsBlock>? Timeouts { get; set; }

}
