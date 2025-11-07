using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_app_environment_custom_domain resource.
/// </summary>
public class AzurermContainerAppEnvironmentCustomDomain : TerraformResource
{
    public AzurermContainerAppEnvironmentCustomDomain(string name) : base("azurerm_container_app_environment_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The Custom Domain Certificate Private Key as a base64 encoded PFX or PEM.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateBlobBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_blob_base64");
        set => this.WithProperty("certificate_blob_base64", value);
    }

    /// <summary>
    /// The Custom Domain Certificate password.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificatePassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_password");
        set => this.WithProperty("certificate_password", value);
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Custom Domain on.
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_app_environment_id");
        set => this.WithProperty("container_app_environment_id", value);
    }

    /// <summary>
    /// The Custom Domain DNS suffix for this Container App Environment.
    /// </summary>
    public TerraformLiteralProperty<string>? DnsSuffix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_suffix");
        set => this.WithProperty("dns_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
