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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
