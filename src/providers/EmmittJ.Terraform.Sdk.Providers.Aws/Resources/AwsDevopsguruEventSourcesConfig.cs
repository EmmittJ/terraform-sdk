using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_sources in .
/// Nesting mode: list
/// </summary>
public partial class AwsDevopsguruEventSourcesConfigEventSourcesBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_devopsguru_event_sources_config resource.
/// </summary>
public partial class AwsDevopsguruEventSourcesConfig : TerraformResource
{
    public AwsDevopsguruEventSourcesConfig(string name) : base("aws_devopsguru_event_sources_config", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for event_sources.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("event_sources")]
    public TerraformList<TerraformBlock<AwsDevopsguruEventSourcesConfigEventSourcesBlock>>? EventSources { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
