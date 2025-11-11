using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSubscriptionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_subscription resource.
/// </summary>
public partial class AzurermSubscription : TerraformResource
{
    public AzurermSubscription(string name) : base("azurerm_subscription", name)
    {
    }

    /// <summary>
    /// The Alias Name of the subscription. If omitted a new UUID will be generated for this property.
    /// </summary>
    [TerraformProperty("alias")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Alias { get; set; }

    /// <summary>
    /// The billing_scope_id attribute.
    /// </summary>
    [TerraformProperty("billing_scope_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BillingScopeId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The GUID of the Subscription.
    /// </summary>
    [TerraformProperty("subscription_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubscriptionId { get; set; }

    /// <summary>
    /// The Display Name for the Subscription.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionName is required")]
    [TerraformProperty("subscription_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubscriptionName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The workload type for the Subscription. Possible values are `Production` (default) and `DevTest`.
    /// </summary>
    [TerraformProperty("workload")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Workload { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSubscriptionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The Tenant ID to which the subscription belongs
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TenantId { get; }

}
