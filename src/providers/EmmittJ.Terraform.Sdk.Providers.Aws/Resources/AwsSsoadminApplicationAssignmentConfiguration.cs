using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssoadmin_application_assignment_configuration Terraform resource.
/// Manages a aws_ssoadmin_application_assignment_configuration resource.
/// </summary>
public partial class AwsSsoadminApplicationAssignmentConfiguration(string name) : TerraformResource("aws_ssoadmin_application_assignment_configuration", name)
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
    /// The assignment_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentRequired is required")]
    public required TerraformValue<bool> AssignmentRequired
    {
        get => GetArgument<TerraformValue<bool>>("assignment_required");
        set => SetArgument("assignment_required", value);
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
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

}
