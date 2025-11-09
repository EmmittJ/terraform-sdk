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
    public TerraformProperty<HashSet<string>>? ContentTypesToCompress
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("content_types_to_compress");
        set => this.WithProperty("content_types_to_compress", value);
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
    /// The is_compression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsCompressionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_compression_enabled");
        set => this.WithProperty("is_compression_enabled", value);
    }

    /// <summary>
    /// The is_http_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? IsHttpAllowed
    {
        get => GetProperty<TerraformProperty<bool>>("is_http_allowed");
        set => this.WithProperty("is_http_allowed", value);
    }

    /// <summary>
    /// The is_https_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? IsHttpsAllowed
    {
        get => GetProperty<TerraformProperty<bool>>("is_https_allowed");
        set => this.WithProperty("is_https_allowed", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The optimization_type attribute.
    /// </summary>
    public TerraformProperty<string>? OptimizationType
    {
        get => GetProperty<TerraformProperty<string>>("optimization_type");
        set => this.WithProperty("optimization_type", value);
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
    /// The origin_path attribute.
    /// </summary>
    public TerraformProperty<string>? OriginPath
    {
        get => GetProperty<TerraformProperty<string>>("origin_path");
        set => this.WithProperty("origin_path", value);
    }

    /// <summary>
    /// The probe_path attribute.
    /// </summary>
    public TerraformProperty<string>? ProbePath
    {
        get => GetProperty<TerraformProperty<string>>("probe_path");
        set => this.WithProperty("probe_path", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProfileName
    {
        get => GetProperty<TerraformProperty<string>>("profile_name");
        set => this.WithProperty("profile_name", value);
    }

    /// <summary>
    /// The querystring_caching_behaviour attribute.
    /// </summary>
    public TerraformProperty<string>? QuerystringCachingBehaviour
    {
        get => GetProperty<TerraformProperty<string>>("querystring_caching_behaviour");
        set => this.WithProperty("querystring_caching_behaviour", value);
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
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
