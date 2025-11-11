using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_user.
/// </summary>
public partial class AwsIamUserDataSource : TerraformDataSource
{
    public AwsIamUserDataSource(string name) : base("aws_iam_user", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

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
    /// The user_id attribute.
    /// </summary>
    [TerraformProperty("user_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserId { get; }

}
