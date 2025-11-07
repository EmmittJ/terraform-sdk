using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_gateway_certificate_authority resource.
/// </summary>
public class AzurermApiManagementGatewayCertificateAuthority : TerraformResource
{
    public AzurermApiManagementGatewayCertificateAuthority(string name) : base("azurerm_api_management_gateway_certificate_authority", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiManagementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
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
    /// The gateway_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GatewayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_name");
        set => this.WithProperty("gateway_name", value);
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
    /// The is_trusted attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IsTrusted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_trusted");
        set => this.WithProperty("is_trusted", value);
    }

}
