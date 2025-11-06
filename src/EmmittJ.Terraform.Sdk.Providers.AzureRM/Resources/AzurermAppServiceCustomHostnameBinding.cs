using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_custom_hostname_binding resource.
/// </summary>
public class AzurermAppServiceCustomHostnameBinding : TerraformResource
{
    public AzurermAppServiceCustomHostnameBinding(string name) : base("azurerm_app_service_custom_hostname_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("virtual_ip");
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    public string? AppServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_name")?.Value;
        set => this.WithProperty("app_service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public string? Hostname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hostname")?.Value;
        set => this.WithProperty("hostname", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ssl_state attribute.
    /// </summary>
    public string? SslState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_state")?.Value;
        set => this.WithProperty("ssl_state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public string? Thumbprint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thumbprint")?.Value;
        set => this.WithProperty("thumbprint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_ip attribute.
    /// </summary>
    public TerraformExpression VirtualIp => this["virtual_ip"];

}
