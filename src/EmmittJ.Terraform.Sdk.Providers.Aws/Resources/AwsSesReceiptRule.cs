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
    public TerraformProperty<string>? After
    {
        get => GetProperty<TerraformProperty<string>>("after");
        set => this.WithProperty("after", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The recipients attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Recipients
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("recipients");
        set => this.WithProperty("recipients", value);
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
    /// The rule_set_name attribute.
    /// </summary>
    public TerraformProperty<string>? RuleSetName
    {
        get => GetProperty<TerraformProperty<string>>("rule_set_name");
        set => this.WithProperty("rule_set_name", value);
    }

    /// <summary>
    /// The scan_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ScanEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("scan_enabled");
        set => this.WithProperty("scan_enabled", value);
    }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    public TerraformProperty<string>? TlsPolicy
    {
        get => GetProperty<TerraformProperty<string>>("tls_policy");
        set => this.WithProperty("tls_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
