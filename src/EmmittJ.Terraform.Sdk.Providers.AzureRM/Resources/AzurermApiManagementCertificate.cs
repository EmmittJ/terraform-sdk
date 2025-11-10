using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementCertificateTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_certificate resource.
/// </summary>
public class AzurermApiManagementCertificate : TerraformResource
{
    public AzurermApiManagementCertificate(string name) : base("azurerm_api_management_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("expiration");
        this.DeclareOutput("subject");
        this.DeclareOutput("thumbprint");
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The data attribute.
    /// </summary>
    public TerraformProperty<string>? Data
    {
        get => GetProperty<TerraformProperty<string>>("data");
        set => this.WithProperty("data", value);
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
    /// The key_vault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultIdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_identity_client_id");
        set => this.WithProperty("key_vault_identity_client_id", value);
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_secret_id");
        set => this.WithProperty("key_vault_secret_id", value);
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
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformExpression Expiration => this["expiration"];

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformExpression Subject => this["subject"];

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
