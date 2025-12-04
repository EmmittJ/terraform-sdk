using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultAccessPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultAccessPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_key_vault_access_policy Terraform resource.
/// Manages a azurerm_key_vault_access_policy resource.
/// </summary>
public partial class AzurermKeyVaultAccessPolicy(string name) : TerraformResource("azurerm_key_vault_access_policy", name)
{
    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformValue<string>? ApplicationId
    {
        get => GetArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    public TerraformList<string>? CertificatePermissions
    {
        get => GetArgument<TerraformList<string>>("certificate_permissions");
        set => SetArgument("certificate_permissions", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_permissions attribute.
    /// </summary>
    public TerraformList<string>? KeyPermissions
    {
        get => GetArgument<TerraformList<string>>("key_permissions");
        set => SetArgument("key_permissions", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformValue<string> ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    public TerraformList<string>? SecretPermissions
    {
        get => GetArgument<TerraformList<string>>("secret_permissions");
        set => SetArgument("secret_permissions", value);
    }

    /// <summary>
    /// The storage_permissions attribute.
    /// </summary>
    public TerraformList<string>? StoragePermissions
    {
        get => GetArgument<TerraformList<string>>("storage_permissions");
        set => SetArgument("storage_permissions", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultAccessPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
