using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_paymentcryptography_key resource.
/// </summary>
public class AwsPaymentcryptographyKey : TerraformResource
{
    public AwsPaymentcryptographyKey(string name) : base("aws_paymentcryptography_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("key_check_value");
        this.DeclareOutput("key_origin");
        this.DeclareOutput("key_state");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    public double? DeletionWindowInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("deletion_window_in_days")?.Value;
        set => this.WithProperty("deletion_window_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The exportable attribute.
    /// </summary>
    public bool? Exportable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exportable")?.Value;
        set => this.WithProperty("exportable", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The key_check_value_algorithm attribute.
    /// </summary>
    public string? KeyCheckValueAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_check_value_algorithm")?.Value;
        set => this.WithProperty("key_check_value_algorithm", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The key_check_value attribute.
    /// </summary>
    public TerraformExpression KeyCheckValue => this["key_check_value"];

    /// <summary>
    /// The key_origin attribute.
    /// </summary>
    public TerraformExpression KeyOrigin => this["key_origin"];

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    public TerraformExpression KeyState => this["key_state"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
