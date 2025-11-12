using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirestoreUserCredsTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_firestore_user_creds resource.
/// </summary>
public partial class GoogleFirestoreUserCreds : TerraformResource
{
    public GoogleFirestoreUserCreds(string name) : base("google_firestore_user_creds", name)
    {
    }

    /// <summary>
    /// The Firestore database ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformProperty("database")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Database { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID to use for the user creds, which will become the final component
    /// of the user cred&#39;s resource name.
    /// 
    /// This value should be 4-63 characters. Valid characters are /[a-z][0-9]-/
    /// with first character a letter and the last a letter or a number. Must not
    /// be UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleFirestoreUserCredsTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp at which these user creds were created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Describes the Resource Identity principal.
    /// </summary>
    [TerraformProperty("resource_identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ResourceIdentity { get; }

    /// <summary>
    /// The plaintext server-generated password for the user creds.
    /// </summary>
    [TerraformProperty("secure_password")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecurePassword { get; }

    /// <summary>
    /// The state of the user creds.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The timestamp at which these user creds were updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
