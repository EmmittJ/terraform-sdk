using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeGroupEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The current_versioned_key_expiration_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? CurrentVersionedKeyExpirationTimestamp
    {
        get => GetProperty<TerraformProperty<string>>("current_versioned_key_expiration_timestamp");
        set => WithProperty("current_versioned_key_expiration_timestamp", value);
    }

    /// <summary>
    /// The current_versioned_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? CurrentVersionedKeyId
    {
        get => GetProperty<TerraformProperty<string>>("current_versioned_key_id");
        set => WithProperty("current_versioned_key_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformProperty<string> KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The last_key_rotation_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? LastKeyRotationTimestamp
    {
        get => GetProperty<TerraformProperty<string>>("last_key_rotation_timestamp");
        set => WithProperty("last_key_rotation_timestamp", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_id");
        set => WithProperty("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeGroupIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for network_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeGroupNetworkRuleBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformProperty<string>? Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeGroupTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_elastic_san_volume_group resource.
/// </summary>
public class AzurermElasticSanVolumeGroup : TerraformResource
{
    public AzurermElasticSanVolumeGroup(string name) : base("azurerm_elastic_san_volume_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The elastic_san_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticSanId is required")]
    public required TerraformProperty<string> ElasticSanId
    {
        get => GetProperty<TerraformProperty<string>>("elastic_san_id");
        set => this.WithProperty("elastic_san_id", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionType
    {
        get => GetProperty<TerraformProperty<string>>("encryption_type");
        set => this.WithProperty("encryption_type", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public TerraformProperty<string>? ProtocolType
    {
        get => GetProperty<TerraformProperty<string>>("protocol_type");
        set => this.WithProperty("protocol_type", value);
    }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public List<AzurermElasticSanVolumeGroupEncryptionBlock>? Encryption
    {
        get => GetProperty<List<AzurermElasticSanVolumeGroupEncryptionBlock>>("encryption");
        set => this.WithProperty("encryption", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermElasticSanVolumeGroupIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermElasticSanVolumeGroupIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for network_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermElasticSanVolumeGroupNetworkRuleBlock>? NetworkRule
    {
        get => GetProperty<List<AzurermElasticSanVolumeGroupNetworkRuleBlock>>("network_rule");
        set => this.WithProperty("network_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermElasticSanVolumeGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermElasticSanVolumeGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
