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
    public TerraformLiteralProperty<string>? CdnFrontdoorOriginGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_origin_group_id");
        set => this.WithProperty("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The certificate_name_check_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CertificateNameCheckEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("certificate_name_check_enabled");
        set => this.WithProperty("certificate_name_check_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_name");
        set => this.WithProperty("host_name", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? HttpPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("http_port");
        set => this.WithProperty("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? HttpsPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("https_port");
        set => this.WithProperty("https_port", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OriginHostHeader
    {
        get => GetProperty<TerraformLiteralProperty<string>>("origin_host_header");
        set => this.WithProperty("origin_host_header", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Weight
    {
        get => GetProperty<TerraformLiteralProperty<double>>("weight");
        set => this.WithProperty("weight", value);
    }

}
