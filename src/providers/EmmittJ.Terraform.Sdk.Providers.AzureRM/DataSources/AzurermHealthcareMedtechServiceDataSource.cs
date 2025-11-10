using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_healthcare_medtech_service.
/// </summary>
public class AzurermHealthcareMedtechServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareMedtechServiceDataSource(string name) : base("azurerm_healthcare_medtech_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("device_mapping_json");
        SetOutput("eventhub_consumer_group_name");
        SetOutput("eventhub_name");
        SetOutput("eventhub_namespace_name");
        SetOutput("identity");
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
    public AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The device_mapping_json attribute.
    /// </summary>
    public TerraformExpression DeviceMappingJson => this["device_mapping_json"];

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public TerraformExpression EventhubConsumerGroupName => this["eventhub_consumer_group_name"];

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformExpression EventhubName => this["eventhub_name"];

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    public TerraformExpression EventhubNamespaceName => this["eventhub_namespace_name"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

}
