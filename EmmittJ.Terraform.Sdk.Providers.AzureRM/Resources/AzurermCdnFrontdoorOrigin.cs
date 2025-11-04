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
    public string? CdnFrontdoorOriginGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_origin_group_id")?.Value;
        set => this.WithProperty("cdn_frontdoor_origin_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_name_check_enabled attribute.
    /// </summary>
    public bool? CertificateNameCheckEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("certificate_name_check_enabled")?.Value;
        set => this.WithProperty("certificate_name_check_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public string? HostName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_name")?.Value;
        set => this.WithProperty("host_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public double? HttpPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("http_port")?.Value;
        set => this.WithProperty("http_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public double? HttpsPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("https_port")?.Value;
        set => this.WithProperty("https_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    public string? OriginHostHeader
    {
        get => GetProperty<TerraformLiteralProperty<string>>("origin_host_header")?.Value;
        set => this.WithProperty("origin_host_header", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public double? Weight
    {
        get => GetProperty<TerraformLiteralProperty<double>>("weight")?.Value;
        set => this.WithProperty("weight", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
