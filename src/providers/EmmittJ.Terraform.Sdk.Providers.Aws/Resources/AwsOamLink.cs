using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for link_configuration in AwsOamLink.
/// Nesting mode: list
/// </summary>
public class AwsOamLinkLinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "link_configuration";

    /// <summary>
    /// LogGroupConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogGroupConfiguration block(s) allowed")]
    public TerraformList<AwsOamLinkLinkConfigurationBlockLogGroupConfigurationBlock>? LogGroupConfiguration
    {
        get => GetArgument<TerraformList<AwsOamLinkLinkConfigurationBlockLogGroupConfigurationBlock>>("log_group_configuration");
        set => SetArgument("log_group_configuration", value);
    }

    /// <summary>
    /// MetricConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricConfiguration block(s) allowed")]
    public TerraformList<AwsOamLinkLinkConfigurationBlockMetricConfigurationBlock>? MetricConfiguration
    {
        get => GetArgument<TerraformList<AwsOamLinkLinkConfigurationBlockMetricConfigurationBlock>>("metric_configuration");
        set => SetArgument("metric_configuration", value);
    }

}

/// <summary>
/// Block type for log_group_configuration in AwsOamLinkLinkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsOamLinkLinkConfigurationBlockLogGroupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_group_configuration";

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for metric_configuration in AwsOamLinkLinkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsOamLinkLinkConfigurationBlockMetricConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_configuration";

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsOamLink.
/// Nesting mode: single
/// </summary>
public class AwsOamLinkTimeoutsBlock : TerraformBlock
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
/// Represents a aws_oam_link Terraform resource.
/// Manages a aws_oam_link resource.
/// </summary>
public partial class AwsOamLink(string name) : TerraformResource("aws_oam_link", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabelTemplate is required")]
    public required TerraformValue<string> LabelTemplate
    {
        get => GetRequiredArgument<TerraformValue<string>>("label_template");
        set => SetArgument("label_template", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    public required TerraformSet<string> ResourceTypes
    {
        get => GetRequiredArgument<TerraformSet<string>>("resource_types");
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// The sink_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SinkIdentifier is required")]
    public required TerraformValue<string> SinkIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("sink_identifier");
        set => SetArgument("sink_identifier", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string> Label
        => CreateReference("label");

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    public TerraformValue<string> LinkId
        => CreateReference("link_id");

    /// <summary>
    /// The sink_arn attribute.
    /// </summary>
    public TerraformValue<string> SinkArn
        => CreateReference("sink_arn");

    /// <summary>
    /// LinkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkConfiguration block(s) allowed")]
    public TerraformList<AwsOamLinkLinkConfigurationBlock>? LinkConfiguration
    {
        get => GetArgument<TerraformList<AwsOamLinkLinkConfigurationBlock>>("link_configuration");
        set => SetArgument("link_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOamLinkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOamLinkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
