using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsAutoscalingTrafficSourceAttachment.
/// Nesting mode: single
/// </summary>
public class AwsAutoscalingTrafficSourceAttachmentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Block type for traffic_source in AwsAutoscalingTrafficSourceAttachment.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingTrafficSourceAttachmentTrafficSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_source";

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformValue<string> Identifier
    {
        get => new TerraformReference<string>(this, "identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_autoscaling_traffic_source_attachment Terraform resource.
/// Manages a aws_autoscaling_traffic_source_attachment resource.
/// </summary>
public partial class AwsAutoscalingTrafficSourceAttachment(string name) : TerraformResource("aws_autoscaling_traffic_source_attachment", name)
{
    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    public required TerraformValue<string> AutoscalingGroupName
    {
        get => new TerraformReference<string>(this, "autoscaling_group_name");
        set => SetArgument("autoscaling_group_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAutoscalingTrafficSourceAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAutoscalingTrafficSourceAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TrafficSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficSource block(s) allowed")]
    public TerraformList<AwsAutoscalingTrafficSourceAttachmentTrafficSourceBlock>? TrafficSource
    {
        get => GetArgument<TerraformList<AwsAutoscalingTrafficSourceAttachmentTrafficSourceBlock>>("traffic_source");
        set => SetArgument("traffic_source", value);
    }

}
