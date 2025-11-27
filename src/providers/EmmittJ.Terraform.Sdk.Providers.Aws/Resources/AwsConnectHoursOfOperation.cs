using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for config in AwsConnectHoursOfOperation.
/// Nesting mode: set
/// </summary>
public class AwsConnectHoursOfOperationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// The day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<string> Day
    {
        get => new TerraformReference<string>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// EndTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EndTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndTime block(s) allowed")]
    public required TerraformList<AwsConnectHoursOfOperationConfigBlockEndTimeBlock> EndTime
    {
        get => GetRequiredArgument<TerraformList<AwsConnectHoursOfOperationConfigBlockEndTimeBlock>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// StartTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTime block(s) allowed")]
    public required TerraformList<AwsConnectHoursOfOperationConfigBlockStartTimeBlock> StartTime
    {
        get => GetRequiredArgument<TerraformList<AwsConnectHoursOfOperationConfigBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for end_time in AwsConnectHoursOfOperationConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectHoursOfOperationConfigBlockEndTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end_time";

    /// <summary>
    /// The hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hours is required")]
    public required TerraformValue<double> Hours
    {
        get => new TerraformReference<double>(this, "hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minutes is required")]
    public required TerraformValue<double> Minutes
    {
        get => new TerraformReference<double>(this, "minutes");
        set => SetArgument("minutes", value);
    }

}

/// <summary>
/// Block type for start_time in AwsConnectHoursOfOperationConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectHoursOfOperationConfigBlockStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_time";

    /// <summary>
    /// The hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hours is required")]
    public required TerraformValue<double> Hours
    {
        get => new TerraformReference<double>(this, "hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minutes is required")]
    public required TerraformValue<double> Minutes
    {
        get => new TerraformReference<double>(this, "minutes");
        set => SetArgument("minutes", value);
    }

}


/// <summary>
/// Represents a aws_connect_hours_of_operation Terraform resource.
/// Manages a aws_connect_hours_of_operation resource.
/// </summary>
public partial class AwsConnectHoursOfOperation(string name) : TerraformResource("aws_connect_hours_of_operation", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The hours_of_operation_id attribute.
    /// </summary>
    public TerraformValue<string> HoursOfOperationId
    {
        get => new TerraformReference<string>(this, "hours_of_operation_id");
    }

    /// <summary>
    /// Config block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    public required TerraformSet<AwsConnectHoursOfOperationConfigBlock> Config
    {
        get => GetRequiredArgument<TerraformSet<AwsConnectHoursOfOperationConfigBlock>>("config");
        set => SetArgument("config", value);
    }

}
