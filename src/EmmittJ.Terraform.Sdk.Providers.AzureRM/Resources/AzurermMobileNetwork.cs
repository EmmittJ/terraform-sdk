using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mobile_network resource.
/// </summary>
public class AzurermMobileNetwork : TerraformResource
{
    public AzurermMobileNetwork(string name) : base("azurerm_mobile_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("service_key");
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
    /// The mobile_country_code attribute.
    /// </summary>
    public TerraformProperty<string>? MobileCountryCode
    {
        get => GetProperty<TerraformProperty<string>>("mobile_country_code");
        set => this.WithProperty("mobile_country_code", value);
    }

    /// <summary>
    /// The mobile_network_code attribute.
    /// </summary>
    public TerraformProperty<string>? MobileNetworkCode
    {
        get => GetProperty<TerraformProperty<string>>("mobile_network_code");
        set => this.WithProperty("mobile_network_code", value);
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

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    public TerraformExpression ServiceKey => this["service_key"];

}
