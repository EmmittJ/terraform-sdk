using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudformation in AwsDevopsguruResourceCollection.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruResourceCollectionCloudformationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudformation";

    /// <summary>
    /// The stack_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackNames is required")]
    public TerraformList<string>? StackNames
    {
        get => GetArgument<TerraformList<string>>("stack_names");
        set => SetArgument("stack_names", value);
    }

}


/// <summary>
/// Block type for tags in AwsDevopsguruResourceCollection.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruResourceCollectionTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The app_boundary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBoundaryKey is required")]
    public required TerraformValue<string> AppBoundaryKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_boundary_key");
        set => SetArgument("app_boundary_key", value);
    }

    /// <summary>
    /// The tag_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValues is required")]
    public TerraformList<string>? TagValues
    {
        get => GetArgument<TerraformList<string>>("tag_values");
        set => SetArgument("tag_values", value);
    }

}


/// <summary>
/// Represents a aws_devopsguru_resource_collection Terraform resource.
/// Manages a aws_devopsguru_resource_collection resource.
/// </summary>
public partial class AwsDevopsguruResourceCollection(string name) : TerraformResource("aws_devopsguru_resource_collection", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// Cloudformation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruResourceCollectionCloudformationBlock>? Cloudformation
    {
        get => GetArgument<TerraformList<AwsDevopsguruResourceCollectionCloudformationBlock>>("cloudformation");
        set => SetArgument("cloudformation", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruResourceCollectionTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsDevopsguruResourceCollectionTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}
