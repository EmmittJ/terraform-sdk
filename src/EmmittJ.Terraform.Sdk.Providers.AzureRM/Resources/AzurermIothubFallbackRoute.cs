using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub_fallback_route resource.
/// </summary>
public class AzurermIothubFallbackRoute : TerraformResource
{
    public AzurermIothubFallbackRoute(string name) : base("azurerm_iothub_fallback_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformProperty<string>? Condition
    {
        get => GetProperty<TerraformProperty<string>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

}
