using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_spring_cloud_app.
/// </summary>
public class AzurermSpringCloudAppDataSource : TerraformDataSource
{
    public AzurermSpringCloudAppDataSource(string name) : base("azurerm_spring_cloud_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
        this.DeclareOutput("https_only");
        this.DeclareOutput("identity");
        this.DeclareOutput("is_public");
        this.DeclareOutput("persistent_disk");
        this.DeclareOutput("tls_enabled");
        this.DeclareOutput("url");
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
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformExpression HttpsOnly => this["https_only"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The is_public attribute.
    /// </summary>
    public TerraformExpression IsPublic => this["is_public"];

    /// <summary>
    /// The persistent_disk attribute.
    /// </summary>
    public TerraformExpression PersistentDisk => this["persistent_disk"];

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformExpression TlsEnabled => this["tls_enabled"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
