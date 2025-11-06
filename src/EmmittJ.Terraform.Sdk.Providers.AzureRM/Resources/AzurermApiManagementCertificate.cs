using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public string? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name")?.Value;
        set => this.WithProperty("api_management_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data attribute.
    /// </summary>
    public string? Data
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data")?.Value;
        set => this.WithProperty("data", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key_vault_identity_client_id attribute.
    /// </summary>
    public string? KeyVaultIdentityClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_identity_client_id")?.Value;
        set => this.WithProperty("key_vault_identity_client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public string? KeyVaultSecretId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_secret_id")?.Value;
        set => this.WithProperty("key_vault_secret_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
