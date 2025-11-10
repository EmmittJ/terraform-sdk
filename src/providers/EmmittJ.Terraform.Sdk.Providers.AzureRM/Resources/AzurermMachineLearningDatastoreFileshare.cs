using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningDatastoreFileshareTimeoutsBlock : TerraformBlock
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
        SetOutput("is_default");
        SetOutput("account_key");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("service_data_identity");
        SetOutput("shared_access_signature");
        SetOutput("storage_fileshare_id");
        SetOutput("tags");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The account_key attribute.
    /// </summary>
    public TerraformProperty<string> AccountKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_key");
        set => SetProperty("account_key", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The service_data_identity attribute.
    /// </summary>
    public TerraformProperty<string> ServiceDataIdentity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_data_identity");
        set => SetProperty("service_data_identity", value);
    }

    /// <summary>
    /// The shared_access_signature attribute.
    /// </summary>
    public TerraformProperty<string> SharedAccessSignature
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shared_access_signature");
        set => SetProperty("shared_access_signature", value);
    }

    /// <summary>
    /// The storage_fileshare_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageFileshareId is required")]
    public required TerraformProperty<string> StorageFileshareId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_fileshare_id");
        set => SetProperty("storage_fileshare_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMachineLearningDatastoreFileshareTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

}
