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
        set => SetProperty("copy_blobs_created_after", value);
    }

    /// <summary>
    /// The destination_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationContainerName is required")]
    public required TerraformProperty<string> DestinationContainerName
    {
        set => SetProperty("destination_container_name", value);
    }

    /// <summary>
    /// The filter_out_blobs_with_prefix attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? FilterOutBlobsWithPrefix
    {
        set => SetProperty("filter_out_blobs_with_prefix", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The source_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceContainerName is required")]
    public required TerraformProperty<string> SourceContainerName
    {
        set => SetProperty("source_container_name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("destination_object_replication_id");
        SetOutput("source_object_replication_id");
        SetOutput("destination_storage_account_id");
        SetOutput("id");
        SetOutput("source_storage_account_id");
    }

    /// <summary>
    /// The destination_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationStorageAccountId is required")]
    public required TerraformProperty<string> DestinationStorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_storage_account_id");
        set => SetProperty("destination_storage_account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The source_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceStorageAccountId is required")]
    public required TerraformProperty<string> SourceStorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_storage_account_id");
        set => SetProperty("source_storage_account_id", value);
    }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public HashSet<AzurermStorageObjectReplicationRulesBlock>? Rules
    {
        set => SetProperty("rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageObjectReplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
