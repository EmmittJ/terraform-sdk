using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_role.
/// </summary>
public class AwsIamRoleDataSource : TerraformDataSource
{
    public AwsIamRoleDataSource(string name) : base("aws_iam_role", name)
    {
    }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    [TerraformPropertyName("assume_role_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssumeRolePolicy => new TerraformReference(this, "assume_role_policy");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformPropertyName("create_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateDate => new TerraformReference(this, "create_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    [TerraformPropertyName("max_session_duration")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxSessionDuration => new TerraformReference(this, "max_session_duration");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Path => new TerraformReference(this, "path");

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    [TerraformPropertyName("permissions_boundary")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PermissionsBoundary => new TerraformReference(this, "permissions_boundary");

    /// <summary>
    /// The role_last_used attribute.
    /// </summary>
    [TerraformPropertyName("role_last_used")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RoleLastUsed => new TerraformReference(this, "role_last_used");

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformPropertyName("unique_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UniqueId => new TerraformReference(this, "unique_id");

}
