using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_sources in AwsDevopsguruEventSourcesConfig.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruEventSourcesConfigEventSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_sources";

    /// <summary>
    /// AmazonCodeGuruProfiler block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruEventSourcesConfigEventSourcesBlockAmazonCodeGuruProfilerBlock>? AmazonCodeGuruProfiler
    {
        get => GetArgument<TerraformList<AwsDevopsguruEventSourcesConfigEventSourcesBlockAmazonCodeGuruProfilerBlock>>("amazon_code_guru_profiler");
        set => SetArgument("amazon_code_guru_profiler", value);
    }

}

/// <summary>
/// Block type for amazon_code_guru_profiler in AwsDevopsguruEventSourcesConfigEventSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruEventSourcesConfigEventSourcesBlockAmazonCodeGuruProfilerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amazon_code_guru_profiler";

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Represents a aws_devopsguru_event_sources_config Terraform resource.
/// Manages a aws_devopsguru_event_sources_config resource.
/// </summary>
public partial class AwsDevopsguruEventSourcesConfig(string name) : TerraformResource("aws_devopsguru_event_sources_config", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// EventSources block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruEventSourcesConfigEventSourcesBlock>? EventSources
    {
        get => GetArgument<TerraformList<AwsDevopsguruEventSourcesConfigEventSourcesBlock>>("event_sources");
        set => SetArgument("event_sources", value);
    }

}
