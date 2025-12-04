using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for properties in AwsIotThingGroup.
/// Nesting mode: list
/// </summary>
public class AwsIotThingGroupPropertiesBlock : TerraformBlock
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
    /// AttributePayload block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttributePayload block(s) allowed")]
    public TerraformList<AwsIotThingGroupPropertiesBlockAttributePayloadBlock>? AttributePayload
    {
        get => GetArgument<TerraformList<AwsIotThingGroupPropertiesBlockAttributePayloadBlock>>("attribute_payload");
        set => SetArgument("attribute_payload", value);
    }

}

/// <summary>
/// Block type for attribute_payload in AwsIotThingGroupPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotThingGroupPropertiesBlockAttributePayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attribute_payload";

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformMap<string>? Attributes
    {
        get => GetArgument<TerraformMap<string>>("attributes");
        set => SetArgument("attributes", value);
    }

}


/// <summary>
/// Represents a aws_iot_thing_group Terraform resource.
/// Manages a aws_iot_thing_group resource.
/// </summary>
public partial class AwsIotThingGroup(string name) : TerraformResource("aws_iot_thing_group", name)
{
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
    /// The parent_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ParentGroupName
    {
        get => GetArgument<TerraformValue<string>>("parent_group_name");
        set => SetArgument("parent_group_name", value);
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
    /// The metadata attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Metadata
        => AsReference("metadata");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
        => AsReference("version");

    /// <summary>
    /// Properties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public TerraformList<AwsIotThingGroupPropertiesBlock>? Properties
    {
        get => GetArgument<TerraformList<AwsIotThingGroupPropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

}
