using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_machine_learning_datastore_blobstorage resource.
/// </summary>
public class AzurermMachineLearningDatastoreBlobstorage : TerraformResource
{
    public AzurermMachineLearningDatastoreBlobstorage(string name) : base("azurerm_machine_learning_datastore_blobstorage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_key");
        set => this.WithProperty("account_key", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IsDefault
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_default");
        set => this.WithProperty("is_default", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The service_data_auth_identity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceDataAuthIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_data_auth_identity");
        set => this.WithProperty("service_data_auth_identity", value);
    }

    /// <summary>
    /// The shared_access_signature attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SharedAccessSignature
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_access_signature");
        set => this.WithProperty("shared_access_signature", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageContainerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_id");
        set => this.WithProperty("storage_container_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

}
