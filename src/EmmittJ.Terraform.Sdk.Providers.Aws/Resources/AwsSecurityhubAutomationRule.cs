using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_automation_rule resource.
/// </summary>
public class AwsSecurityhubAutomationRule : TerraformResource
{
    public AwsSecurityhubAutomationRule(string name) : base("aws_securityhub_automation_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The is_terminal attribute.
    /// </summary>
    public TerraformProperty<bool>? IsTerminal
    {
        get => GetProperty<TerraformProperty<bool>>("is_terminal");
        set => this.WithProperty("is_terminal", value);
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
    /// The rule_name attribute.
    /// </summary>
    public TerraformProperty<string>? RuleName
    {
        get => GetProperty<TerraformProperty<string>>("rule_name");
        set => this.WithProperty("rule_name", value);
    }

    /// <summary>
    /// The rule_order attribute.
    /// </summary>
    public TerraformProperty<double>? RuleOrder
    {
        get => GetProperty<TerraformProperty<double>>("rule_order");
        set => this.WithProperty("rule_order", value);
    }

    /// <summary>
    /// The rule_status attribute.
    /// </summary>
    public TerraformProperty<string>? RuleStatus
    {
        get => GetProperty<TerraformProperty<string>>("rule_status");
        set => this.WithProperty("rule_status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
