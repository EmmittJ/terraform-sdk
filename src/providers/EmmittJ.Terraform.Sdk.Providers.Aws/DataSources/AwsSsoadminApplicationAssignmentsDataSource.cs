using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssoadmin_application_assignments.
/// </summary>
public partial class AwsSsoadminApplicationAssignmentsDataSource : TerraformDataSource
{
    public AwsSsoadminApplicationAssignmentsDataSource(string name) : base("aws_ssoadmin_application_assignments", name)
    {
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationArn is required")]
    [TerraformProperty("application_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApplicationArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The application_assignments attribute.
    /// </summary>
    [TerraformProperty("application_assignments")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ApplicationAssignments { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
