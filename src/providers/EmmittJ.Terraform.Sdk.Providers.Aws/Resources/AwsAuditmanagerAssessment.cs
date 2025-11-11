using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for assessment_reports_destination in .
/// Nesting mode: list
/// </summary>
public partial class AwsAuditmanagerAssessmentAssessmentReportsDestinationBlock : TerraformBlockBase
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformProperty("destination")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    [TerraformProperty("destination_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationType { get; set; }

}

/// <summary>
/// Block type for roles in .
/// Nesting mode: set
/// </summary>
public partial class AwsAuditmanagerAssessmentRolesBlock : TerraformBlockBase
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleType is required")]
    [TerraformProperty("role_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleType { get; set; }

}

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public partial class AwsAuditmanagerAssessmentScopeBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_auditmanager_assessment resource.
/// </summary>
public partial class AwsAuditmanagerAssessment : TerraformResource
{
    public AwsAuditmanagerAssessment(string name) : base("aws_auditmanager_assessment", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The framework_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrameworkId is required")]
    [TerraformProperty("framework_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FrameworkId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for assessment_reports_destination.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("assessment_reports_destination")]
    public partial TerraformList<TerraformBlock<AwsAuditmanagerAssessmentAssessmentReportsDestinationBlock>>? AssessmentReportsDestination { get; set; }

    /// <summary>
    /// Block for roles.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("roles")]
    public partial TerraformSet<TerraformBlock<AwsAuditmanagerAssessmentRolesBlock>>? Roles { get; set; }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("scope")]
    public partial TerraformList<TerraformBlock<AwsAuditmanagerAssessmentScopeBlock>>? Scope { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The roles_all attribute.
    /// </summary>
    [TerraformProperty("roles_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RolesAll { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
