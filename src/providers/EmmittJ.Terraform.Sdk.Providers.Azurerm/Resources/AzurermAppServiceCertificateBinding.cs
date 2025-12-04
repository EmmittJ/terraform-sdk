using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServiceCertificateBinding.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("certificate_id");
        set => SetArgument("certificate_id", value);
    }

    /// <summary>
    /// The hostname_binding_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostnameBindingId is required")]
    public required TerraformValue<string> HostnameBindingId
    {
        get => GetArgument<TerraformValue<string>>("hostname_binding_id");
        set => SetArgument("hostname_binding_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ssl_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslState is required")]
    public required TerraformValue<string> SslState
    {
        get => GetArgument<TerraformValue<string>>("ssl_state");
        set => SetArgument("ssl_state", value);
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    public TerraformValue<string> AppServiceName
        => AsReference("app_service_name");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceCertificateBindingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceCertificateBindingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
