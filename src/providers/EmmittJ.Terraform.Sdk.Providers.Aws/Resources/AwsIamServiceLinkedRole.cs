using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_service_linked_role resource.
/// </summary>
public partial class AwsIamServiceLinkedRole : TerraformResource
{
    public AwsIamServiceLinkedRole(string name) : base("aws_iam_service_linked_role", name)
    {
    }

    /// <summary>
    /// The aws_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsServiceName is required")]
    [TerraformProperty("aws_service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AwsServiceName { get; set; }

    /// <summary>
    /// The custom_suffix attribute.
    /// </summary>
    [TerraformProperty("custom_suffix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomSuffix { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

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
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformProperty("create_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateDate { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Path { get; }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformProperty("unique_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UniqueId { get; }

}
