using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("role_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public string? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias")?.Value;
        set => this.WithProperty("alias", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scrape_configuration attribute.
    /// </summary>
    public string? ScrapeConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scrape_configuration")?.Value;
        set => this.WithProperty("scrape_configuration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
