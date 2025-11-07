using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ses_receipt_rule resource.
/// </summary>
public class AwsSesReceiptRule : TerraformResource
{
    public AwsSesReceiptRule(string name) : base("aws_ses_receipt_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The after attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? After
    {
        get => GetProperty<TerraformLiteralProperty<string>>("after");
        set => this.WithProperty("after", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recipients attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Recipients
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("recipients");
        set => this.WithProperty("recipients", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rule_set_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RuleSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_set_name");
        set => this.WithProperty("rule_set_name", value);
    }

    /// <summary>
    /// The scan_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ScanEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("scan_enabled");
        set => this.WithProperty("scan_enabled", value);
    }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TlsPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tls_policy");
        set => this.WithProperty("tls_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
