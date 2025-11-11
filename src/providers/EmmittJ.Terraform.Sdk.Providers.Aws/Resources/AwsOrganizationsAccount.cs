using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOrganizationsAccountTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_organizations_account resource.
/// </summary>
public class AwsOrganizationsAccount : TerraformResource
{
    public AwsOrganizationsAccount(string name) : base("aws_organizations_account", name)
    {
    }

    /// <summary>
    /// The close_on_deletion attribute.
    /// </summary>
    [TerraformPropertyName("close_on_deletion")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CloseOnDeletion { get; set; }

    /// <summary>
    /// The create_govcloud attribute.
    /// </summary>
    [TerraformPropertyName("create_govcloud")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CreateGovcloud { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformPropertyName("email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The iam_user_access_to_billing attribute.
    /// </summary>
    [TerraformPropertyName("iam_user_access_to_billing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IamUserAccessToBilling { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ParentId { get; set; } = default!;

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformPropertyName("role_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOrganizationsAccountTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The govcloud_id attribute.
    /// </summary>
    [TerraformPropertyName("govcloud_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GovcloudId => new TerraformReference(this, "govcloud_id");

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    [TerraformPropertyName("joined_method")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JoinedMethod => new TerraformReference(this, "joined_method");

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("joined_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JoinedTimestamp => new TerraformReference(this, "joined_timestamp");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
