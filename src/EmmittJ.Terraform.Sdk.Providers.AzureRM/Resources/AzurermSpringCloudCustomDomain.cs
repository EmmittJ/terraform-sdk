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
    public TerraformLiteralProperty<string>? CertificateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_name");
        set => this.WithProperty("certificate_name", value);
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
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpringCloudAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Thumbprint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thumbprint");
        set => this.WithProperty("thumbprint", value);
    }

}
