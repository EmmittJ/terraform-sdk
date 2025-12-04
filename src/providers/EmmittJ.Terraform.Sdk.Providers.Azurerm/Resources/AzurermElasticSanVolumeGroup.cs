using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for encryption in AzurermElasticSanVolumeGroup.
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeGroupEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption";

    /// <summary>
    /// The current_versioned_key_expiration_timestamp attribute.
    /// </summary>
    public TerraformValue<string> CurrentVersionedKeyExpirationTimestamp
        => AsReference("current_versioned_key_expiration_timestamp");

    /// <summary>
    /// The current_versioned_key_id attribute.
    /// </summary>
    public TerraformValue<string> CurrentVersionedKeyId
        => AsReference("current_versioned_key_id");

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The last_key_rotation_timestamp attribute.
    /// </summary>
    public TerraformValue<string> LastKeyRotationTimestamp
        => AsReference("last_key_rotation_timestamp");

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermElasticSanVolumeGroup.
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeGroupIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for network_rule in AzurermElasticSanVolumeGroup.
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeGroupNetworkRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermElasticSanVolumeGroup.
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeGroupTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_elastic_san_volume_group Terraform resource.
/// Manages a azurerm_elastic_san_volume_group resource.
/// </summary>
public partial class AzurermElasticSanVolumeGroup(string name) : TerraformResource("azurerm_elastic_san_volume_group", name)
{
    /// <summary>
    /// The elastic_san_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticSanId is required")]
    public required TerraformValue<string> ElasticSanId
    {
        get => GetArgument<TerraformValue<string>>("elastic_san_id");
        set => SetArgument("elastic_san_id", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionType
    {
        get => GetArgument<TerraformValue<string>>("encryption_type");
        set => SetArgument("encryption_type", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public TerraformValue<string>? ProtocolType
    {
        get => GetArgument<TerraformValue<string>>("protocol_type");
        set => SetArgument("protocol_type", value);
    }

    /// <summary>
    /// Encryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public TerraformList<AzurermElasticSanVolumeGroupEncryptionBlock>? Encryption
    {
        get => GetArgument<TerraformList<AzurermElasticSanVolumeGroupEncryptionBlock>>("encryption");
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermElasticSanVolumeGroupIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermElasticSanVolumeGroupIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// NetworkRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermElasticSanVolumeGroupNetworkRuleBlock>? NetworkRule
    {
        get => GetArgument<TerraformList<AzurermElasticSanVolumeGroupNetworkRuleBlock>>("network_rule");
        set => SetArgument("network_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticSanVolumeGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticSanVolumeGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
