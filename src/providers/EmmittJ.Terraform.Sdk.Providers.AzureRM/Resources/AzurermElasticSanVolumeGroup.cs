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
        set => SetProperty("current_versioned_key_expiration_timestamp", value);
    }

    /// <summary>
    /// The current_versioned_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? CurrentVersionedKeyId
    {
        set => SetProperty("current_versioned_key_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformProperty<string> KeyVaultKeyId
    {
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The last_key_rotation_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? LastKeyRotationTimestamp
    {
        set => SetProperty("last_key_rotation_timestamp", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        set => SetProperty("user_assigned_identity_id", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
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
/// Manages a azurerm_elastic_san_volume_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermElasticSanVolumeGroup : TerraformResource
{
    public AzurermElasticSanVolumeGroup(string name) : base("azurerm_elastic_san_volume_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("elastic_san_id");
        SetOutput("encryption_type");
        SetOutput("id");
        SetOutput("name");
        SetOutput("protocol_type");
    }

    /// <summary>
    /// The elastic_san_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticSanId is required")]
    public required TerraformProperty<string> ElasticSanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("elastic_san_id");
        set => SetProperty("elastic_san_id", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformProperty<string> EncryptionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_type");
        set => SetProperty("encryption_type", value);
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
    /// The protocol_type attribute.
    /// </summary>
    public TerraformProperty<string> ProtocolType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol_type");
        set => SetProperty("protocol_type", value);
    }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public List<AzurermElasticSanVolumeGroupEncryptionBlock>? Encryption
    {
        set => SetProperty("encryption", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermElasticSanVolumeGroupIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for network_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermElasticSanVolumeGroupNetworkRuleBlock>? NetworkRule
    {
        set => SetProperty("network_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermElasticSanVolumeGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
