using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_web_pubsub_private_link_resource.
/// </summary>
public class AzurermWebPubsubPrivateLinkResourceDataSource : TerraformDataSource
{
    public AzurermWebPubsubPrivateLinkResourceDataSource(string name) : base("azurerm_web_pubsub_private_link_resource", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    [TerraformPropertyName("web_pubsub_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WebPubsubId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The shared_private_link_resource_types attribute.
    /// </summary>
    [TerraformPropertyName("shared_private_link_resource_types")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SharedPrivateLinkResourceTypes => new TerraformReference(this, "shared_private_link_resource_types");

}
