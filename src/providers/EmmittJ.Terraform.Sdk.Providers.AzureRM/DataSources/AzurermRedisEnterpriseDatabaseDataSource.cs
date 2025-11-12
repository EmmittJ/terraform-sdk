using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRedisEnterpriseDatabaseDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_redis_enterprise_database.
/// </summary>
[Obsolete("This data source is deprecated.")]
public partial class AzurermRedisEnterpriseDatabaseDataSource : TerraformDataSource
{
    public AzurermRedisEnterpriseDatabaseDataSource(string name) : base("azurerm_redis_enterprise_database", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermRedisEnterpriseDatabaseDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The linked_database_group_nickname attribute.
    /// </summary>
    [TerraformProperty("linked_database_group_nickname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LinkedDatabaseGroupNickname { get; }

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    [TerraformProperty("linked_database_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> LinkedDatabaseId { get; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryAccessKey { get; }

}
