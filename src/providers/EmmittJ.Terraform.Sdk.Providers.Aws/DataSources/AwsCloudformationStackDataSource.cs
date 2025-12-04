using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudformation_stack Terraform data source.
/// Retrieves information about a aws_cloudformation_stack.
/// </summary>
public partial class AwsCloudformationStackDataSource(string name) : TerraformDataSource("aws_cloudformation_stack", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public TerraformSet<string> Capabilities
        => AsReference("capabilities");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    public TerraformValue<bool> DisableRollback
        => AsReference("disable_rollback");

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> IamRoleArn
        => AsReference("iam_role_arn");

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    public TerraformSet<string> NotificationArns
        => AsReference("notification_arns");

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformMap<string> Outputs
        => AsReference("outputs");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string> Parameters
        => AsReference("parameters");

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformValue<string> TemplateBody
        => AsReference("template_body");

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> TimeoutInMinutes
        => AsReference("timeout_in_minutes");

}
