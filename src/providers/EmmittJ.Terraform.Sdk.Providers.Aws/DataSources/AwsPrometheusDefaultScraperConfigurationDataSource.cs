using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_prometheus_default_scraper_configuration.
/// </summary>
public class AwsPrometheusDefaultScraperConfigurationDataSource : TerraformDataSource
{
    public AwsPrometheusDefaultScraperConfigurationDataSource(string name) : base("aws_prometheus_default_scraper_configuration", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformPropertyName("configuration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Configuration => new TerraformReference(this, "configuration");

}
