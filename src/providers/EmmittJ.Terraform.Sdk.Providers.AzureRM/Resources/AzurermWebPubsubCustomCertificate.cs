using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Manages a azurerm_web_pubsub_custom_certificate resource.
/// </summary>
public class AzurermWebPubsubCustomCertificate : TerraformResource
{
    public AzurermWebPubsubCustomCertificate(string name) : base("azurerm_web_pubsub_custom_certificate", name)
    {
    }

    /// <summary>
    /// The custom_certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomCertificateId is required")]
    [TerraformArgument("custom_certificate_id")]
    public required TerraformValue<string> CustomCertificateId
    {
        get => new TerraformReference<string>(this, "custom_certificate_id");
        set => SetArgument("custom_certificate_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    [TerraformArgument("web_pubsub_id")]
    public required TerraformValue<string> WebPubsubId
    {
        get => new TerraformReference<string>(this, "web_pubsub_id");
        set => SetArgument("web_pubsub_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermWebPubsubCustomCertificateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The certificate_version attribute.
    /// </summary>
    [TerraformArgument("certificate_version")]
    public TerraformValue<string> CertificateVersion
    {
        get => new TerraformReference<string>(this, "certificate_version");
    }

}
