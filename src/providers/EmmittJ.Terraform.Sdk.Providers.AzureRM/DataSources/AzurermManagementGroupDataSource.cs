using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermManagementGroupDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_management_group.
/// </summary>
public partial class AzurermManagementGroupDataSource : TerraformDataSource
{
    public AzurermManagementGroupDataSource(string name) : base("azurerm_management_group", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermManagementGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The all_management_group_ids attribute.
    /// </summary>
    [TerraformProperty("all_management_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AllManagementGroupIds { get; }

    /// <summary>
    /// The all_subscription_ids attribute.
    /// </summary>
    [TerraformProperty("all_subscription_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AllSubscriptionIds { get; }

    /// <summary>
    /// The management_group_ids attribute.
    /// </summary>
    [TerraformProperty("management_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ManagementGroupIds { get; }

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    [TerraformProperty("parent_management_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ParentManagementGroupId { get; }

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    [TerraformProperty("subscription_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SubscriptionIds { get; }

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    [TerraformProperty("tenant_scoped_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TenantScopedId { get; }

}
