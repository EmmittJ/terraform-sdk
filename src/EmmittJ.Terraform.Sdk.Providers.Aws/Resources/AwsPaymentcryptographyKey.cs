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
    public TerraformProperty<double>? DeletionWindowInDays
    {
        get => GetProperty<TerraformProperty<double>>("deletion_window_in_days");
        set => this.WithProperty("deletion_window_in_days", value);
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
    /// The exportable attribute.
    /// </summary>
    public TerraformProperty<bool>? Exportable
    {
        get => GetProperty<TerraformProperty<bool>>("exportable");
        set => this.WithProperty("exportable", value);
    }

    /// <summary>
    /// The key_check_value_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? KeyCheckValueAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("key_check_value_algorithm");
        set => this.WithProperty("key_check_value_algorithm", value);
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
