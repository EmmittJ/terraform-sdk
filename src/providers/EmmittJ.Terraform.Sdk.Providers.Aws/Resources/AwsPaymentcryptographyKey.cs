using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for key_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsPaymentcryptographyKeyKeyAttributesBlock : TerraformBlock
{
    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    public required TerraformProperty<string> KeyAlgorithm
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_algorithm");
        set => WithProperty("key_algorithm", value);
    }

    /// <summary>
    /// The key_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyClass is required")]
    public required TerraformProperty<string> KeyClass
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_class");
        set => WithProperty("key_class", value);
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUsage is required")]
    public required TerraformProperty<string> KeyUsage
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_usage");
        set => WithProperty("key_usage", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsPaymentcryptographyKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
        this.WithOutput("arn");
        this.WithOutput("id");
        this.WithOutput("key_check_value");
        this.WithOutput("key_origin");
        this.WithOutput("key_state");
        this.WithOutput("tags_all");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Exportable is required")]
    public required TerraformProperty<bool> Exportable
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("exportable");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for key_attributes.
    /// Nesting mode: list
    /// </summary>
    public List<AwsPaymentcryptographyKeyKeyAttributesBlock>? KeyAttributes
    {
        get => GetProperty<List<AwsPaymentcryptographyKeyKeyAttributesBlock>>("key_attributes");
        set => this.WithProperty("key_attributes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsPaymentcryptographyKeyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsPaymentcryptographyKeyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
