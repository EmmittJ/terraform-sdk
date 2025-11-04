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
    public string? ApiManagementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_id")?.Value;
        set => this.WithProperty("api_management_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The gateway_name attribute.
    /// </summary>
    public string? GatewayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_name")?.Value;
        set => this.WithProperty("gateway_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The is_trusted attribute.
    /// </summary>
    public bool? IsTrusted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_trusted")?.Value;
        set => this.WithProperty("is_trusted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
