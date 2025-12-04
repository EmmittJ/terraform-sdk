using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssm_parameter Terraform resource.
/// Manages a aws_ssm_parameter resource.
/// </summary>
public partial class AwsSsmParameter(string name) : TerraformResource("aws_ssm_parameter", name)
{
    /// <summary>
    /// The allowed_pattern attribute.
    /// </summary>
    public TerraformValue<string>? AllowedPattern
    {
        get => GetArgument<TerraformValue<string>>("allowed_pattern");
        set => SetArgument("allowed_pattern", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The data_type attribute.
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The insecure_value attribute.
    /// </summary>
    public TerraformValue<string>? InsecureValue
    {
        get => GetArgument<TerraformValue<string>>("insecure_value");
        set => SetArgument("insecure_value", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyId
    {
        get => GetArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The overwrite attribute.
    /// </summary>
    public TerraformValue<bool>? Overwrite
    {
        get => GetArgument<TerraformValue<bool>>("overwrite");
        set => SetArgument("overwrite", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string>? Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    public TerraformValue<string>? ValueWo
    {
        get => GetArgument<TerraformValue<string>>("value_wo");
        set => SetArgument("value_wo", value);
    }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ValueWoVersion
    {
        get => GetArgument<TerraformValue<double>>("value_wo_version");
        set => SetArgument("value_wo_version", value);
    }

    /// <summary>
    /// The has_value_wo attribute.
    /// </summary>
    public TerraformValue<bool> HasValueWo
        => AsReference("has_value_wo");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
        => AsReference("version");

}
