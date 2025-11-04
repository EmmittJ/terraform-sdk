using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_prometheus_default_scraper_configuration.
/// </summary>
public class AwsPrometheusDefaultScraperConfigurationDataSource : TerraformDataSource
{
    public AwsPrometheusDefaultScraperConfigurationDataSource(string name) : base("aws_prometheus_default_scraper_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("configuration");
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformExpression Configuration => this["configuration"];

}
