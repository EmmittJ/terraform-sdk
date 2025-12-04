using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultAccessPolicyDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_key_vault_access_policy Terraform data source.
/// Retrieves information about a azurerm_key_vault_access_policy.
/// </summary>
public partial class AzurermKeyVaultAccessPolicyDataSource(string name) : TerraformDataSource("azurerm_key_vault_access_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    public TerraformList<string> CertificatePermissions
        => AsReference("certificate_permissions");

    /// <summary>
    /// The key_permissions attribute.
    /// </summary>
    public TerraformList<string> KeyPermissions
        => AsReference("key_permissions");

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    public TerraformList<string> SecretPermissions
        => AsReference("secret_permissions");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
