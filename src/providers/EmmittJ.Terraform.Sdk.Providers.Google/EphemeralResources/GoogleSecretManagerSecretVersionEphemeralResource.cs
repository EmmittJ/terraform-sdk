using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_secret_manager_secret_version ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class GoogleSecretManagerSecretVersionEphemeralResource : TerraformEphemeralResource
{
    public GoogleSecretManagerSecretVersionEphemeralResource(string name) : base("google_secret_manager_secret_version", name)
    {
    }

    /// <summary>
    /// If true, the secret data returned will not get base64 decoded. Defaults to false.
    /// </summary>
    [TerraformPropertyName("is_secret_data_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsSecretDataBase64 { get; set; }

    /// <summary>
    /// The project to get the secret version for. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The secret to get the secret version for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformPropertyName("secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Secret { get; set; }

    /// <summary>
    /// The version of the secret to get. If it is not provided, the latest version is retrieved.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// The time at which the Secret was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The time at which the Secret was destroyed. Only present if state is DESTROYED.
    /// </summary>
    [TerraformPropertyName("destroy_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DestroyTime => new TerraformReference(this, "destroy_time");

    /// <summary>
    /// True if the current state of the SecretVersion is enabled.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Enabled => new TerraformReference(this, "enabled");

    /// <summary>
    /// The resource name of the SecretVersion. Format: `projects/{{project}}/secrets/{{secret_id}}/versions/{{version}}`.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The secret data. No larger than 64KiB.
    /// </summary>
    [TerraformPropertyName("secret_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecretData => new TerraformReference(this, "secret_data");

}
