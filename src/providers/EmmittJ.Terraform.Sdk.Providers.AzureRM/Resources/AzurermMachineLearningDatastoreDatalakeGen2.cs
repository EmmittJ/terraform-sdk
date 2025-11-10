using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningDatastoreDatalakeGen2TimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_machine_learning_datastore_datalake_gen2 resource.
/// </summary>
public class AzurermMachineLearningDatastoreDatalakeGen2 : TerraformResource
{
    public AzurermMachineLearningDatastoreDatalakeGen2(string name) : base("azurerm_machine_learning_datastore_datalake_gen2", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("is_default");
        SetOutput("authority_url");
        SetOutput("client_id");
        SetOutput("client_secret");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("service_data_identity");
        SetOutput("storage_container_id");
        SetOutput("tags");
        SetOutput("tenant_id");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The authority_url attribute.
    /// </summary>
    public TerraformProperty<string> AuthorityUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authority_url");
        set => SetProperty("authority_url", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformProperty<string> ClientSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_secret");
        set => SetProperty("client_secret", value);
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
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    public required TerraformProperty<string> StorageContainerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_container_id");
        set => SetProperty("storage_container_id", value);
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
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string> TenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant_id");
        set => SetProperty("tenant_id", value);
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
    public AzurermMachineLearningDatastoreDatalakeGen2TimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

}
