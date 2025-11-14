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
public class AzurermContainerAppCustomDomainTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_container_app_custom_domain resource.
/// </summary>
public class AzurermContainerAppCustomDomain : TerraformResource
{
    public AzurermContainerAppCustomDomain(string name) : base("azurerm_container_app_custom_domain", name)
    {
    }

    /// <summary>
    /// The Binding type. Possible values include `Disabled` and `SniEnabled`.
    /// </summary>
    [TerraformArgument("certificate_binding_type")]
    public TerraformValue<string>? CertificateBindingType
    {
        get => new TerraformReference<string>(this, "certificate_binding_type");
        set => SetArgument("certificate_binding_type", value);
    }

    /// <summary>
    /// The container_app_environment_certificate_id attribute.
    /// </summary>
    [TerraformArgument("container_app_environment_certificate_id")]
    public TerraformValue<string>? ContainerAppEnvironmentCertificateId
    {
        get => new TerraformReference<string>(this, "container_app_environment_certificate_id");
        set => SetArgument("container_app_environment_certificate_id", value);
    }

    /// <summary>
    /// The container_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppId is required")]
    [TerraformArgument("container_app_id")]
    public required TerraformValue<string> ContainerAppId
    {
        get => new TerraformReference<string>(this, "container_app_id");
        set => SetArgument("container_app_id", value);
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
    /// The hostname of the Certificate. Must be the CN or a named SAN in the certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerAppCustomDomainTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The container_app_environment_managed_certificate_id attribute.
    /// </summary>
    [TerraformArgument("container_app_environment_managed_certificate_id")]
    public TerraformValue<string> ContainerAppEnvironmentManagedCertificateId
    {
        get => new TerraformReference<string>(this, "container_app_environment_managed_certificate_id");
    }

}
