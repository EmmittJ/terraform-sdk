using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_role.
/// </summary>
public partial class AwsIamRoleDataSource : TerraformDataSource
{
    public AwsIamRoleDataSource(string name) : base("aws_iam_role", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    [TerraformProperty("assume_role_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AssumeRolePolicy { get; }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformProperty("create_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateDate { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    [TerraformProperty("max_session_duration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxSessionDuration { get; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Path { get; }

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    [TerraformProperty("permissions_boundary")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PermissionsBoundary { get; }

    /// <summary>
    /// The role_last_used attribute.
    /// </summary>
    [TerraformProperty("role_last_used")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RoleLastUsed { get; }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformProperty("unique_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UniqueId { get; }

}
