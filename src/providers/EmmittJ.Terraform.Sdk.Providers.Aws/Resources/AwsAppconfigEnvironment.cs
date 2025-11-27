using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for monitor in AwsAppconfigEnvironment.
/// Nesting mode: set
/// </summary>
public class AwsAppconfigEnvironmentMonitorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitor";

    /// <summary>
    /// The alarm_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmArn is required")]
    public required TerraformValue<string> AlarmArn
    {
        get => new TerraformReference<string>(this, "alarm_arn");
        set => SetArgument("alarm_arn", value);
    }

    /// <summary>
    /// The alarm_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? AlarmRoleArn
    {
        get => new TerraformReference<string>(this, "alarm_role_arn");
        set => SetArgument("alarm_role_arn", value);
    }

}


/// <summary>
/// Represents a aws_appconfig_environment Terraform resource.
/// Manages a aws_appconfig_environment resource.
/// </summary>
public partial class AwsAppconfigEnvironment(string name) : TerraformResource("aws_appconfig_environment", name)
{
    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformValue<string> EnvironmentId
    {
        get => new TerraformReference<string>(this, "environment_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// Monitor block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppconfigEnvironmentMonitorBlock>? Monitor
    {
        get => GetArgument<TerraformSet<AwsAppconfigEnvironmentMonitorBlock>>("monitor");
        set => SetArgument("monitor", value);
    }

}
