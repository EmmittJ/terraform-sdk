using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementGatewayHostNameConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_gateway_host_name_configuration resource.
/// </summary>
public class AzurermApiManagementGatewayHostNameConfiguration : TerraformResource
{
    public AzurermApiManagementGatewayHostNameConfiguration(string name) : base("azurerm_api_management_gateway_host_name_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_management_id");
        SetOutput("certificate_id");
        SetOutput("gateway_name");
        SetOutput("host_name");
        SetOutput("http2_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("request_client_certificate_enabled");
        SetOutput("tls10_enabled");
        SetOutput("tls11_enabled");
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
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    public required TerraformProperty<string> CertificateId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_id");
        set => SetProperty("certificate_id", value);
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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_name");
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Http2Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("http2_enabled");
        set => SetProperty("http2_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RequestClientCertificateEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("request_client_certificate_enabled");
        set => SetProperty("request_client_certificate_enabled", value);
    }

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Tls10Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tls10_enabled");
        set => SetProperty("tls10_enabled", value);
    }

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Tls11Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tls11_enabled");
        set => SetProperty("tls11_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementGatewayHostNameConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
