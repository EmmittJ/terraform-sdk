using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub_certificate resource.
/// </summary>
public class AzurermIothubCertificate : TerraformResource
{
    public AzurermIothubCertificate(string name) : base("azurerm_iothub_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The certificate_content attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_content");
        set => this.WithProperty("certificate_content", value);
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
    /// The iothub_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IothubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_name");
        set => this.WithProperty("iothub_name", value);
    }

    /// <summary>
    /// The is_verified attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IsVerified
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_verified");
        set => this.WithProperty("is_verified", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
