using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_app resource.
/// </summary>
public class AzurermSpringCloudApp : TerraformResource
{
    public AzurermSpringCloudApp(string name) : base("azurerm_spring_cloud_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    public string? AddonJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("addon_json")?.Value;
        set => this.WithProperty("addon_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public bool? HttpsOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_only")?.Value;
        set => this.WithProperty("https_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The is_public attribute.
    /// </summary>
    public bool? IsPublic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_public")?.Value;
        set => this.WithProperty("is_public", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The public_endpoint_enabled attribute.
    /// </summary>
    public bool? PublicEndpointEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_endpoint_enabled")?.Value;
        set => this.WithProperty("public_endpoint_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The service_name attribute.
    /// </summary>
    public string? ServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_name")?.Value;
        set => this.WithProperty("service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public bool? TlsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls_enabled")?.Value;
        set => this.WithProperty("tls_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
