using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_event_rule Terraform resource.
/// Manages a aws_cloudwatch_event_rule resource.
/// </summary>
public partial class AwsCloudwatchEventRule(string name) : TerraformResource("aws_cloudwatch_event_rule", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    public TerraformValue<string>? EventBusName
    {
        get => new TerraformReference<string>(this, "event_bus_name");
        set => SetArgument("event_bus_name", value);
    }

    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    public TerraformValue<string>? EventPattern
    {
        get => new TerraformReference<string>(this, "event_pattern");
        set => SetArgument("event_pattern", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? IsEnabled
    {
        get => new TerraformReference<bool>(this, "is_enabled");
        set => SetArgument("is_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleExpression
    {
        get => new TerraformReference<string>(this, "schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
