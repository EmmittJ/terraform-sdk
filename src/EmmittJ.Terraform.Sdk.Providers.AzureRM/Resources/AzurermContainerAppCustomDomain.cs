using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("container_app_environment_managed_certificate_id");
    }

    /// <summary>
    /// The Binding type. Possible values include `Disabled` and `SniEnabled`.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateBindingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_binding_type");
        set => this.WithProperty("certificate_binding_type", value);
    }

    /// <summary>
    /// The container_app_environment_certificate_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerAppEnvironmentCertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_app_environment_certificate_id");
        set => this.WithProperty("container_app_environment_certificate_id", value);
    }

    /// <summary>
    /// The container_app_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_app_id");
        set => this.WithProperty("container_app_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The hostname of the Certificate. Must be the CN or a named SAN in the certificate.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The container_app_environment_managed_certificate_id attribute.
    /// </summary>
    public TerraformExpression ContainerAppEnvironmentManagedCertificateId => this["container_app_environment_managed_certificate_id"];

}
