using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for rules in .
/// Nesting mode: set
/// </summary>
public class AzurermStorageObjectReplicationRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// The copy_blobs_created_after attribute.
    /// </summary>
    [TerraformArgument("copy_blobs_created_after")]
    public TerraformValue<string>? CopyBlobsCreatedAfter
    {
        get => new TerraformReference<string>(this, "copy_blobs_created_after");
        set => SetArgument("copy_blobs_created_after", value);
    }

    /// <summary>
    /// The destination_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationContainerName is required")]
    [TerraformArgument("destination_container_name")]
    public required TerraformValue<string> DestinationContainerName
    {
        get => new TerraformReference<string>(this, "destination_container_name");
        set => SetArgument("destination_container_name", value);
    }

    /// <summary>
    /// The filter_out_blobs_with_prefix attribute.
    /// </summary>
    [TerraformArgument("filter_out_blobs_with_prefix")]
    public TerraformSet<string>? FilterOutBlobsWithPrefix
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "filter_out_blobs_with_prefix").ResolveNodes(ctx));
        set => SetArgument("filter_out_blobs_with_prefix", value);
    }


    /// <summary>
    /// The source_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceContainerName is required")]
    [TerraformArgument("source_container_name")]
    public required TerraformValue<string> SourceContainerName
    {
        get => new TerraformReference<string>(this, "source_container_name");
        set => SetArgument("source_container_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageObjectReplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("destination_storage_account_id")]
    public required TerraformValue<string> DestinationStorageAccountId
    {
        get => new TerraformReference<string>(this, "destination_storage_account_id");
        set => SetArgument("destination_storage_account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The source_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceStorageAccountId is required")]
    [TerraformArgument("source_storage_account_id")]
    public required TerraformValue<string> SourceStorageAccountId
    {
        get => new TerraformReference<string>(this, "source_storage_account_id");
        set => SetArgument("source_storage_account_id", value);
    }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    [TerraformArgument("rules")]
    public required TerraformSet<AzurermStorageObjectReplicationRulesBlock> Rules { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageObjectReplicationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The destination_object_replication_id attribute.
    /// </summary>
    [TerraformArgument("destination_object_replication_id")]
    public TerraformValue<string> DestinationObjectReplicationId
    {
        get => new TerraformReference<string>(this, "destination_object_replication_id");
    }

    /// <summary>
    /// The source_object_replication_id attribute.
    /// </summary>
    [TerraformArgument("source_object_replication_id")]
    public TerraformValue<string> SourceObjectReplicationId
    {
        get => new TerraformReference<string>(this, "source_object_replication_id");
    }

}
