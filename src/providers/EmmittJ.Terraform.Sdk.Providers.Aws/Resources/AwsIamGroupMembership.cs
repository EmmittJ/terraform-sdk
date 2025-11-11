using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_group_membership resource.
/// </summary>
public partial class AwsIamGroupMembership : TerraformResource
{
    public AwsIamGroupMembership(string name) : base("aws_iam_group_membership", name)
    {
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    [TerraformProperty("group")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Group { get; set; }

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
    /// The users attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Users is required")]
    [TerraformProperty("users")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Users { get; set; }

}
