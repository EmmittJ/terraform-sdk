using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppCustomDomainTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_container_app_custom_domain resource.
/// </summary>
public class AzurermContainerAppCustomDomain : TerraformResource
{
    public AzurermContainerAppCustomDomain(string name) : base("azurerm_container_app_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("container_app_environment_managed_certificate_id");
        SetOutput("certificate_binding_type");
        SetOutput("container_app_environment_certificate_id");
        SetOutput("container_app_id");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The Binding type. Possible values include `Disabled` and `SniEnabled`.
    /// </summary>
    public TerraformProperty<string> CertificateBindingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_binding_type");
        set => SetProperty("certificate_binding_type", value);
    }

    /// <summary>
    /// The container_app_environment_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string> ContainerAppEnvironmentCertificateId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_app_environment_certificate_id");
        set => SetProperty("container_app_environment_certificate_id", value);
    }

    /// <summary>
    /// The container_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppId is required")]
    public required TerraformProperty<string> ContainerAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_app_id");
        set => SetProperty("container_app_id", value);
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
    /// The hostname of the Certificate. Must be the CN or a named SAN in the certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppCustomDomainTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The container_app_environment_managed_certificate_id attribute.
    /// </summary>
    public TerraformExpression ContainerAppEnvironmentManagedCertificateId => this["container_app_environment_managed_certificate_id"];

}
