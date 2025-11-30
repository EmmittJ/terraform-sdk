using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerAppCustomDomain.
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
/// Represents a azurerm_container_app_custom_domain Terraform resource.
/// Manages a azurerm_container_app_custom_domain resource.
/// </summary>
public partial class AzurermContainerAppCustomDomain(string name) : TerraformResource("azurerm_container_app_custom_domain", name)
{
    /// <summary>
    /// The Binding type. Possible values include `Disabled` and `SniEnabled`.
    /// </summary>
    public TerraformValue<string>? CertificateBindingType
    {
        get => new TerraformReference<string>(this, "certificate_binding_type");
        set => SetArgument("certificate_binding_type", value);
    }

    /// <summary>
    /// The container_app_environment_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? ContainerAppEnvironmentCertificateId
    {
        get => new TerraformReference<string>(this, "container_app_environment_certificate_id");
        set => SetArgument("container_app_environment_certificate_id", value);
    }

    /// <summary>
    /// The container_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppId is required")]
    public required TerraformValue<string> ContainerAppId
    {
        get => new TerraformReference<string>(this, "container_app_id");
        set => SetArgument("container_app_id", value);
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
    /// The hostname of the Certificate. Must be the CN or a named SAN in the certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The container_app_environment_managed_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> ContainerAppEnvironmentManagedCertificateId
    {
        get => new TerraformReference<string>(this, "container_app_environment_managed_certificate_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppCustomDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
