using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ses_active_receipt_rule_set resource.
/// </summary>
public class AwsSesActiveReceiptRuleSet : TerraformResource
{
    public AwsSesActiveReceiptRuleSet(string name) : base("aws_ses_active_receipt_rule_set", name)
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
    /// The rule_set_name attribute.
    /// </summary>
    public string? RuleSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_set_name")?.Value;
        set => this.WithProperty("rule_set_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
