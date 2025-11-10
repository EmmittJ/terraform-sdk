using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermManagementGroupDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The all_management_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("all_management_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AllManagementGroupIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "all_management_group_ids");

    /// <summary>
    /// The all_subscription_ids attribute.
    /// </summary>
    [TerraformPropertyName("all_subscription_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AllSubscriptionIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "all_subscription_ids");

    /// <summary>
    /// The management_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("management_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ManagementGroupIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "management_group_ids");

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_management_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParentManagementGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent_management_group_id");

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    [TerraformPropertyName("subscription_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SubscriptionIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "subscription_ids");

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_scoped_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantScopedId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenant_scoped_id");

}
