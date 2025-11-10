using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudCertificateTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_spring_cloud_certificate resource.
/// </summary>
public class AzurermSpringCloudCertificate : TerraformResource
{
    public AzurermSpringCloudCertificate(string name) : base("azurerm_spring_cloud_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("thumbprint");
    }

    /// <summary>
    /// The certificate_content attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateContent
    {
        get => GetProperty<TerraformProperty<string>>("certificate_content");
        set => this.WithProperty("certificate_content", value);
    }

    /// <summary>
    /// The exclude_private_key attribute.
    /// </summary>
    public TerraformProperty<bool>? ExcludePrivateKey
    {
        get => GetProperty<TerraformProperty<bool>>("exclude_private_key");
        set => this.WithProperty("exclude_private_key", value);
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
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_certificate_id");
        set => this.WithProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetProperty<TerraformProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
