using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentCustomDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBlobBase64 is required")]
    public required TerraformProperty<string> CertificateBlobBase64
    {
        get => GetProperty<TerraformProperty<string>>("certificate_blob_base64");
        set => this.WithProperty("certificate_blob_base64", value);
    }

    /// <summary>
    /// The Custom Domain Certificate password.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificatePassword is required")]
    public required TerraformProperty<string> CertificatePassword
    {
        get => GetProperty<TerraformProperty<string>>("certificate_password");
        set => this.WithProperty("certificate_password", value);
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Custom Domain on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformProperty<string> ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("container_app_environment_id");
        set => this.WithProperty("container_app_environment_id", value);
    }

    /// <summary>
    /// The Custom Domain DNS suffix for this Container App Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsSuffix is required")]
    public required TerraformProperty<string> DnsSuffix
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

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppEnvironmentCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerAppEnvironmentCustomDomainTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
