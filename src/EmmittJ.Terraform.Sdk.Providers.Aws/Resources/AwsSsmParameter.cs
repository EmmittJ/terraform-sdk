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
    public TerraformProperty<string>? AllowedPattern
    {
        get => GetProperty<TerraformProperty<string>>("allowed_pattern");
        set => this.WithProperty("allowed_pattern", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The data_type attribute.
    /// </summary>
    public TerraformProperty<string>? DataType
    {
        get => GetProperty<TerraformProperty<string>>("data_type");
        set => this.WithProperty("data_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The insecure_value attribute.
    /// </summary>
    public TerraformProperty<string>? InsecureValue
    {
        get => GetProperty<TerraformProperty<string>>("insecure_value");
        set => this.WithProperty("insecure_value", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
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
    /// The overwrite attribute.
    /// </summary>
    public TerraformProperty<bool>? Overwrite
    {
        get => GetProperty<TerraformProperty<bool>>("overwrite");
        set => this.WithProperty("overwrite", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => this.WithProperty("value", value);
    }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    public TerraformProperty<string>? ValueWo
    {
        get => GetProperty<TerraformProperty<string>>("value_wo");
        set => this.WithProperty("value_wo", value);
    }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? ValueWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("value_wo_version");
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
