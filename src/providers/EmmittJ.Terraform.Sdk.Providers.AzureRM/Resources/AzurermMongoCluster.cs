using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMongoClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mongo_cluster resource.
/// </summary>
public class AzurermMongoCluster : TerraformResource
{
    public AzurermMongoCluster(string name) : base("azurerm_mongo_cluster", name)
    {
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    [TerraformPropertyName("administrator_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdministratorPassword { get; set; }

    /// <summary>
    /// The administrator_username attribute.
    /// </summary>
    [TerraformPropertyName("administrator_username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdministratorUsername { get; set; }

    /// <summary>
    /// The compute_tier attribute.
    /// </summary>
    [TerraformPropertyName("compute_tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ComputeTier { get; set; }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformPropertyName("create_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreateMode { get; set; }

    /// <summary>
    /// The high_availability_mode attribute.
    /// </summary>
    [TerraformPropertyName("high_availability_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HighAvailabilityMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The preview_features attribute.
    /// </summary>
    [TerraformPropertyName("preview_features")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PreviewFeatures { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicNetworkAccess { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    [TerraformPropertyName("shard_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ShardCount { get; set; }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    [TerraformPropertyName("source_location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceLocation { get; set; }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    [TerraformPropertyName("source_server_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceServerId { get; set; }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("storage_size_in_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? StorageSizeInGb { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMongoClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    [TerraformPropertyName("connection_strings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConnectionStrings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "connection_strings");

}
