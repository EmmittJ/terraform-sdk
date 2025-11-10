using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxCertificateTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_nginx_certificate resource.
/// </summary>
public class AzurermNginxCertificate : TerraformResource
{
    public AzurermNginxCertificate(string name) : base("azurerm_nginx_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("certificate_virtual_path");
        SetOutput("id");
        SetOutput("key_vault_secret_id");
        SetOutput("key_virtual_path");
        SetOutput("name");
        SetOutput("nginx_deployment_id");
    }

    /// <summary>
    /// The certificate_virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateVirtualPath is required")]
    public required TerraformProperty<string> CertificateVirtualPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_virtual_path");
        set => SetProperty("certificate_virtual_path", value);
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
    /// The key_vault_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultSecretId is required")]
    public required TerraformProperty<string> KeyVaultSecretId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_secret_id");
        set => SetProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The key_virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVirtualPath is required")]
    public required TerraformProperty<string> KeyVirtualPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_virtual_path");
        set => SetProperty("key_virtual_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformProperty<string> NginxDeploymentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("nginx_deployment_id");
        set => SetProperty("nginx_deployment_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNginxCertificateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
