using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisEnterpriseDatabaseDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_redis_enterprise_database.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class AzurermRedisEnterpriseDatabaseDataSource : TerraformDataSource
{
    public AzurermRedisEnterpriseDatabaseDataSource(string name) : base("azurerm_redis_enterprise_database", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRedisEnterpriseDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The linked_database_group_nickname attribute.
    /// </summary>
    [TerraformPropertyName("linked_database_group_nickname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LinkedDatabaseGroupNickname => new TerraformReference(this, "linked_database_group_nickname");

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    [TerraformPropertyName("linked_database_id")]
    // Output-only attribute - read-only reference
    public TerraformList<string> LinkedDatabaseId => new TerraformReference(this, "linked_database_id");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryAccessKey => new TerraformReference(this, "primary_access_key");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAccessKey => new TerraformReference(this, "secondary_access_key");

}
