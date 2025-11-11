using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for module in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedisEnterpriseDatabaseModuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The args attribute.
    /// </summary>
    [TerraformProperty("args")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Args { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRedisEnterpriseDatabaseTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_redis_enterprise_database resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermRedisEnterpriseDatabase : TerraformResource
{
    public AzurermRedisEnterpriseDatabase(string name) : base("azurerm_redis_enterprise_database", name)
    {
    }

    /// <summary>
    /// The client_protocol attribute.
    /// </summary>
    [TerraformProperty("client_protocol")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientProtocol { get; set; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The clustering_policy attribute.
    /// </summary>
    [TerraformProperty("clustering_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClusteringPolicy { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformProperty("eviction_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EvictionPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The linked_database_group_nickname attribute.
    /// </summary>
    [TerraformProperty("linked_database_group_nickname")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LinkedDatabaseGroupNickname { get; set; }

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    [TerraformProperty("linked_database_id")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? LinkedDatabaseId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Block for module.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 Module block(s) allowed")]
    [TerraformProperty("module")]
    public TerraformList<TerraformBlock<AzurermRedisEnterpriseDatabaseModuleBlock>>? Module { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermRedisEnterpriseDatabaseTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryAccessKey { get; }

}
