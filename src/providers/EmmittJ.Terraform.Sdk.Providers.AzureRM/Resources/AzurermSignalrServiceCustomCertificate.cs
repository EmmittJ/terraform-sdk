using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSignalrServiceCustomCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_signalr_service_custom_certificate resource.
/// </summary>
public class AzurermSignalrServiceCustomCertificate : TerraformResource
{
    public AzurermSignalrServiceCustomCertificate(string name) : base("azurerm_signalr_service_custom_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputertificate_version");
    }

    /// <summary>
    /// The custom_certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomCertificateId is required")]
    public required TerraformProperty<string> CustomCertificateId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("custom_certificate_id");
        set => this.WithProperty("custom_certificate_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The signalr_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignalrServiceId is required")]
    public required TerraformProperty<string> SignalrServiceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("signalr_service_id");
        set => this.WithProperty("signalr_service_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSignalrServiceCustomCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSignalrServiceCustomCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The certificate_version attribute.
    /// </summary>
    public TerraformExpression CertificateVersion => this["certificate_version"];

}
