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
    public TerraformProperty<string>? CertificateBlobBase64
    {
        get => GetProperty<TerraformProperty<string>>("certificate_blob_base64");
        set => this.WithProperty("certificate_blob_base64", value);
    }

    /// <summary>
    /// The Custom Domain Certificate password.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        get => GetProperty<TerraformProperty<string>>("certificate_password");
        set => this.WithProperty("certificate_password", value);
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Custom Domain on.
    /// </summary>
    public TerraformProperty<string>? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("container_app_environment_id");
        set => this.WithProperty("container_app_environment_id", value);
    }

    /// <summary>
    /// The Custom Domain DNS suffix for this Container App Environment.
    /// </summary>
    public TerraformProperty<string>? DnsSuffix
    {
        get => GetProperty<TerraformProperty<string>>("dns_suffix");
        set => this.WithProperty("dns_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
