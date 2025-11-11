using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermClientConfigDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_client_config.
/// </summary>
public partial class AzurermClientConfigDataSource : TerraformDataSource
{
    public AzurermClientConfigDataSource(string name) : base("azurerm_client_config", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermClientConfigDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClientId { get; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformProperty("object_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ObjectId { get; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformProperty("subscription_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubscriptionId { get; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TenantId { get; }

}
