using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predicates in .
/// Nesting mode: set
/// </summary>
public class AwsWafRateBasedRulePredicatesBlock : TerraformBlock
{
    /// <summary>
    /// The data_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataId is required")]
    public required TerraformProperty<string> DataId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_id");
        set => WithProperty("data_id", value);
    }

    /// <summary>
    /// The negated attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Negated is required")]
    public required TerraformProperty<bool> Negated
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("negated");
        set => WithProperty("negated", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Manages a aws_waf_rate_based_rule resource.
/// </summary>
public class AwsWafRateBasedRule : TerraformResource
{
    public AwsWafRateBasedRule(string name) : base("aws_waf_rate_based_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformProperty<string> MetricName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("metric_name");
        set => this.WithProperty("metric_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The rate_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RateKey is required")]
    public required TerraformProperty<string> RateKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rate_key");
        set => this.WithProperty("rate_key", value);
    }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RateLimit is required")]
    public required TerraformProperty<double> RateLimit
    {
        get => GetRequiredProperty<TerraformProperty<double>>("rate_limit");
        set => this.WithProperty("rate_limit", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for predicates.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafRateBasedRulePredicatesBlock>? Predicates
    {
        get => GetProperty<HashSet<AwsWafRateBasedRulePredicatesBlock>>("predicates");
        set => this.WithProperty("predicates", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
