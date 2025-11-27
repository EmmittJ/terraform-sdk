using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_prometheus_default_scraper_configuration Terraform data source.
/// Retrieves information about a aws_prometheus_default_scraper_configuration.
/// </summary>
public partial class AwsPrometheusDefaultScraperConfigurationDataSource(string name) : TerraformDataSource("aws_prometheus_default_scraper_configuration", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformValue<string> Configuration
    {
        get => new TerraformReference<string>(this, "configuration");
    }

}
