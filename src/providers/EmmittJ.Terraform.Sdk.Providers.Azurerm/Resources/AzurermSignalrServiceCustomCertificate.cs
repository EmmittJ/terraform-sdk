using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSignalrServiceCustomCertificate.
/// Nesting mode: single
/// </summary>
public class AzurermSignalrServiceCustomCertificateTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_signalr_service_custom_certificate Terraform resource.
/// Manages a azurerm_signalr_service_custom_certificate resource.
/// </summary>
public partial class AzurermSignalrServiceCustomCertificate(string name) : TerraformResource("azurerm_signalr_service_custom_certificate", name)
{
    /// <summary>
    /// The custom_certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomCertificateId is required")]
    public required TerraformValue<string> CustomCertificateId
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_certificate_id");
        set => SetArgument("custom_certificate_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The signalr_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignalrServiceId is required")]
    public required TerraformValue<string> SignalrServiceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("signalr_service_id");
        set => SetArgument("signalr_service_id", value);
    }

    /// <summary>
    /// The certificate_version attribute.
    /// </summary>
    public TerraformValue<string> CertificateVersion
        => AsReference("certificate_version");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSignalrServiceCustomCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSignalrServiceCustomCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
