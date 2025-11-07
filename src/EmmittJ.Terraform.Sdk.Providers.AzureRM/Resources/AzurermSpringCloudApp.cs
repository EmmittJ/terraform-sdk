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
    public TerraformProperty<string>? AddonJson
    {
        get => GetProperty<TerraformProperty<string>>("addon_json");
        set => this.WithProperty("addon_json", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("https_only");
        set => this.WithProperty("https_only", value);
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
    /// The is_public attribute.
    /// </summary>
    public TerraformProperty<bool>? IsPublic
    {
        get => GetProperty<TerraformProperty<bool>>("is_public");
        set => this.WithProperty("is_public", value);
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
    /// The public_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_endpoint_enabled");
        set => this.WithProperty("public_endpoint_enabled", value);
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
    /// The service_name attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceName
    {
        get => GetProperty<TerraformProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_enabled");
        set => this.WithProperty("tls_enabled", value);
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
