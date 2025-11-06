using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_custom_domain resource.
/// </summary>
public class AzurermSpringCloudCustomDomain : TerraformResource
{
    public AzurermSpringCloudCustomDomain(string name) : base("azurerm_spring_cloud_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public string? CertificateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_name")?.Value;
        set => this.WithProperty("certificate_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public string? SpringCloudAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_app_id")?.Value;
        set => this.WithProperty("spring_cloud_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public string? Thumbprint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thumbprint")?.Value;
        set => this.WithProperty("thumbprint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
