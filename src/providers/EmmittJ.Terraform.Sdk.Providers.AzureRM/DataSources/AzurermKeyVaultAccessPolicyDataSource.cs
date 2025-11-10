using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_access_policy.
/// </summary>
public class AzurermKeyVaultAccessPolicyDataSource : TerraformDataSource
{
    public AzurermKeyVaultAccessPolicyDataSource(string name) : base("azurerm_key_vault_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("certificate_permissions");
        SetOutput("key_permissions");
        SetOutput("secret_permissions");
        SetOutput("id");
        SetOutput("name");
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
    /// The name attribute.
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
    public AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    public TerraformExpression CertificatePermissions => this["certificate_permissions"];

    /// <summary>
    /// The key_permissions attribute.
    /// </summary>
    public TerraformExpression KeyPermissions => this["key_permissions"];

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    public TerraformExpression SecretPermissions => this["secret_permissions"];

}
