using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsBedrockProvisionedModelThroughput.
/// Nesting mode: single
/// </summary>
public class AwsBedrockProvisionedModelThroughputTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_bedrock_provisioned_model_throughput Terraform resource.
/// Manages a aws_bedrock_provisioned_model_throughput resource.
/// </summary>
public partial class AwsBedrockProvisionedModelThroughput(string name) : TerraformResource("aws_bedrock_provisioned_model_throughput", name)
{
    /// <summary>
    /// The commitment_duration attribute.
    /// </summary>
    public TerraformValue<string>? CommitmentDuration
    {
        get => GetArgument<TerraformValue<string>>("commitment_duration");
        set => SetArgument("commitment_duration", value);
    }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelArn is required")]
    public required TerraformValue<string> ModelArn
    {
        get => GetArgument<TerraformValue<string>>("model_arn");
        set => SetArgument("model_arn", value);
    }

    /// <summary>
    /// The model_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelUnits is required")]
    public required TerraformValue<double> ModelUnits
    {
        get => GetArgument<TerraformValue<double>>("model_units");
        set => SetArgument("model_units", value);
    }

    /// <summary>
    /// The provisioned_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisionedModelName is required")]
    public required TerraformValue<string> ProvisionedModelName
    {
        get => GetArgument<TerraformValue<string>>("provisioned_model_name");
        set => SetArgument("provisioned_model_name", value);
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
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The provisioned_model_arn attribute.
    /// </summary>
    public TerraformValue<string> ProvisionedModelArn
        => AsReference("provisioned_model_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockProvisionedModelThroughputTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockProvisionedModelThroughputTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
