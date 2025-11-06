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
    public string? CertificateBindingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_binding_type")?.Value;
        set => this.WithProperty("certificate_binding_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The container_app_environment_certificate_id attribute.
    /// </summary>
    public string? ContainerAppEnvironmentCertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_app_environment_certificate_id")?.Value;
        set => this.WithProperty("container_app_environment_certificate_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The container_app_id attribute.
    /// </summary>
    public string? ContainerAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_app_id")?.Value;
        set => this.WithProperty("container_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hostname of the Certificate. Must be the CN or a named SAN in the certificate.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The container_app_environment_managed_certificate_id attribute.
    /// </summary>
    public TerraformExpression ContainerAppEnvironmentManagedCertificateId => this["container_app_environment_managed_certificate_id"];

}
