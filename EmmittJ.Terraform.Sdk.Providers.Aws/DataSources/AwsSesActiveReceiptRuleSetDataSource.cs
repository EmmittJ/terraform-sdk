using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ses_active_receipt_rule_set.
/// </summary>
public class AwsSesActiveReceiptRuleSetDataSource : TerraformDataSource
{
    public AwsSesActiveReceiptRuleSetDataSource(string name) : base("aws_ses_active_receipt_rule_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("rule_set_name");
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The rule_set_name attribute.
    /// </summary>
    public TerraformExpression RuleSetName => this["rule_set_name"];

}
