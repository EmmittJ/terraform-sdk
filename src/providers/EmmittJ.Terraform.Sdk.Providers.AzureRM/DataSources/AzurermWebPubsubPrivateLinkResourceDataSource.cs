using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    [TerraformPropertyName("web_pubsub_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WebPubsubId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The shared_private_link_resource_types attribute.
    /// </summary>
    [TerraformPropertyName("shared_private_link_resource_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SharedPrivateLinkResourceTypes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "shared_private_link_resource_types");

}
