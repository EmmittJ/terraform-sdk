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
        get => new TerraformReference<string>(this, "allowed_pattern");
        set => SetArgument("allowed_pattern", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The data_type attribute.
    /// </summary>
    public TerraformValue<string> DataType
    {
        get => new TerraformReference<string>(this, "data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The insecure_value attribute.
    /// </summary>
    public TerraformValue<string> InsecureValue
    {
        get => new TerraformReference<string>(this, "insecure_value");
        set => SetArgument("insecure_value", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The overwrite attribute.
    /// </summary>
    public TerraformValue<bool>? Overwrite
    {
        get => new TerraformReference<bool>(this, "overwrite");
        set => SetArgument("overwrite", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    public TerraformValue<string>? ValueWo
    {
        get => new TerraformReference<string>(this, "value_wo");
        set => SetArgument("value_wo", value);
    }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ValueWoVersion
    {
        get => new TerraformReference<double>(this, "value_wo_version");
        set => SetArgument("value_wo_version", value);
    }

    /// <summary>
    /// The has_value_wo attribute.
    /// </summary>
    public TerraformValue<bool> HasValueWo
    {
        get => new TerraformReference<bool>(this, "has_value_wo");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

}
