using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public partial class AwsPrometheusScraperDestinationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for role_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsPrometheusScraperRoleConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The source_role_arn attribute.
    /// </summary>
    [TerraformProperty("source_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceRoleArn { get; set; }

    /// <summary>
    /// The target_role_arn attribute.
    /// </summary>
    [TerraformProperty("target_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetRoleArn { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AwsPrometheusScraperSourceBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsPrometheusScraperTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_prometheus_scraper resource.
/// </summary>
public partial class AwsPrometheusScraper : TerraformResource
{
    public AwsPrometheusScraper(string name) : base("aws_prometheus_scraper", name)
    {
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Alias { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The scrape_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScrapeConfiguration is required")]
    [TerraformProperty("scrape_configuration")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ScrapeConfiguration { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("destination")]
    public TerraformList<TerraformBlock<AwsPrometheusScraperDestinationBlock>>? Destination { get; set; }

    /// <summary>
    /// Block for role_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("role_configuration")]
    public TerraformList<TerraformBlock<AwsPrometheusScraperRoleConfigurationBlock>>? RoleConfiguration { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("source")]
    public TerraformList<TerraformBlock<AwsPrometheusScraperSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsPrometheusScraperTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RoleArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
