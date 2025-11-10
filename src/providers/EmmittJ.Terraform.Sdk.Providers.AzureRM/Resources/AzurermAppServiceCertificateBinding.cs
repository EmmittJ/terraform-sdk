using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateBindingTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_app_service_certificate_binding resource.
/// </summary>
public class AzurermAppServiceCertificateBinding : TerraformResource
{
    public AzurermAppServiceCertificateBinding(string name) : base("azurerm_app_service_certificate_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("app_service_name");
        SetOutput("hostname");
        SetOutput("thumbprint");
        SetOutput("certificate_id");
        SetOutput("hostname_binding_id");
        SetOutput("id");
        SetOutput("ssl_state");
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
    /// The hostname_binding_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostnameBindingId is required")]
    public required TerraformProperty<string> HostnameBindingId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hostname_binding_id");
        set => SetProperty("hostname_binding_id", value);
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
    /// The ssl_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslState is required")]
    public required TerraformProperty<string> SslState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ssl_state");
        set => SetProperty("ssl_state", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceCertificateBindingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    public TerraformExpression AppServiceName => this["app_service_name"];

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
