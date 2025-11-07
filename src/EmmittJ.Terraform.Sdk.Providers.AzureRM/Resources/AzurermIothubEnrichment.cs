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
    public TerraformProperty<List<string>>? EndpointNames
    {
        get => GetProperty<TerraformProperty<List<string>>>("endpoint_names");
        set => this.WithProperty("endpoint_names", value);
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
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => this.WithProperty("value", value);
    }

}
