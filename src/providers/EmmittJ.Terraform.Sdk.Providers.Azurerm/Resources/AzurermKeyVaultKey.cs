using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for rotation_policy in AzurermKeyVaultKey.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultKeyRotationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rotation_policy";

    /// <summary>
    /// The expire_after attribute.
    /// </summary>
    public TerraformValue<string>? ExpireAfter
    {
        get => GetArgument<TerraformValue<string>>("expire_after");
        set => SetArgument("expire_after", value);
    }

    /// <summary>
    /// The notify_before_expiry attribute.
    /// </summary>
    public TerraformValue<string>? NotifyBeforeExpiry
    {
        get => GetArgument<TerraformValue<string>>("notify_before_expiry");
        set => SetArgument("notify_before_expiry", value);
    }

    /// <summary>
    /// Automatic block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Automatic block(s) allowed")]
    public TerraformList<AzurermKeyVaultKeyRotationPolicyBlockAutomaticBlock>? Automatic
    {
        get => GetArgument<TerraformList<AzurermKeyVaultKeyRotationPolicyBlockAutomaticBlock>>("automatic");
        set => SetArgument("automatic", value);
    }

}

/// <summary>
/// Block type for automatic in AzurermKeyVaultKeyRotationPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultKeyRotationPolicyBlockAutomaticBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic";

    /// <summary>
    /// The time_after_creation attribute.
    /// </summary>
    public TerraformValue<string>? TimeAfterCreation
    {
        get => GetArgument<TerraformValue<string>>("time_after_creation");
        set => SetArgument("time_after_creation", value);
    }

    /// <summary>
    /// The time_before_expiry attribute.
    /// </summary>
    public TerraformValue<string>? TimeBeforeExpiry
    {
        get => GetArgument<TerraformValue<string>>("time_before_expiry");
        set => SetArgument("time_before_expiry", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKeyVaultKey.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultKeyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_key Terraform resource.
/// Manages a azurerm_key_vault_key resource.
/// </summary>
public partial class AzurermKeyVaultKey(string name) : TerraformResource("azurerm_key_vault_key", name)
{
    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformValue<string> Curve
    {
        get => GetArgument<TerraformValue<string>>("curve") ?? AsReference("curve");
        set => SetArgument("curve", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string>? ExpirationDate
    {
        get => GetArgument<TerraformValue<string>>("expiration_date");
        set => SetArgument("expiration_date", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyOpts is required")]
    public TerraformList<string>? KeyOpts
    {
        get => GetArgument<TerraformList<string>>("key_opts");
        set => SetArgument("key_opts", value);
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformValue<double>? KeySize
    {
        get => GetArgument<TerraformValue<double>>("key_size");
        set => SetArgument("key_size", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    public required TerraformValue<string> KeyType
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_type");
        set => SetArgument("key_type", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
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
    /// The not_before_date attribute.
    /// </summary>
    public TerraformValue<string>? NotBeforeDate
    {
        get => GetArgument<TerraformValue<string>>("not_before_date");
        set => SetArgument("not_before_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The e attribute.
    /// </summary>
    public TerraformValue<string> E
        => AsReference("e");

    /// <summary>
    /// The n attribute.
    /// </summary>
    public TerraformValue<string> N
        => AsReference("n");

    /// <summary>
    /// The public_key_openssh attribute.
    /// </summary>
    public TerraformValue<string> PublicKeyOpenssh
        => AsReference("public_key_openssh");

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    public TerraformValue<string> PublicKeyPem
        => AsReference("public_key_pem");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
        => AsReference("resource_id");

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceVersionlessId
        => AsReference("resource_versionless_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformValue<string> VersionlessId
        => AsReference("versionless_id");

    /// <summary>
    /// The x attribute.
    /// </summary>
    public TerraformValue<string> X
        => AsReference("x");

    /// <summary>
    /// The y attribute.
    /// </summary>
    public TerraformValue<string> Y
        => AsReference("y");

    /// <summary>
    /// RotationPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationPolicy block(s) allowed")]
    public TerraformList<AzurermKeyVaultKeyRotationPolicyBlock>? RotationPolicy
    {
        get => GetArgument<TerraformList<AzurermKeyVaultKeyRotationPolicyBlock>>("rotation_policy");
        set => SetArgument("rotation_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
