using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for key_data in .
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderKeyKeyDataBlock : ITerraformBlock
{
    /// <summary>
    /// The format of the key.
    /// </summary>
    [TerraformPropertyName("format")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Format => new TerraformReferenceProperty<TerraformProperty<string>>("", "format");

    /// <summary>
    /// The key data. The format of the key is represented by the format field.
    /// </summary>
    [TerraformPropertyName("key")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Key => new TerraformReferenceProperty<TerraformProperty<string>>("", "key");

    /// <summary>
    /// The specifications for the key. Possible values: [&amp;quot;RSA_2048&amp;quot;, &amp;quot;RSA_3072&amp;quot;, &amp;quot;RSA_4096&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeySpec is required")]
    [TerraformPropertyName("key_spec")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeySpec { get; set; }

    /// <summary>
    /// Latest timestamp when this key is valid. Attempts to use this key after this time will fail.
    /// Only present if the key data represents a X.509 certificate.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits.
    /// Offsets other than &amp;quot;Z&amp;quot; are also accepted.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    [TerraformPropertyName("not_after_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotAfterTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "not_after_time");

    /// <summary>
    /// Earliest timestamp when this key is valid. Attempts to use this key before this time will fail.
    /// Only present if the key data represents a X.509 certificate.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits.
    /// Offsets other than &amp;quot;Z&amp;quot; are also accepted.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    [TerraformPropertyName("not_before_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotBeforeTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "not_before_time");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIamWorkforcePoolProviderKeyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_iam_workforce_pool_provider_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIamWorkforcePoolProviderKey : TerraformResource
{
    public GoogleIamWorkforcePoolProviderKey(string name) : base("google_iam_workforce_pool_provider_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID to use for the key, which becomes the final component of the resource name. This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformPropertyName("key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyId { get; set; }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The ID of the provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderId is required")]
    [TerraformPropertyName("provider_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProviderId { get; set; }

    /// <summary>
    /// The purpose of the key. Possible values: [&amp;quot;ENCRYPTION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Use is required")]
    [TerraformPropertyName("use")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Use { get; set; }

    /// <summary>
    /// The ID of the workforce pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    [TerraformPropertyName("workforce_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkforcePoolId { get; set; }

    /// <summary>
    /// Block for key_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyData is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KeyData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyData block(s) allowed")]
    [TerraformPropertyName("key_data")]
    public TerraformList<TerraformBlock<GoogleIamWorkforcePoolProviderKeyKeyDataBlock>>? KeyData { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleIamWorkforcePoolProviderKeyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time after which the key will be permanently deleted and cannot be recovered.
    /// Note that the key may get purged before this time if the total limit of keys per provider is exceeded.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpireTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expire_time");

    /// <summary>
    /// Identifier. The resource name of the key.
    /// Format: &#39;locations/{location}/workforcePools/{workforcePoolId}/providers/{providerId}/keys/{keyId}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The state of the key.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
