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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformExpression Configuration => this["configuration"];

}
