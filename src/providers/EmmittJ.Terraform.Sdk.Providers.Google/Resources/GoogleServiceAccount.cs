using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleServiceAccountTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a google_service_account resource.
/// </summary>
public partial class GoogleServiceAccount : TerraformResource
{
    public GoogleServiceAccount(string name) : base("google_service_account", name)
    {
    }

    /// <summary>
    /// The account id that is used to generate the service account email address and a stable unique id. It is unique within a project, must be 6-30 characters long, and match the regular expression [a-z]([-a-z0-9]*[a-z0-9]) to comply with RFC1035. Changing this forces a new service account to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformProperty("account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// If set to true, skip service account creation if a service account with the same email already exists.
    /// </summary>
    [TerraformProperty("create_ignore_already_exists")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CreateIgnoreAlreadyExists { get; set; }

    /// <summary>
    /// A text description of the service account. Must be less than or equal to 256 UTF-8 bytes.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Whether the service account is disabled. Defaults to false
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The display name for the service account. Can be updated without creating a new resource.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleServiceAccountTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The e-mail address of the service account. This value should be referenced from any google_iam_policy data sources that would grant the service account privileges.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Email { get; }

    /// <summary>
    /// The Identity of the service account in the form &#39;serviceAccount:{email}&#39;. This value is often used to refer to the service account in order to grant IAM permissions.
    /// </summary>
    [TerraformProperty("member")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Member { get; }

    /// <summary>
    /// The fully-qualified name of the service account.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The unique id of the service account.
    /// </summary>
    [TerraformProperty("unique_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UniqueId { get; }

}
