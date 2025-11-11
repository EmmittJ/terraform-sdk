using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSubscriptionsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_subscriptions.
/// </summary>
public partial class AzurermSubscriptionsDataSource : TerraformDataSource
{
    public AzurermSubscriptionsDataSource(string name) : base("azurerm_subscriptions", name)
    {
    }

    /// <summary>
    /// The display_name_contains attribute.
    /// </summary>
    [TerraformProperty("display_name_contains")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayNameContains { get; set; }

    /// <summary>
    /// The display_name_prefix attribute.
    /// </summary>
    [TerraformProperty("display_name_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayNamePrefix { get; set; }

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
    public TerraformBlock<AzurermSubscriptionsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The subscriptions attribute.
    /// </summary>
    [TerraformProperty("subscriptions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Subscriptions { get; }

}
