using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_secret_manager_secret_version ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public partial class GoogleSecretManagerSecretVersionEphemeralResource : TerraformEphemeralResource
{
    public GoogleSecretManagerSecretVersionEphemeralResource(string name) : base("google_secret_manager_secret_version", name)
    {
    }

    /// <summary>
    /// If true, the secret data returned will not get base64 decoded. Defaults to false.
    /// </summary>
    [TerraformProperty("is_secret_data_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsSecretDataBase64 { get; set; }

    /// <summary>
    /// The project to get the secret version for. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The secret to get the secret version for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformProperty("secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Secret { get; set; }

    /// <summary>
    /// The version of the secret to get. If it is not provided, the latest version is retrieved.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// The time at which the Secret was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The time at which the Secret was destroyed. Only present if state is DESTROYED.
    /// </summary>
    [TerraformProperty("destroy_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DestroyTime { get; }

    /// <summary>
    /// True if the current state of the SecretVersion is enabled.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The resource name of the SecretVersion. Format: `projects/{{project}}/secrets/{{secret_id}}/versions/{{version}}`.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The secret data. No larger than 64KiB.
    /// </summary>
    [TerraformProperty("secret_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecretData { get; }

}
