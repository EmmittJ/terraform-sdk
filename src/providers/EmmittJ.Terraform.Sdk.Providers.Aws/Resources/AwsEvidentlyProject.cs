using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_delivery in AwsEvidentlyProject.
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyProjectDataDeliveryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_delivery";

    /// <summary>
    /// CloudwatchLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogs block(s) allowed")]
    public TerraformList<AwsEvidentlyProjectDataDeliveryBlockCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetArgument<TerraformList<AwsEvidentlyProjectDataDeliveryBlockCloudwatchLogsBlock>>("cloudwatch_logs");
        set => SetArgument("cloudwatch_logs", value);
    }

    /// <summary>
    /// S3Destination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Destination block(s) allowed")]
    public TerraformList<AwsEvidentlyProjectDataDeliveryBlockS3DestinationBlock>? S3Destination
    {
        get => GetArgument<TerraformList<AwsEvidentlyProjectDataDeliveryBlockS3DestinationBlock>>("s3_destination");
        set => SetArgument("s3_destination", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs in AwsEvidentlyProjectDataDeliveryBlock.
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyProjectDataDeliveryBlockCloudwatchLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs";

    /// <summary>
    /// The log_group attribute.
    /// </summary>
    public TerraformValue<string>? LogGroup
    {
        get => GetArgument<TerraformValue<string>>("log_group");
        set => SetArgument("log_group", value);
    }

}

/// <summary>
/// Block type for s3_destination in AwsEvidentlyProjectDataDeliveryBlock.
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyProjectDataDeliveryBlockS3DestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_destination";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEvidentlyProject.
/// Nesting mode: single
/// </summary>
public class AwsEvidentlyProjectTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_evidently_project Terraform resource.
/// Manages a aws_evidently_project resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AwsEvidentlyProject(string name) : TerraformResource("aws_evidently_project", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The active_experiment_count attribute.
    /// </summary>
    public TerraformValue<double> ActiveExperimentCount
        => AsReference("active_experiment_count");

    /// <summary>
    /// The active_launch_count attribute.
    /// </summary>
    public TerraformValue<double> ActiveLaunchCount
        => AsReference("active_launch_count");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => AsReference("created_time");

    /// <summary>
    /// The experiment_count attribute.
    /// </summary>
    public TerraformValue<double> ExperimentCount
        => AsReference("experiment_count");

    /// <summary>
    /// The feature_count attribute.
    /// </summary>
    public TerraformValue<double> FeatureCount
        => AsReference("feature_count");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
        => AsReference("last_updated_time");

    /// <summary>
    /// The launch_count attribute.
    /// </summary>
    public TerraformValue<double> LaunchCount
        => AsReference("launch_count");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// DataDelivery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataDelivery block(s) allowed")]
    public TerraformList<AwsEvidentlyProjectDataDeliveryBlock>? DataDelivery
    {
        get => GetArgument<TerraformList<AwsEvidentlyProjectDataDeliveryBlock>>("data_delivery");
        set => SetArgument("data_delivery", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEvidentlyProjectTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEvidentlyProjectTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
