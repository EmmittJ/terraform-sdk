using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssoadmin_application_assignments Terraform data source.
/// Retrieves information about a aws_ssoadmin_application_assignments.
/// </summary>
public partial class AwsSsoadminApplicationAssignmentsDataSource(string name) : TerraformDataSource("aws_ssoadmin_application_assignments", name)
{
    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationArn is required")]
    public required TerraformValue<string> ApplicationArn
    {
        get => GetArgument<TerraformValue<string>>("application_arn");
        set => SetArgument("application_arn", value);
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
    /// The application_assignments attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ApplicationAssignments
        => AsReference("application_assignments");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

}
