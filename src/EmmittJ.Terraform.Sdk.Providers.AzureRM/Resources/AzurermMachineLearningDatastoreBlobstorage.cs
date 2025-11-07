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
    public TerraformProperty<string>? AccountKey
    {
        get => GetProperty<TerraformProperty<string>>("account_key");
        set => this.WithProperty("account_key", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The is_default attribute.
    /// </summary>
    public TerraformProperty<bool>? IsDefault
    {
        get => GetProperty<TerraformProperty<bool>>("is_default");
        set => this.WithProperty("is_default", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The service_data_auth_identity attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceDataAuthIdentity
    {
        get => GetProperty<TerraformProperty<string>>("service_data_auth_identity");
        set => this.WithProperty("service_data_auth_identity", value);
    }

    /// <summary>
    /// The shared_access_signature attribute.
    /// </summary>
    public TerraformProperty<string>? SharedAccessSignature
    {
        get => GetProperty<TerraformProperty<string>>("shared_access_signature");
        set => this.WithProperty("shared_access_signature", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageContainerId
    {
        get => GetProperty<TerraformProperty<string>>("storage_container_id");
        set => this.WithProperty("storage_container_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

}
