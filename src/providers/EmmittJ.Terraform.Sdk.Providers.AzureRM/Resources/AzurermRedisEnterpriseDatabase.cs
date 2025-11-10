using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for module in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisEnterpriseDatabaseModuleBlock : ITerraformBlock
{
    /// <summary>
    /// The args attribute.
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Args { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>("", "version");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisEnterpriseDatabaseTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_redis_enterprise_database resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermRedisEnterpriseDatabase : TerraformResource
{
    public AzurermRedisEnterpriseDatabase(string name) : base("azurerm_redis_enterprise_database", name)
    {
    }

    /// <summary>
    /// The client_protocol attribute.
    /// </summary>
    [TerraformPropertyName("client_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientProtocol { get; set; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterId { get; set; }

    /// <summary>
    /// The clustering_policy attribute.
    /// </summary>
    [TerraformPropertyName("clustering_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusteringPolicy { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformPropertyName("eviction_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EvictionPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The linked_database_group_nickname attribute.
    /// </summary>
    [TerraformPropertyName("linked_database_group_nickname")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LinkedDatabaseGroupNickname { get; set; }

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    [TerraformPropertyName("linked_database_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? LinkedDatabaseId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// Block for module.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 Module block(s) allowed")]
    [TerraformPropertyName("module")]
    public TerraformList<TerraformBlock<AzurermRedisEnterpriseDatabaseModuleBlock>>? Module { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRedisEnterpriseDatabaseTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_access_key");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_access_key");

}
