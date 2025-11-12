using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rules in .
/// Nesting mode: set
/// </summary>
public partial class AzurermStorageObjectReplicationRulesBlock() : TerraformBlock("rules")
{
    /// <summary>
    /// The copy_blobs_created_after attribute.
    /// </summary>
    [TerraformProperty("copy_blobs_created_after")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CopyBlobsCreatedAfter { get; set; }

    /// <summary>
    /// The destination_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationContainerName is required")]
    [TerraformProperty("destination_container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationContainerName { get; set; }

    /// <summary>
    /// The filter_out_blobs_with_prefix attribute.
    /// </summary>
    [TerraformProperty("filter_out_blobs_with_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? FilterOutBlobsWithPrefix { get; set; }


    /// <summary>
    /// The source_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceContainerName is required")]
    [TerraformProperty("source_container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceContainerName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageObjectReplicationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_storage_object_replication resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStorageObjectReplication : TerraformResource
{
    public AzurermStorageObjectReplication(string name) : base("azurerm_storage_object_replication", name)
    {
    }

    /// <summary>
    /// The destination_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationStorageAccountId is required")]
    [TerraformProperty("destination_storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationStorageAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The source_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceStorageAccountId is required")]
    [TerraformProperty("source_storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceStorageAccountId { get; set; }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    [TerraformProperty("rules")]
    public required TerraformSet<AzurermStorageObjectReplicationRulesBlock> Rules { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStorageObjectReplicationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The destination_object_replication_id attribute.
    /// </summary>
    [TerraformProperty("destination_object_replication_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DestinationObjectReplicationId { get; }

    /// <summary>
    /// The source_object_replication_id attribute.
    /// </summary>
    [TerraformProperty("source_object_replication_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceObjectReplicationId { get; }

}
