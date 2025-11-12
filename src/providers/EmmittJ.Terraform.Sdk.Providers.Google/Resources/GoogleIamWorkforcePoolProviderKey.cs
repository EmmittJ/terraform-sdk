using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for key_data in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIamWorkforcePoolProviderKeyKeyDataBlock() : TerraformBlock("key_data")
{


    /// <summary>
    /// The specifications for the key. Possible values: [&amp;quot;RSA_2048&amp;quot;, &amp;quot;RSA_3072&amp;quot;, &amp;quot;RSA_4096&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeySpec is required")]
    [TerraformProperty("key_spec")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeySpec { get; set; }



}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIamWorkforcePoolProviderKeyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_iam_workforce_pool_provider_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleIamWorkforcePoolProviderKey : TerraformResource
{
    public GoogleIamWorkforcePoolProviderKey(string name) : base("google_iam_workforce_pool_provider_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID to use for the key, which becomes the final component of the resource name. This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformProperty("key_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The ID of the provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderId is required")]
    [TerraformProperty("provider_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProviderId { get; set; }

    /// <summary>
    /// The purpose of the key. Possible values: [&amp;quot;ENCRYPTION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Use is required")]
    [TerraformProperty("use")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Use { get; set; }

    /// <summary>
    /// The ID of the workforce pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    [TerraformProperty("workforce_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkforcePoolId { get; set; }

    /// <summary>
    /// Block for key_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyData is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KeyData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyData block(s) allowed")]
    [TerraformProperty("key_data")]
    public required TerraformList<GoogleIamWorkforcePoolProviderKeyKeyDataBlock> KeyData { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleIamWorkforcePoolProviderKeyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The time after which the key will be permanently deleted and cannot be recovered.
    /// Note that the key may get purged before this time if the total limit of keys per provider is exceeded.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpireTime { get; }

    /// <summary>
    /// Identifier. The resource name of the key.
    /// Format: &#39;locations/{location}/workforcePools/{workforcePoolId}/providers/{providerId}/keys/{keyId}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The state of the key.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
