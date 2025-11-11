using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_group.
/// </summary>
public partial class AwsIamGroupDataSource : TerraformDataSource
{
    public AwsIamGroupDataSource(string name) : base("aws_iam_group", name)
    {
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    [TerraformProperty("group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [TerraformProperty("group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GroupId { get; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Path { get; }

    /// <summary>
    /// The users attribute.
    /// </summary>
    [TerraformProperty("users")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Users { get; }

}
