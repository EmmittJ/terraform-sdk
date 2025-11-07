using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub_consumer_group resource.
/// </summary>
public class AzurermIothubConsumerGroup : TerraformResource
{
    public AzurermIothubConsumerGroup(string name) : base("azurerm_iothub_consumer_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The eventhub_endpoint_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubEndpointName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_endpoint_name");
        set => this.WithProperty("eventhub_endpoint_name", value);
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
    /// The iothub_name attribute.
    /// </summary>
    public TerraformProperty<string>? IothubName
    {
        get => GetProperty<TerraformProperty<string>>("iothub_name");
        set => this.WithProperty("iothub_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
