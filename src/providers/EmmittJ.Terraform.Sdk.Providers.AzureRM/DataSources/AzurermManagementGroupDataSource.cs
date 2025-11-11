using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_management_group.
/// </summary>
public class AzurermManagementGroupDataSource : TerraformDataSource
{
    public AzurermManagementGroupDataSource(string name) : base("azurerm_management_group", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermManagementGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The all_management_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("all_management_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AllManagementGroupIds => new TerraformReference(this, "all_management_group_ids");

    /// <summary>
    /// The all_subscription_ids attribute.
    /// </summary>
    [TerraformPropertyName("all_subscription_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AllSubscriptionIds => new TerraformReference(this, "all_subscription_ids");

    /// <summary>
    /// The management_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("management_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ManagementGroupIds => new TerraformReference(this, "management_group_ids");

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_management_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParentManagementGroupId => new TerraformReference(this, "parent_management_group_id");

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    [TerraformPropertyName("subscription_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SubscriptionIds => new TerraformReference(this, "subscription_ids");

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_scoped_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TenantScopedId => new TerraformReference(this, "tenant_scoped_id");

}
