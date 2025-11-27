using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_sharing_preference in AwsRekognitionStreamProcessor.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorDataSharingPreferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_sharing_preference";

    /// <summary>
    /// Do you want to share data with Rekognition to improve model performance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OptIn is required")]
    public required TerraformValue<bool> OptIn
    {
        get => new TerraformReference<bool>(this, "opt_in");
        set => SetArgument("opt_in", value);
    }

}


/// <summary>
/// Block type for input in AwsRekognitionStreamProcessor.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input";

    /// <summary>
    /// KinesisVideoStream block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorInputBlockKinesisVideoStreamBlock>? KinesisVideoStream
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorInputBlockKinesisVideoStreamBlock>>("kinesis_video_stream");
        set => SetArgument("kinesis_video_stream", value);
    }

}

/// <summary>
/// Block type for kinesis_video_stream in AwsRekognitionStreamProcessorInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorInputBlockKinesisVideoStreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_video_stream";

    /// <summary>
    /// ARN of the Kinesis video stream stream that streams the source video.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

}


/// <summary>
/// Block type for notification_channel in AwsRekognitionStreamProcessor.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorNotificationChannelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_channel";

    /// <summary>
    /// The Amazon Resource Number (ARN) of the Amazon Amazon Simple Notification Service topic to which Amazon Rekognition posts the completion status.
    /// </summary>
    public TerraformValue<string>? SnsTopicArn
    {
        get => new TerraformReference<string>(this, "sns_topic_arn");
        set => SetArgument("sns_topic_arn", value);
    }

}


/// <summary>
/// Block type for output in AwsRekognitionStreamProcessor.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output";

    /// <summary>
    /// KinesisDataStream block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorOutputBlockKinesisDataStreamBlock>? KinesisDataStream
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorOutputBlockKinesisDataStreamBlock>>("kinesis_data_stream");
        set => SetArgument("kinesis_data_stream", value);
    }

    /// <summary>
    /// S3Destination block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorOutputBlockS3DestinationBlock>? S3Destination
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorOutputBlockS3DestinationBlock>>("s3_destination");
        set => SetArgument("s3_destination", value);
    }

}

/// <summary>
/// Block type for kinesis_data_stream in AwsRekognitionStreamProcessorOutputBlock.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorOutputBlockKinesisDataStreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_data_stream";

    /// <summary>
    /// ARN of the output Amazon Kinesis Data Streams stream.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

}

/// <summary>
/// Block type for s3_destination in AwsRekognitionStreamProcessorOutputBlock.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorOutputBlockS3DestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_destination";

    /// <summary>
    /// The name of the Amazon S3 bucket you want to associate with the streaming video project.
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The prefix value of the location within the bucket that you want the information to be published to.
    /// </summary>
    public TerraformValue<string>? KeyPrefix
    {
        get => new TerraformReference<string>(this, "key_prefix");
        set => SetArgument("key_prefix", value);
    }

}


/// <summary>
/// Block type for regions_of_interest in AwsRekognitionStreamProcessor.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorRegionsOfInterestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regions_of_interest";

    /// <summary>
    /// BoundingBox block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorRegionsOfInterestBlockBoundingBoxBlock>? BoundingBox
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorRegionsOfInterestBlockBoundingBoxBlock>>("bounding_box");
        set => SetArgument("bounding_box", value);
    }

    /// <summary>
    /// Polygon block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorRegionsOfInterestBlockPolygonBlock>? Polygon
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorRegionsOfInterestBlockPolygonBlock>>("polygon");
        set => SetArgument("polygon", value);
    }

}

/// <summary>
/// Block type for bounding_box in AwsRekognitionStreamProcessorRegionsOfInterestBlock.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorRegionsOfInterestBlockBoundingBoxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bounding_box";

    /// <summary>
    /// Height of the bounding box as a ratio of the overall image height.
    /// </summary>
    public TerraformValue<double>? Height
    {
        get => new TerraformReference<double>(this, "height");
        set => SetArgument("height", value);
    }

    /// <summary>
    /// Left coordinate of the bounding box as a ratio of overall image width.
    /// </summary>
    public TerraformValue<double>? Left
    {
        get => new TerraformReference<double>(this, "left");
        set => SetArgument("left", value);
    }

    /// <summary>
    /// Top coordinate of the bounding box as a ratio of overall image height.
    /// </summary>
    public TerraformValue<double>? Top
    {
        get => new TerraformReference<double>(this, "top");
        set => SetArgument("top", value);
    }

    /// <summary>
    /// Width of the bounding box as a ratio of the overall image width.
    /// </summary>
    public TerraformValue<double>? Width
    {
        get => new TerraformReference<double>(this, "width");
        set => SetArgument("width", value);
    }

}

/// <summary>
/// Block type for polygon in AwsRekognitionStreamProcessorRegionsOfInterestBlock.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorRegionsOfInterestBlockPolygonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "polygon";

    /// <summary>
    /// The value of the X coordinate for a point on a Polygon.
    /// </summary>
    public TerraformValue<double>? X
    {
        get => new TerraformReference<double>(this, "x");
        set => SetArgument("x", value);
    }

    /// <summary>
    /// The value of the Y coordinate for a point on a Polygon.
    /// </summary>
    public TerraformValue<double>? Y
    {
        get => new TerraformReference<double>(this, "y");
        set => SetArgument("y", value);
    }

}


/// <summary>
/// Block type for settings in AwsRekognitionStreamProcessor.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "settings";

    /// <summary>
    /// ConnectedHome block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorSettingsBlockConnectedHomeBlock>? ConnectedHome
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorSettingsBlockConnectedHomeBlock>>("connected_home");
        set => SetArgument("connected_home", value);
    }

    /// <summary>
    /// FaceSearch block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorSettingsBlockFaceSearchBlock>? FaceSearch
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorSettingsBlockFaceSearchBlock>>("face_search");
        set => SetArgument("face_search", value);
    }

}

/// <summary>
/// Block type for connected_home in AwsRekognitionStreamProcessorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorSettingsBlockConnectedHomeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connected_home";

    /// <summary>
    /// Specifies what you want to detect in the video, such as people, packages, or pets.
    /// </summary>
    public TerraformList<string>? Labels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The minimum confidence required to label an object in the video.
    /// </summary>
    public TerraformValue<double> MinConfidence
    {
        get => new TerraformReference<double>(this, "min_confidence");
        set => SetArgument("min_confidence", value);
    }

}

/// <summary>
/// Block type for face_search in AwsRekognitionStreamProcessorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorSettingsBlockFaceSearchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "face_search";

    /// <summary>
    /// The ID of a collection that contains faces that you want to search for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    public required TerraformValue<string> CollectionId
    {
        get => new TerraformReference<string>(this, "collection_id");
        set => SetArgument("collection_id", value);
    }

    /// <summary>
    /// Minimum face match confidence score that must be met to return a result for a recognized face.
    /// </summary>
    public TerraformValue<double> FaceMatchThreshold
    {
        get => new TerraformReference<double>(this, "face_match_threshold");
        set => SetArgument("face_match_threshold", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRekognitionStreamProcessor.
/// Nesting mode: single
/// </summary>
public class AwsRekognitionStreamProcessorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_rekognition_stream_processor Terraform resource.
/// Manages a aws_rekognition_stream_processor resource.
/// </summary>
public partial class AwsRekognitionStreamProcessor(string name) : TerraformResource("aws_rekognition_stream_processor", name)
{
    /// <summary>
    /// The identifier for your AWS Key Management Service key (AWS KMS key). You can supply the Amazon Resource Name (ARN) of your KMS key, the ID of your KMS key, an alias for your KMS key, or an alias ARN.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// An identifier you assign to the stream processor.
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
    /// The Amazon Resource Number (ARN) of the IAM role that allows access to the stream processor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
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
    /// The stream_processor_arn attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> StreamProcessorArn
    {
        get => new TerraformReference<string>(this, "stream_processor_arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// DataSharingPreference block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorDataSharingPreferenceBlock>? DataSharingPreference
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorDataSharingPreferenceBlock>>("data_sharing_preference");
        set => SetArgument("data_sharing_preference", value);
    }

    /// <summary>
    /// Input block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorInputBlock>? Input
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorInputBlock>>("input");
        set => SetArgument("input", value);
    }

    /// <summary>
    /// NotificationChannel block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorNotificationChannelBlock>? NotificationChannel
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorNotificationChannelBlock>>("notification_channel");
        set => SetArgument("notification_channel", value);
    }

    /// <summary>
    /// Output block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorOutputBlock>? Output
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorOutputBlock>>("output");
        set => SetArgument("output", value);
    }

    /// <summary>
    /// RegionsOfInterest block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorRegionsOfInterestBlock>? RegionsOfInterest
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorRegionsOfInterestBlock>>("regions_of_interest");
        set => SetArgument("regions_of_interest", value);
    }

    /// <summary>
    /// Settings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRekognitionStreamProcessorSettingsBlock>? Settings
    {
        get => GetArgument<TerraformList<AwsRekognitionStreamProcessorSettingsBlock>>("settings");
        set => SetArgument("settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRekognitionStreamProcessorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRekognitionStreamProcessorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
