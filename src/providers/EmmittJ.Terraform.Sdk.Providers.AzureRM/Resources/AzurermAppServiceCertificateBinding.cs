using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateBindingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_app_service_certificate_binding Terraform resource.
/// Manages a azurerm_app_service_certificate_binding resource.
/// </summary>
public partial class AzurermAppServiceCertificateBinding(string name) : TerraformResource("azurerm_app_service_certificate_binding", name)
{
    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    public required TerraformValue<string> CertificateId
    {
        get => new TerraformReference<string>(this, "certificate_id");
        set => SetArgument("certificate_id", value);
    }

    /// <summary>
    /// The hostname_binding_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostnameBindingId is required")]
    public required TerraformValue<string> HostnameBindingId
    {
        get => new TerraformReference<string>(this, "hostname_binding_id");
        set => SetArgument("hostname_binding_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ssl_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslState is required")]
    public required TerraformValue<string> SslState
    {
        get => new TerraformReference<string>(this, "ssl_state");
        set => SetArgument("ssl_state", value);
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    public TerraformValue<string> AppServiceName
    {
        get => new TerraformReference<string>(this, "app_service_name");
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceCertificateBindingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceCertificateBindingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
