using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbMongoCollectionAutoscaleSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_throughput attribute.
    /// </summary>
    [TerraformProperty("max_throughput")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxThroughput { get; set; }

}

/// <summary>
/// Block type for index in .
/// Nesting mode: set
/// </summary>
public partial class AzurermCosmosdbMongoCollectionIndexBlock : TerraformBlockBase
{
    /// <summary>
    /// The keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keys is required")]
    [TerraformProperty("keys")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? Keys { get; set; }

    /// <summary>
    /// The unique attribute.
    /// </summary>
    [TerraformProperty("unique")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Unique { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCosmosdbMongoCollectionTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_cosmosdb_mongo_collection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCosmosdbMongoCollection : TerraformResource
{
    public AzurermCosmosdbMongoCollection(string name) : base("azurerm_cosmosdb_mongo_collection", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    [TerraformProperty("analytical_storage_ttl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? AnalyticalStorageTtl { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The default_ttl_seconds attribute.
    /// </summary>
    [TerraformProperty("default_ttl_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DefaultTtlSeconds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The shard_key attribute.
    /// </summary>
    [TerraformProperty("shard_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ShardKey { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Throughput { get; set; }

    /// <summary>
    /// Block for autoscale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    [TerraformProperty("autoscale_settings")]
    public TerraformList<TerraformBlock<AzurermCosmosdbMongoCollectionAutoscaleSettingsBlock>>? AutoscaleSettings { get; set; }

    /// <summary>
    /// Block for index.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("index")]
    public TerraformSet<TerraformBlock<AzurermCosmosdbMongoCollectionIndexBlock>>? Index { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermCosmosdbMongoCollectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The system_indexes attribute.
    /// </summary>
    [TerraformProperty("system_indexes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SystemIndexes { get; }

}
