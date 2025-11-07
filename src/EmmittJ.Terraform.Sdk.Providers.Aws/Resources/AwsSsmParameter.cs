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
    public TerraformLiteralProperty<string>? AllowedPattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("allowed_pattern");
        set => this.WithProperty("allowed_pattern", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The data_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_type");
        set => this.WithProperty("data_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The insecure_value attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InsecureValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("insecure_value");
        set => this.WithProperty("insecure_value", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
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
    /// The overwrite attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Overwrite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("overwrite");
        set => this.WithProperty("overwrite", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Value
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value");
        set => this.WithProperty("value", value);
    }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ValueWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value_wo");
        set => this.WithProperty("value_wo", value);
    }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ValueWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("value_wo_version");
        set => this.WithProperty("value_wo_version", value);
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
