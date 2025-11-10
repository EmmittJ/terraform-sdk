using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for external_protection_level_options in .
/// Nesting mode: list
/// </summary>
public class GoogleKmsCryptoKeyVersionExternalProtectionLevelOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The path to the external key material on the EKM when using EkmConnection e.g., &amp;quot;v0/my/key&amp;quot;. Set this field instead of externalKeyUri when using an EkmConnection.
    /// </summary>
    public TerraformProperty<string>? EkmConnectionKeyPath
    {
        set => SetProperty("ekm_connection_key_path", value);
    }

    /// <summary>
    /// The URI for an external resource that this CryptoKeyVersion represents.
    /// </summary>
    public TerraformProperty<string>? ExternalKeyUri
    {
        set => SetProperty("external_key_uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleKmsCryptoKeyVersionTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_kms_crypto_key_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleKmsCryptoKeyVersion : TerraformResource
{
    public GoogleKmsCryptoKeyVersion(string name) : base("google_kms_crypto_key_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("algorithm");
        SetOutput("attestation");
        SetOutput("generate_time");
        SetOutput("name");
        SetOutput("protection_level");
        SetOutput("crypto_key");
        SetOutput("id");
        SetOutput("state");
    }

    /// <summary>
    /// The name of the cryptoKey associated with the CryptoKeyVersions.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyring}}/cryptoKeys/{{cryptoKey}}&#39;&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    public required TerraformProperty<string> CryptoKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("crypto_key");
        set => SetProperty("crypto_key", value);
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
    /// The current state of the CryptoKeyVersion. Note: you can only specify this field to manually &#39;ENABLE&#39; or &#39;DISABLE&#39; the CryptoKeyVersion,
    /// otherwise the value of this field is always retrieved automatically. Possible values: [&amp;quot;PENDING_GENERATION&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;DESTROYED&amp;quot;, &amp;quot;DESTROY_SCHEDULED&amp;quot;, &amp;quot;PENDING_IMPORT&amp;quot;, &amp;quot;IMPORT_FAILED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
    }

    /// <summary>
    /// Block for external_protection_level_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalProtectionLevelOptions block(s) allowed")]
    public List<GoogleKmsCryptoKeyVersionExternalProtectionLevelOptionsBlock>? ExternalProtectionLevelOptions
    {
        set => SetProperty("external_protection_level_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleKmsCryptoKeyVersionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The CryptoKeyVersionAlgorithm that this CryptoKeyVersion supports.
    /// </summary>
    public TerraformExpression Algorithm => this["algorithm"];

    /// <summary>
    /// Statement that was generated and signed by the HSM at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google.
    /// Only provided for key versions with protectionLevel HSM.
    /// </summary>
    public TerraformExpression Attestation => this["attestation"];

    /// <summary>
    /// The time this CryptoKeyVersion key material was generated
    /// </summary>
    public TerraformExpression GenerateTime => this["generate_time"];

    /// <summary>
    /// The resource name for this CryptoKeyVersion.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The ProtectionLevel describing how crypto operations are performed with this CryptoKeyVersion.
    /// </summary>
    public TerraformExpression ProtectionLevel => this["protection_level"];

}
