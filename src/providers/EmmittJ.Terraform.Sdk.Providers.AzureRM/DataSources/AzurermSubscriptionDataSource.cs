using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_subscription.
/// </summary>
public class AzurermSubscriptionDataSource : TerraformDataSource
{
    public AzurermSubscriptionDataSource(string name) : base("azurerm_subscription", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformPropertyName("subscription_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubscriptionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subscription_id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSubscriptionDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The location_placement_id attribute.
    /// </summary>
    [TerraformPropertyName("location_placement_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocationPlacementId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location_placement_id");

    /// <summary>
    /// The quota_id attribute.
    /// </summary>
    [TerraformPropertyName("quota_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QuotaId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "quota_id");

    /// <summary>
    /// The spending_limit attribute.
    /// </summary>
    [TerraformPropertyName("spending_limit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SpendingLimit => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "spending_limit");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenant_id");

}
