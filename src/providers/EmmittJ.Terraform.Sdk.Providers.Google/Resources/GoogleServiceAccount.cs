using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleServiceAccountTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

}

/// <summary>
/// Manages a google_service_account resource.
/// </summary>
public class GoogleServiceAccount : TerraformResource
{
    public GoogleServiceAccount(string name) : base("google_service_account", name)
    {
    }

    /// <summary>
    /// The account id that is used to generate the service account email address and a stable unique id. It is unique within a project, must be 6-30 characters long, and match the regular expression [a-z]([-a-z0-9]*[a-z0-9]) to comply with RFC1035. Changing this forces a new service account to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformPropertyName("account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountId { get; set; }

    /// <summary>
    /// If set to true, skip service account creation if a service account with the same email already exists.
    /// </summary>
    [TerraformPropertyName("create_ignore_already_exists")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CreateIgnoreAlreadyExists { get; set; }

    /// <summary>
    /// A text description of the service account. Must be less than or equal to 256 UTF-8 bytes.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Whether the service account is disabled. Defaults to false
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Disabled { get; set; }

    /// <summary>
    /// The display name for the service account. Can be updated without creating a new resource.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleServiceAccountTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The e-mail address of the service account. This value should be referenced from any google_iam_policy data sources that would grant the service account privileges.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Email => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "email");

    /// <summary>
    /// The Identity of the service account in the form &#39;serviceAccount:{email}&#39;. This value is often used to refer to the service account in order to grant IAM permissions.
    /// </summary>
    [TerraformPropertyName("member")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Member => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "member");

    /// <summary>
    /// The fully-qualified name of the service account.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The unique id of the service account.
    /// </summary>
    [TerraformPropertyName("unique_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UniqueId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "unique_id");

}
