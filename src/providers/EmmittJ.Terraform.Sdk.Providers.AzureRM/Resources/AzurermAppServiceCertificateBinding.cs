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
public class AzurermAppServiceCertificateBindingTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_app_service_certificate_binding resource.
/// </summary>
public class AzurermAppServiceCertificateBinding : TerraformResource
{
    public AzurermAppServiceCertificateBinding(string name) : base("azurerm_app_service_certificate_binding", name)
    {
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    [TerraformArgument("certificate_id")]
    public required TerraformValue<string> CertificateId
    {
        get => new TerraformReference<string>(this, "certificate_id");
        set => SetArgument("certificate_id", value);
    }

    /// <summary>
    /// The hostname_binding_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostnameBindingId is required")]
    [TerraformArgument("hostname_binding_id")]
    public required TerraformValue<string> HostnameBindingId
    {
        get => new TerraformReference<string>(this, "hostname_binding_id");
        set => SetArgument("hostname_binding_id", value);
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
    /// The ssl_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslState is required")]
    [TerraformArgument("ssl_state")]
    public required TerraformValue<string> SslState
    {
        get => new TerraformReference<string>(this, "ssl_state");
        set => SetArgument("ssl_state", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppServiceCertificateBindingTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [TerraformArgument("app_service_name")]
    public TerraformValue<string> AppServiceName
    {
        get => new TerraformReference<string>(this, "app_service_name");
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformArgument("hostname")]
    public TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformArgument("thumbprint")]
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

}
