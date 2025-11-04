using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_wafregional_rate_based_rule resource.
/// </summary>
public class AwsWafregionalRateBasedRule : TerraformResource
{
    public AwsWafregionalRateBasedRule(string name) : base("aws_wafregional_rate_based_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public string? MetricName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metric_name")?.Value;
        set => this.WithProperty("metric_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rate_key attribute.
    /// </summary>
    public string? RateKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rate_key")?.Value;
        set => this.WithProperty("rate_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    public double? RateLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("rate_limit")?.Value;
        set => this.WithProperty("rate_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
