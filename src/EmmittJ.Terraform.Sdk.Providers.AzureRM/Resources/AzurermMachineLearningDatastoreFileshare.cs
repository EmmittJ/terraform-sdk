using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_machine_learning_datastore_fileshare resource.
/// </summary>
public class AzurermMachineLearningDatastoreFileshare : TerraformResource
{
    public AzurermMachineLearningDatastoreFileshare(string name) : base("azurerm_machine_learning_datastore_fileshare", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("is_default");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The service_data_identity attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceDataIdentity
    {
        get => GetProperty<TerraformProperty<string>>("service_data_identity");
        set => this.WithProperty("service_data_identity", value);
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
    /// The storage_fileshare_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageFileshareId
    {
        get => GetProperty<TerraformProperty<string>>("storage_fileshare_id");
        set => this.WithProperty("storage_fileshare_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

}
