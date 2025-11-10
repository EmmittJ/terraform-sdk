using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? DisplayNameContains { get; set; }

    /// <summary>
    /// The display_name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("display_name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayNamePrefix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSubscriptionsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The subscriptions attribute.
    /// </summary>
    [TerraformPropertyName("subscriptions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Subscriptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "subscriptions");

}
