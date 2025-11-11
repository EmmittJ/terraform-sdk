using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_web_pubsub_private_link_resource.
/// </summary>
public partial class AzurermWebPubsubPrivateLinkResourceDataSource : TerraformDataSource
{
    public AzurermWebPubsubPrivateLinkResourceDataSource(string name) : base("azurerm_web_pubsub_private_link_resource", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    [TerraformProperty("web_pubsub_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WebPubsubId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The shared_private_link_resource_types attribute.
    /// </summary>
    [TerraformProperty("shared_private_link_resource_types")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SharedPrivateLinkResourceTypes { get; }

}
