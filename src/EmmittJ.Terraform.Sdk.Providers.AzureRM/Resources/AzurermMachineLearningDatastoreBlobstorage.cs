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
    public string? AccountKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_key")?.Value;
        set => this.WithProperty("account_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The is_default attribute.
    /// </summary>
    public bool? IsDefault
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_default")?.Value;
        set => this.WithProperty("is_default", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_data_auth_identity attribute.
    /// </summary>
    public string? ServiceDataAuthIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_data_auth_identity")?.Value;
        set => this.WithProperty("service_data_auth_identity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shared_access_signature attribute.
    /// </summary>
    public string? SharedAccessSignature
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_access_signature")?.Value;
        set => this.WithProperty("shared_access_signature", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    public string? StorageContainerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_id")?.Value;
        set => this.WithProperty("storage_container_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
