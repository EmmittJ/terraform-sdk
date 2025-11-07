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
    public TerraformProperty<string>? DeviceMappingJson
    {
        get => GetProperty<TerraformProperty<string>>("device_mapping_json");
        set => this.WithProperty("device_mapping_json", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubConsumerGroupName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_consumer_group_name");
        set => this.WithProperty("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_name");
        set => this.WithProperty("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubNamespaceName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_namespace_name");
        set => this.WithProperty("eventhub_namespace_name", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
