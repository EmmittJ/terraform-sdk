using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rules in .
/// Nesting mode: set
/// </summary>
public class AzurermStorageObjectReplicationRulesBlock : ITerraformBlock
{
    /// <summary>
    /// The copy_blobs_created_after attribute.
    /// </summary>
    [TerraformPropertyName("copy_blobs_created_after")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CopyBlobsCreatedAfter { get; set; }

    /// <summary>
    /// The destination_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationContainerName is required")]
    [TerraformPropertyName("destination_container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestinationContainerName { get; set; }

    /// <summary>
    /// The filter_out_blobs_with_prefix attribute.
    /// </summary>
    [TerraformPropertyName("filter_out_blobs_with_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? FilterOutBlobsWithPrefix { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// The source_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceContainerName is required")]
    [TerraformPropertyName("source_container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceContainerName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageObjectReplicationTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_storage_object_replication resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStorageObjectReplication : TerraformResource
{
    public AzurermStorageObjectReplication(string name) : base("azurerm_storage_object_replication", name)
    {
    }

    /// <summary>
    /// The destination_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationStorageAccountId is required")]
    [TerraformPropertyName("destination_storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestinationStorageAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The source_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceStorageAccountId is required")]
    [TerraformPropertyName("source_storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceStorageAccountId { get; set; }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    [TerraformPropertyName("rules")]
    public TerraformSet<TerraformBlock<AzurermStorageObjectReplicationRulesBlock>>? Rules { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageObjectReplicationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The destination_object_replication_id attribute.
    /// </summary>
    [TerraformPropertyName("destination_object_replication_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DestinationObjectReplicationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destination_object_replication_id");

    /// <summary>
    /// The source_object_replication_id attribute.
    /// </summary>
    [TerraformPropertyName("source_object_replication_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceObjectReplicationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_object_replication_id");

}
