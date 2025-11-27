using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predicates in AwsWafRateBasedRule.
/// Nesting mode: set
/// </summary>
public class AwsWafRateBasedRulePredicatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predicates";

    /// <summary>
    /// The data_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataId is required")]
    public required TerraformValue<string> DataId
    {
        get => new TerraformReference<string>(this, "data_id");
        set => SetArgument("data_id", value);
    }

    /// <summary>
    /// The negated attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Negated is required")]
    public required TerraformValue<bool> Negated
    {
        get => new TerraformReference<bool>(this, "negated");
        set => SetArgument("negated", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_waf_rate_based_rule Terraform resource.
/// Manages a aws_waf_rate_based_rule resource.
/// </summary>
public partial class AwsWafRateBasedRule(string name) : TerraformResource("aws_waf_rate_based_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rate_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RateKey is required")]
    public required TerraformValue<string> RateKey
    {
        get => new TerraformReference<string>(this, "rate_key");
        set => SetArgument("rate_key", value);
    }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RateLimit is required")]
    public required TerraformValue<double> RateLimit
    {
        get => new TerraformReference<double>(this, "rate_limit");
        set => SetArgument("rate_limit", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Predicates block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafRateBasedRulePredicatesBlock>? Predicates
    {
        get => GetArgument<TerraformSet<AwsWafRateBasedRulePredicatesBlock>>("predicates");
        set => SetArgument("predicates", value);
    }

}
