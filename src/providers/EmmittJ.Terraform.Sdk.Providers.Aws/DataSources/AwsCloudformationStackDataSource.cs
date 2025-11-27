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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public TerraformSet<string> Capabilities
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "capabilities").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    public TerraformValue<bool> DisableRollback
    {
        get => new TerraformReference<bool>(this, "disable_rollback");
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> IamRoleArn
    {
        get => new TerraformReference<string>(this, "iam_role_arn");
    }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    public TerraformSet<string> NotificationArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "notification_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformMap<string> Outputs
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "outputs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string> Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformValue<string> TemplateBody
    {
        get => new TerraformReference<string>(this, "template_body");
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> TimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "timeout_in_minutes");
    }

}
