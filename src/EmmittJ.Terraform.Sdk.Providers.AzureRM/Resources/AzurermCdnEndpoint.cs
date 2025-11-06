using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cdn_endpoint resource.
/// </summary>
public class AzurermCdnEndpoint : TerraformResource
{
    public AzurermCdnEndpoint(string name) : base("azurerm_cdn_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    public HashSet<string>? ContentTypesToCompress
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("content_types_to_compress")?.Value;
        set => this.WithProperty("content_types_to_compress", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The is_compression_enabled attribute.
    /// </summary>
    public bool? IsCompressionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_compression_enabled")?.Value;
        set => this.WithProperty("is_compression_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The is_http_allowed attribute.
    /// </summary>
    public bool? IsHttpAllowed
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_http_allowed")?.Value;
        set => this.WithProperty("is_http_allowed", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The is_https_allowed attribute.
    /// </summary>
    public bool? IsHttpsAllowed
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_https_allowed")?.Value;
        set => this.WithProperty("is_https_allowed", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The optimization_type attribute.
    /// </summary>
    public string? OptimizationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("optimization_type")?.Value;
        set => this.WithProperty("optimization_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The origin_path attribute.
    /// </summary>
    public string? OriginPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("origin_path")?.Value;
        set => this.WithProperty("origin_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The probe_path attribute.
    /// </summary>
    public string? ProbePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("probe_path")?.Value;
        set => this.WithProperty("probe_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    public string? ProfileName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_name")?.Value;
        set => this.WithProperty("profile_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The querystring_caching_behaviour attribute.
    /// </summary>
    public string? QuerystringCachingBehaviour
    {
        get => GetProperty<TerraformLiteralProperty<string>>("querystring_caching_behaviour")?.Value;
        set => this.WithProperty("querystring_caching_behaviour", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
