using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_assignments in .
/// Nesting mode: list
/// </summary>
public class AwsSsoadminPrincipalApplicationAssignmentsDataSourceApplicationAssignmentsBlock : ITerraformBlock
{
    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [TerraformPropertyName("application_arn")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplicationArn => new TerraformReferenceProperty<TerraformProperty<string>>("", "application_arn");

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [TerraformPropertyName("principal_type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalType => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_type");

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
    public required TerraformProperty<TerraformProperty<string>> InstanceArn { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformPropertyName("principal_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrincipalId { get; set; }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    [TerraformPropertyName("principal_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrincipalType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for application_assignments.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("application_assignments")]
    public TerraformList<TerraformBlock<AwsSsoadminPrincipalApplicationAssignmentsDataSourceApplicationAssignmentsBlock>>? ApplicationAssignments { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
