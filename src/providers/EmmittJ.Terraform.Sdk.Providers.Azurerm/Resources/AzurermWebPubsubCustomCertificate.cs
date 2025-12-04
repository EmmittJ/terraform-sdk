using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermWebPubsubCustomCertificate.
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubCustomCertificateTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_web_pubsub_custom_certificate Terraform resource.
/// Manages a azurerm_web_pubsub_custom_certificate resource.
/// </summary>
public partial class AzurermWebPubsubCustomCertificate(string name) : TerraformResource("azurerm_web_pubsub_custom_certificate", name)
{
    /// <summary>
    /// The custom_certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomCertificateId is required")]
    public required TerraformValue<string> CustomCertificateId
    {
        get => GetArgument<TerraformValue<string>>("custom_certificate_id");
        set => SetArgument("custom_certificate_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformValue<string> WebPubsubId
    {
        get => GetArgument<TerraformValue<string>>("web_pubsub_id");
        set => SetArgument("web_pubsub_id", value);
    }

    /// <summary>
    /// The certificate_version attribute.
    /// </summary>
    public TerraformValue<string> CertificateVersion
        => AsReference("certificate_version");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWebPubsubCustomCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWebPubsubCustomCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
