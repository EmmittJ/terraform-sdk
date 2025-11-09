using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ce_cost_category resource.
/// </summary>
public class AwsCeCostCategory : TerraformResource
{
    public AwsCeCostCategory(string name) : base("aws_ce_cost_category", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("effective_end");
    }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultValue
    {
        get => GetProperty<TerraformProperty<string>>("default_value");
        set => this.WithProperty("default_value", value);
    }

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    public TerraformProperty<string>? EffectiveStart
    {
        get => GetProperty<TerraformProperty<string>>("effective_start");
        set => this.WithProperty("effective_start", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    public TerraformProperty<string>? RuleVersion
    {
        get => GetProperty<TerraformProperty<string>>("rule_version");
        set => this.WithProperty("rule_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The effective_end attribute.
    /// </summary>
    public TerraformExpression EffectiveEnd => this["effective_end"];

}
