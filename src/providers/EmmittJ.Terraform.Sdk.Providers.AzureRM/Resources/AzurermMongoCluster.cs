using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMongoClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_mongo_cluster resource.
/// </summary>
public partial class AzurermMongoCluster : TerraformResource
{
    public AzurermMongoCluster(string name) : base("azurerm_mongo_cluster", name)
    {
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    [TerraformProperty("administrator_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorPassword { get; set; }

    /// <summary>
    /// The administrator_username attribute.
    /// </summary>
    [TerraformProperty("administrator_username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorUsername { get; set; }

    /// <summary>
    /// The compute_tier attribute.
    /// </summary>
    [TerraformProperty("compute_tier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComputeTier { get; set; }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformProperty("create_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CreateMode { get; set; }

    /// <summary>
    /// The high_availability_mode attribute.
    /// </summary>
    [TerraformProperty("high_availability_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HighAvailabilityMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The preview_features attribute.
    /// </summary>
    [TerraformProperty("preview_features")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PreviewFeatures { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicNetworkAccess { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    [TerraformProperty("shard_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ShardCount { get; set; }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    [TerraformProperty("source_location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceLocation { get; set; }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    [TerraformProperty("source_server_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceServerId { get; set; }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [TerraformProperty("storage_size_in_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? StorageSizeInGb { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMongoClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    [TerraformProperty("connection_strings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ConnectionStrings { get; }

}
