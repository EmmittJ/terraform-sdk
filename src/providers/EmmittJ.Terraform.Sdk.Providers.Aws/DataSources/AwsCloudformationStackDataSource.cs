using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudformation_stack.
/// </summary>
public partial class AwsCloudformationStackDataSource : TerraformDataSource
{
    public AwsCloudformationStackDataSource(string name) : base("aws_cloudformation_stack", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    [TerraformProperty("capabilities")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Capabilities { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    [TerraformProperty("disable_rollback")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DisableRollback { get; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("iam_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IamRoleArn { get; }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    [TerraformProperty("notification_arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> NotificationArns { get; }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    [TerraformProperty("outputs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Outputs { get; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Parameters { get; }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [TerraformProperty("template_body")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TemplateBody { get; }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("timeout_in_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TimeoutInMinutes { get; }

}
