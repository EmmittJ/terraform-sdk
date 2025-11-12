using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppfabricIngestionDestinationDestinationConfigurationBlock() : TerraformBlock("destination_configuration")
{
}

/// <summary>
/// Block type for processing_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppfabricIngestionDestinationProcessingConfigurationBlock() : TerraformBlock("processing_configuration")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAppfabricIngestionDestinationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_appfabric_ingestion_destination resource.
/// </summary>
public partial class AwsAppfabricIngestionDestination : TerraformResource
{
    public AwsAppfabricIngestionDestination(string name) : base("aws_appfabric_ingestion_destination", name)
    {
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBundleArn is required")]
    [TerraformProperty("app_bundle_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppBundleArn { get; set; }

    /// <summary>
    /// The ingestion_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionArn is required")]
    [TerraformProperty("ingestion_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IngestionArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for destination_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("destination_configuration")]
    public TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlock> DestinationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for processing_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("processing_configuration")]
    public TerraformList<AwsAppfabricIngestionDestinationProcessingConfigurationBlock> ProcessingConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsAppfabricIngestionDestinationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
