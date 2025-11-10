using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermClientConfigDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_client_config.
/// </summary>
public class AzurermClientConfigDataSource : TerraformDataSource
{
    public AzurermClientConfigDataSource(string name) : base("azurerm_client_config", name)
    {
    }

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
    public TerraformBlock<AzurermClientConfigDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_id");

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformPropertyName("subscription_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubscriptionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subscription_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenant_id");

}
