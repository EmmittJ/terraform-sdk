using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementGatewayCertificateAuthorityTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("api_management_id");
        SetOutput("certificate_name");
        SetOutput("gateway_name");
        SetOutput("id");
        SetOutput("is_trusted");
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    public required TerraformProperty<string> ApiManagementId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_id");
        set => SetProperty("api_management_id", value);
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateName is required")]
    public required TerraformProperty<string> CertificateName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_name");
        set => SetProperty("certificate_name", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    public required TerraformProperty<string> GatewayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_name");
        set => SetProperty("gateway_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The is_trusted attribute.
    /// </summary>
    public TerraformProperty<bool> IsTrusted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_trusted");
        set => SetProperty("is_trusted", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementGatewayCertificateAuthorityTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
