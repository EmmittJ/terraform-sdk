using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? CopyBlobsCreatedAfter
    {
        get => new TerraformReference<string>(this, "copy_blobs_created_after");
        set => SetArgument("copy_blobs_created_after", value);
    }

    /// <summary>
    /// The destination_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationContainerName is required")]
    public required TerraformValue<string> DestinationContainerName
    {
        get => new TerraformReference<string>(this, "destination_container_name");
        set => SetArgument("destination_container_name", value);
    }

    /// <summary>
    /// The filter_out_blobs_with_prefix attribute.
    /// </summary>
    public TerraformSet<string>? FilterOutBlobsWithPrefix
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "filter_out_blobs_with_prefix").ResolveNodes(ctx));
        set => SetArgument("filter_out_blobs_with_prefix", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The source_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceContainerName is required")]
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_storage_object_replication Terraform resource.
/// Manages a azurerm_storage_object_replication resource.
/// </summary>
public partial class AzurermStorageObjectReplication(string name) : TerraformResource("azurerm_storage_object_replication", name)
{
    /// <summary>
    /// The destination_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationStorageAccountId is required")]
    public required TerraformValue<string> DestinationStorageAccountId
    {
        get => new TerraformReference<string>(this, "destination_storage_account_id");
        set => SetArgument("destination_storage_account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The source_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceStorageAccountId is required")]
    public required TerraformValue<string> SourceStorageAccountId
    {
        get => new TerraformReference<string>(this, "source_storage_account_id");
        set => SetArgument("source_storage_account_id", value);
    }

    /// <summary>
    /// The destination_object_replication_id attribute.
    /// </summary>
    public TerraformValue<string> DestinationObjectReplicationId
    {
        get => new TerraformReference<string>(this, "destination_object_replication_id");
    }

    /// <summary>
    /// The source_object_replication_id attribute.
    /// </summary>
    public TerraformValue<string> SourceObjectReplicationId
    {
        get => new TerraformReference<string>(this, "source_object_replication_id");
    }

    /// <summary>
    /// Rules block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformSet<AzurermStorageObjectReplicationRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformSet<AzurermStorageObjectReplicationRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageObjectReplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageObjectReplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
