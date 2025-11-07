using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cdn_frontdoor_origin resource.
/// </summary>
public class AzurermCdnFrontdoorOrigin : TerraformResource
{
    public AzurermCdnFrontdoorOrigin(string name) : base("azurerm_cdn_frontdoor_origin", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CdnFrontdoorOriginGroupId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_frontdoor_origin_group_id");
        set => this.WithProperty("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The certificate_name_check_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CertificateNameCheckEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("certificate_name_check_enabled");
        set => this.WithProperty("certificate_name_check_enabled", value);
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
    /// The host_name attribute.
    /// </summary>
    public TerraformProperty<string>? HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => this.WithProperty("host_name", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpPort
    {
        get => GetProperty<TerraformProperty<double>>("http_port");
        set => this.WithProperty("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpsPort
    {
        get => GetProperty<TerraformProperty<double>>("https_port");
        set => this.WithProperty("https_port", value);
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
    /// The origin_host_header attribute.
    /// </summary>
    public TerraformProperty<string>? OriginHostHeader
    {
        get => GetProperty<TerraformProperty<string>>("origin_host_header");
        set => this.WithProperty("origin_host_header", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        get => GetProperty<TerraformProperty<double>>("weight");
        set => this.WithProperty("weight", value);
    }

}
