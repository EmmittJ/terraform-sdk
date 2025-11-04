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
    public string? CertificateContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_content")?.Value;
        set => this.WithProperty("certificate_content", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The iothub_name attribute.
    /// </summary>
    public string? IothubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_name")?.Value;
        set => this.WithProperty("iothub_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The is_verified attribute.
    /// </summary>
    public bool? IsVerified
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_verified")?.Value;
        set => this.WithProperty("is_verified", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
