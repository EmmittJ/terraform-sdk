using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cdn_endpoint_custom_domain resource.
/// </summary>
public class AzurermCdnEndpointCustomDomain : TerraformResource
{
    public AzurermCdnEndpointCustomDomain(string name) : base("azurerm_cdn_endpoint_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cdn_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? CdnEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_endpoint_id");
        set => this.WithProperty("cdn_endpoint_id", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformProperty<string>? HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => this.WithProperty("host_name", value);
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

}
