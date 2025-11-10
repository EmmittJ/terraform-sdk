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
        SetOutput("has_value_wo");
        SetOutput("version");
        SetOutput("allowed_pattern");
        SetOutput("arn");
        SetOutput("data_type");
        SetOutput("description");
        SetOutput("id");
        SetOutput("insecure_value");
        SetOutput("key_id");
        SetOutput("name");
        SetOutput("overwrite");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tier");
        SetOutput("type");
        SetOutput("value");
        SetOutput("value_wo");
        SetOutput("value_wo_version");
    }

    /// <summary>
    /// The allowed_pattern attribute.
    /// </summary>
    public TerraformProperty<string> AllowedPattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("allowed_pattern");
        set => SetProperty("allowed_pattern", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The data_type attribute.
    /// </summary>
    public TerraformProperty<string> DataType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_type");
        set => SetProperty("data_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The insecure_value attribute.
    /// </summary>
    public TerraformProperty<string> InsecureValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("insecure_value");
        set => SetProperty("insecure_value", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_id");
        set => SetProperty("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The overwrite attribute.
    /// </summary>
    public TerraformProperty<bool> Overwrite
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("overwrite");
        set => SetProperty("overwrite", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string> Value
    {
        get => GetRequiredOutput<TerraformProperty<string>>("value");
        set => SetProperty("value", value);
    }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    public TerraformProperty<string> ValueWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("value_wo");
        set => SetProperty("value_wo", value);
    }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    public TerraformProperty<double> ValueWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("value_wo_version");
        set => SetProperty("value_wo_version", value);
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
