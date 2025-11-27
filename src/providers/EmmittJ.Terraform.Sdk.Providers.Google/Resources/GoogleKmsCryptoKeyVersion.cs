using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for external_protection_level_options in GoogleKmsCryptoKeyVersion.
/// Nesting mode: list
/// </summary>
public class GoogleKmsCryptoKeyVersionExternalProtectionLevelOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_protection_level_options";

    /// <summary>
    /// The path to the external key material on the EKM when using EkmConnection e.g., &amp;quot;v0/my/key&amp;quot;. Set this field instead of externalKeyUri when using an EkmConnection.
    /// </summary>
    public TerraformValue<string>? EkmConnectionKeyPath
    {
        get => new TerraformReference<string>(this, "ekm_connection_key_path");
        set => SetArgument("ekm_connection_key_path", value);
    }

    /// <summary>
    /// The URI for an external resource that this CryptoKeyVersion represents.
    /// </summary>
    public TerraformValue<string>? ExternalKeyUri
    {
        get => new TerraformReference<string>(this, "external_key_uri");
        set => SetArgument("external_key_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleKmsCryptoKeyVersion.
/// Nesting mode: single
/// </summary>
public class GoogleKmsCryptoKeyVersionTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_kms_crypto_key_version Terraform resource.
/// Manages a google_kms_crypto_key_version resource.
/// </summary>
public partial class GoogleKmsCryptoKeyVersion(string name) : TerraformResource("google_kms_crypto_key_version", name)
{
    /// <summary>
    /// The name of the cryptoKey associated with the CryptoKeyVersions.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyring}}/cryptoKeys/{{cryptoKey}}&#39;&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    public required TerraformValue<string> CryptoKey
    {
        get => new TerraformReference<string>(this, "crypto_key");
        set => SetArgument("crypto_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The current state of the CryptoKeyVersion. Note: you can only specify this field to manually &#39;ENABLE&#39; or &#39;DISABLE&#39; the CryptoKeyVersion,
    /// otherwise the value of this field is always retrieved automatically. Possible values: [&amp;quot;PENDING_GENERATION&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;DESTROYED&amp;quot;, &amp;quot;DESTROY_SCHEDULED&amp;quot;, &amp;quot;PENDING_IMPORT&amp;quot;, &amp;quot;IMPORT_FAILED&amp;quot;]
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The CryptoKeyVersionAlgorithm that this CryptoKeyVersion supports.
    /// </summary>
    public TerraformValue<string> Algorithm
    {
        get => new TerraformReference<string>(this, "algorithm");
    }

    /// <summary>
    /// Statement that was generated and signed by the HSM at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google.
    /// Only provided for key versions with protectionLevel HSM.
    /// </summary>
    public TerraformList<TerraformMap<object>> Attestation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "attestation").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time this CryptoKeyVersion key material was generated
    /// </summary>
    public TerraformValue<string> GenerateTime
    {
        get => new TerraformReference<string>(this, "generate_time");
    }

    /// <summary>
    /// The resource name for this CryptoKeyVersion.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The ProtectionLevel describing how crypto operations are performed with this CryptoKeyVersion.
    /// </summary>
    public TerraformValue<string> ProtectionLevel
    {
        get => new TerraformReference<string>(this, "protection_level");
    }

    /// <summary>
    /// ExternalProtectionLevelOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalProtectionLevelOptions block(s) allowed")]
    public TerraformList<GoogleKmsCryptoKeyVersionExternalProtectionLevelOptionsBlock>? ExternalProtectionLevelOptions
    {
        get => GetArgument<TerraformList<GoogleKmsCryptoKeyVersionExternalProtectionLevelOptionsBlock>>("external_protection_level_options");
        set => SetArgument("external_protection_level_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleKmsCryptoKeyVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleKmsCryptoKeyVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
