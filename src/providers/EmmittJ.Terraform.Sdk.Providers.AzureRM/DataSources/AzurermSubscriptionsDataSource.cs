using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_subscriptions.
/// </summary>
public class AzurermSubscriptionsDataSource : TerraformDataSource
{
    public AzurermSubscriptionsDataSource(string name) : base("azurerm_subscriptions", name)
    {
    }

    /// <summary>
    /// The display_name_contains attribute.
    /// </summary>
    [TerraformPropertyName("display_name_contains")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayNameContains { get; set; }

    /// <summary>
    /// The display_name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("display_name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayNamePrefix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSubscriptionsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The subscriptions attribute.
    /// </summary>
    [TerraformPropertyName("subscriptions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Subscriptions => new TerraformReference(this, "subscriptions");

}
