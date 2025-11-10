using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rules in .
/// Nesting mode: set
/// </summary>
public class AzurermStorageObjectReplicationRulesBlock : TerraformBlock
{
    /// <summary>
    /// The copy_blobs_created_after attribute.
    /// </summary>
    public TerraformProperty<string>? CopyBlobsCreatedAfter
    {
        get => GetProperty<TerraformProperty<string>>("copy_blobs_created_after");
        set => WithProperty("copy_blobs_created_after", value);
    }

    /// <summary>
    /// The destination_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationContainerName is required")]
    public required TerraformProperty<string> DestinationContainerName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("destination_container_name");
        set => WithProperty("destination_container_name", value);
    }

    /// <summary>
    /// The filter_out_blobs_with_prefix attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? FilterOutBlobsWithPrefix
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("filter_out_blobs_with_prefix");
        set => WithProperty("filter_out_blobs_with_prefix", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The source_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceContainerName is required")]
    public required TerraformProperty<string> SourceContainerName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_container_name");
        set => WithProperty("source_container_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageObjectReplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputestination_object_replication_id");
        this.WithOutputource_object_replication_id");
    }

    /// <summary>
    /// The destination_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationStorageAccountId is required")]
    public required TerraformProperty<string> DestinationStorageAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("destination_storage_account_id");
        set => this.WithProperty("destination_storage_account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The source_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceStorageAccountId is required")]
    public required TerraformProperty<string> SourceStorageAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_storage_account_id");
        set => this.WithProperty("source_storage_account_id", value);
    }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public HashSet<AzurermStorageObjectReplicationRulesBlock>? Rules
    {
        get => GetProperty<HashSet<AzurermStorageObjectReplicationRulesBlock>>("rules");
        set => this.WithProperty("rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageObjectReplicationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageObjectReplicationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The destination_object_replication_id attribute.
    /// </summary>
    public TerraformExpression DestinationObjectReplicationId => this["destination_object_replication_id"];

    /// <summary>
    /// The source_object_replication_id attribute.
    /// </summary>
    public TerraformExpression SourceObjectReplicationId => this["source_object_replication_id"];

}
