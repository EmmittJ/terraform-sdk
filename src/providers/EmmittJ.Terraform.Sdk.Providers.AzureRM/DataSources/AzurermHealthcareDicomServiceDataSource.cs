using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareDicomServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_dicom_service.
/// </summary>
public class AzurermHealthcareDicomServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareDicomServiceDataSource(string name) : base("azurerm_healthcare_dicom_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authentication");
        SetOutput("cors");
        SetOutput("data_partitions_enabled");
        SetOutput("encryption_key_url");
        SetOutput("identity");
        SetOutput("location");
        SetOutput("private_endpoint");
        SetOutput("service_url");
        SetOutput("storage");
        SetOutput("tags");
        SetOutput("id");
        SetOutput("name");
        SetOutput("workspace_id");
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
    public AzurermHealthcareDicomServiceDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    public TerraformExpression Authentication => this["authentication"];

    /// <summary>
    /// The cors attribute.
    /// </summary>
    public TerraformExpression Cors => this["cors"];

    /// <summary>
    /// The data_partitions_enabled attribute.
    /// </summary>
    public TerraformExpression DataPartitionsEnabled => this["data_partitions_enabled"];

    /// <summary>
    /// The encryption_key_url attribute.
    /// </summary>
    public TerraformExpression EncryptionKeyUrl => this["encryption_key_url"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    public TerraformExpression PrivateEndpoint => this["private_endpoint"];

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformExpression ServiceUrl => this["service_url"];

    /// <summary>
    /// The storage attribute.
    /// </summary>
    public TerraformExpression Storage => this["storage"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
