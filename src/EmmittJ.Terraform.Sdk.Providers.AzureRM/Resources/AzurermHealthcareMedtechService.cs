using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_healthcare_medtech_service resource.
/// </summary>
public class AzurermHealthcareMedtechService : TerraformResource
{
    public AzurermHealthcareMedtechService(string name) : base("azurerm_healthcare_medtech_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The device_mapping_json attribute.
    /// </summary>
    public string? DeviceMappingJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_mapping_json")?.Value;
        set => this.WithProperty("device_mapping_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public string? EventhubConsumerGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_consumer_group_name")?.Value;
        set => this.WithProperty("eventhub_consumer_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public string? EventhubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_name")?.Value;
        set => this.WithProperty("eventhub_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    public string? EventhubNamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_namespace_name")?.Value;
        set => this.WithProperty("eventhub_namespace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
