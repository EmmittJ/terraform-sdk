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
    public TerraformProperty<string>? ApiManagementId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateName
    {
        get => GetProperty<TerraformProperty<string>>("certificate_name");
        set => this.WithProperty("certificate_name", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayName
    {
        get => GetProperty<TerraformProperty<string>>("gateway_name");
        set => this.WithProperty("gateway_name", value);
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
    /// The is_trusted attribute.
    /// </summary>
    public TerraformProperty<bool>? IsTrusted
    {
        get => GetProperty<TerraformProperty<bool>>("is_trusted");
        set => this.WithProperty("is_trusted", value);
    }

}
