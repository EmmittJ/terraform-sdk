using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_sources in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruEventSourcesConfigEventSourcesBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_devopsguru_event_sources_config resource.
/// </summary>
public class AwsDevopsguruEventSourcesConfig : TerraformResource
{
    public AwsDevopsguruEventSourcesConfig(string name) : base("aws_devopsguru_event_sources_config", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for event_sources.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("event_sources")]
    public TerraformList<TerraformBlock<AwsDevopsguruEventSourcesConfigEventSourcesBlock>>? EventSources { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
