using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsIvsChannel.
/// Nesting mode: single
/// </summary>
public class AwsIvsChannelTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ivs_channel Terraform resource.
/// Manages a aws_ivs_channel resource.
/// </summary>
public partial class AwsIvsChannel(string name) : TerraformResource("aws_ivs_channel", name)
{
    /// <summary>
    /// The authorized attribute.
    /// </summary>
    public TerraformValue<bool> Authorized
    {
        get => new TerraformReference<bool>(this, "authorized");
        set => SetArgument("authorized", value);
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
    /// The latency_mode attribute.
    /// </summary>
    public TerraformValue<string> LatencyMode
    {
        get => new TerraformReference<string>(this, "latency_mode");
        set => SetArgument("latency_mode", value);
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
    /// The recording_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string> RecordingConfigurationArn
    {
        get => new TerraformReference<string>(this, "recording_configuration_arn");
        set => SetArgument("recording_configuration_arn", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The ingest_endpoint attribute.
    /// </summary>
    public TerraformValue<string> IngestEndpoint
    {
        get => new TerraformReference<string>(this, "ingest_endpoint");
    }

    /// <summary>
    /// The playback_url attribute.
    /// </summary>
    public TerraformValue<string> PlaybackUrl
    {
        get => new TerraformReference<string>(this, "playback_url");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsIvsChannelTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsIvsChannelTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
