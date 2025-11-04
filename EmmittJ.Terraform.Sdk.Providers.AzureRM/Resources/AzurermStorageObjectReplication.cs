using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_object_replication resource.
/// </summary>
public class AzurermStorageObjectReplication : TerraformResource
{
    public AzurermStorageObjectReplication(string name) : base("azurerm_storage_object_replication", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("destination_object_replication_id");
        this.DeclareOutput("source_object_replication_id");
    }

    /// <summary>
    /// The destination_storage_account_id attribute.
    /// </summary>
    public string? DestinationStorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_storage_account_id")?.Value;
        set => this.WithProperty("destination_storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_storage_account_id attribute.
    /// </summary>
    public string? SourceStorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_storage_account_id")?.Value;
        set => this.WithProperty("source_storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
