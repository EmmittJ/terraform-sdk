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
    public string? After
    {
        get => GetProperty<TerraformLiteralProperty<string>>("after")?.Value;
        set => this.WithProperty("after", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recipients attribute.
    /// </summary>
    public HashSet<string>? Recipients
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("recipients")?.Value;
        set => this.WithProperty("recipients", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The scan_enabled attribute.
    /// </summary>
    public bool? ScanEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("scan_enabled")?.Value;
        set => this.WithProperty("scan_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    public string? TlsPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tls_policy")?.Value;
        set => this.WithProperty("tls_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
