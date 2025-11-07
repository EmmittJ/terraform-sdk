using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("device_mapping_json");
        this.DeclareOutput("eventhub_consumer_group_name");
        this.DeclareOutput("eventhub_name");
        this.DeclareOutput("eventhub_namespace_name");
        this.DeclareOutput("identity");
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
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
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
