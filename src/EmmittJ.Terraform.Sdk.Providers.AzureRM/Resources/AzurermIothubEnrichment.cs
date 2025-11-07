using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub_enrichment resource.
/// </summary>
public class AzurermIothubEnrichment : TerraformResource
{
    public AzurermIothubEnrichment(string name) : base("azurerm_iothub_enrichment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The endpoint_names attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? EndpointNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("endpoint_names");
        set => this.WithProperty("endpoint_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The iothub_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IothubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_name");
        set => this.WithProperty("iothub_name", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Value
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value");
        set => this.WithProperty("value", value);
    }

}
