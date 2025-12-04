using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for properties in AwsIotThingType.
/// Nesting mode: list
/// </summary>
public class AwsIotThingTypePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "properties";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The searchable_attributes attribute.
    /// </summary>
    public TerraformSet<string> SearchableAttributes
    {
        get => GetArgument<TerraformSet<string>>("searchable_attributes") ?? AsReference("searchable_attributes");
        set => SetArgument("searchable_attributes", value);
    }

}


/// <summary>
/// Represents a aws_iot_thing_type Terraform resource.
/// Manages a aws_iot_thing_type resource.
/// </summary>
public partial class AwsIotThingType(string name) : TerraformResource("aws_iot_thing_type", name)
{
    /// <summary>
    /// The deprecated attribute.
    /// </summary>
    public TerraformValue<bool>? Deprecated
    {
        get => GetArgument<TerraformValue<bool>>("deprecated");
        set => SetArgument("deprecated", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Properties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public TerraformList<AwsIotThingTypePropertiesBlock>? Properties
    {
        get => GetArgument<TerraformList<AwsIotThingTypePropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

}
