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
        get => GetArgument<TerraformValue<string>>("alarm_arn");
        set => SetArgument("alarm_arn", value);
    }

    /// <summary>
    /// The alarm_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? AlarmRoleArn
    {
        get => GetArgument<TerraformValue<string>>("alarm_role_arn");
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
        get => GetArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformValue<string> EnvironmentId
        => AsReference("environment_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// Monitor block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppconfigEnvironmentMonitorBlock>? Monitor
    {
        get => GetArgument<TerraformSet<AwsAppconfigEnvironmentMonitorBlock>>("monitor");
        set => SetArgument("monitor", value);
    }

}
