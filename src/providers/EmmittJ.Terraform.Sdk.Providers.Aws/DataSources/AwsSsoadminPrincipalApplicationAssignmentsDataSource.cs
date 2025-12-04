using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_assignments in AwsSsoadminPrincipalApplicationAssignmentsDataSource.
/// Nesting mode: list
/// </summary>
public class AwsSsoadminPrincipalApplicationAssignmentsDataSourceApplicationAssignmentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_assignments";

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public TerraformValue<string> ApplicationArn
        => AsReference("application_arn");

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformValue<string> PrincipalType
        => AsReference("principal_type");

}


/// <summary>
/// Represents a aws_ssoadmin_principal_application_assignments Terraform data source.
/// Retrieves information about a aws_ssoadmin_principal_application_assignments.
/// </summary>
public partial class AwsSsoadminPrincipalApplicationAssignmentsDataSource(string name) : TerraformDataSource("aws_ssoadmin_principal_application_assignments", name)
{
    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformValue<string> InstanceArn
    {
        get => GetArgument<TerraformValue<string>>("instance_arn");
        set => SetArgument("instance_arn", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => GetArgument<TerraformValue<string>>("principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    public required TerraformValue<string> PrincipalType
    {
        get => GetArgument<TerraformValue<string>>("principal_type");
        set => SetArgument("principal_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// ApplicationAssignments block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsoadminPrincipalApplicationAssignmentsDataSourceApplicationAssignmentsBlock>? ApplicationAssignments
    {
        get => GetArgument<TerraformList<AwsSsoadminPrincipalApplicationAssignmentsDataSourceApplicationAssignmentsBlock>>("application_assignments");
        set => SetArgument("application_assignments", value);
    }

}
