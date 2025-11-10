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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformPropertyName("configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Configuration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "configuration");

}
