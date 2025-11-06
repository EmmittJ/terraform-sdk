using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_parameter resource.
/// </summary>
public class AwsSsmParameter : TerraformResource
{
    public AwsSsmParameter(string name) : base("aws_ssm_parameter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("has_value_wo");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The allowed_pattern attribute.
    /// </summary>
    public string? AllowedPattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("allowed_pattern")?.Value;
        set => this.WithProperty("allowed_pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_type attribute.
    /// </summary>
    public string? DataType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_type")?.Value;
        set => this.WithProperty("data_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The insecure_value attribute.
    /// </summary>
    public string? InsecureValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("insecure_value")?.Value;
        set => this.WithProperty("insecure_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public string? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id")?.Value;
        set => this.WithProperty("key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The overwrite attribute.
    /// </summary>
    public bool? Overwrite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("overwrite")?.Value;
        set => this.WithProperty("overwrite", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public string? Tier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tier")?.Value;
        set => this.WithProperty("tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public string? Value
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value")?.Value;
        set => this.WithProperty("value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    public string? ValueWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value_wo")?.Value;
        set => this.WithProperty("value_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    public double? ValueWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("value_wo_version")?.Value;
        set => this.WithProperty("value_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The has_value_wo attribute.
    /// </summary>
    public TerraformExpression HasValueWo => this["has_value_wo"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
