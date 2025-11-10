using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class AwsPrometheusScraperDestinationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for role_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsPrometheusScraperRoleConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The source_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceRoleArn
    {
        set => SetProperty("source_role_arn", value);
    }

    /// <summary>
    /// The target_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TargetRoleArn
    {
        set => SetProperty("target_role_arn", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsPrometheusScraperSourceBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsPrometheusScraperTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_prometheus_scraper resource.
/// </summary>
public class AwsPrometheusScraper : TerraformResource
{
    public AwsPrometheusScraper(string name) : base("aws_prometheus_scraper", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("role_arn");
        SetOutput("tags_all");
        SetOutput("alias");
        SetOutput("region");
        SetOutput("scrape_configuration");
        SetOutput("tags");
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformProperty<string> Alias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alias");
        set => SetProperty("alias", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The scrape_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScrapeConfiguration is required")]
    public required TerraformProperty<string> ScrapeConfiguration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scrape_configuration");
        set => SetProperty("scrape_configuration", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    public List<AwsPrometheusScraperDestinationBlock>? Destination
    {
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// Block for role_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsPrometheusScraperRoleConfigurationBlock>? RoleConfiguration
    {
        set => SetProperty("role_configuration", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    public List<AwsPrometheusScraperSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsPrometheusScraperTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
