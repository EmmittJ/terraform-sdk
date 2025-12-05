using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for properties in AwsIotBillingGroup.
/// Nesting mode: list
/// </summary>
public class AwsIotBillingGroupPropertiesBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_iot_billing_group Terraform resource.
/// Manages a aws_iot_billing_group resource.
/// </summary>
public partial class AwsIotBillingGroup(string name) : TerraformResource("aws_iot_billing_group", name)
{
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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Metadata
        => CreateReference("metadata");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
        => CreateReference("version");

    /// <summary>
    /// Properties block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsIotBillingGroupPropertiesBlock>? Properties
    {
        get => GetArgument<TerraformList<AwsIotBillingGroupPropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

}
