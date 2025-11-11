using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_assignments in .
/// Nesting mode: list
/// </summary>
public class AwsSsoadminPrincipalApplicationAssignmentsDataSourceApplicationAssignmentsBlock
{



}

/// <summary>
/// Retrieves information about a aws_ssoadmin_principal_application_assignments.
/// </summary>
public class AwsSsoadminPrincipalApplicationAssignmentsDataSource : TerraformDataSource
{
    public AwsSsoadminPrincipalApplicationAssignmentsDataSource(string name) : base("aws_ssoadmin_principal_application_assignments", name)
    {
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    [TerraformPropertyName("instance_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceArn { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformPropertyName("principal_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrincipalId { get; set; }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    [TerraformPropertyName("principal_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrincipalType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for application_assignments.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("application_assignments")]
    public TerraformList<TerraformBlock<AwsSsoadminPrincipalApplicationAssignmentsDataSourceApplicationAssignmentsBlock>>? ApplicationAssignments { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
