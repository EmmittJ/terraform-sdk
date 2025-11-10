using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudformation in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruResourceCollectionCloudformationBlock : TerraformBlock
{
    /// <summary>
    /// The stack_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackNames is required")]
    public List<TerraformProperty<string>>? StackNames
    {
        set => SetProperty("stack_names", value);
    }

}

/// <summary>
/// Block type for tags in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruResourceCollectionTagsBlock : TerraformBlock
{
    /// <summary>
    /// The app_boundary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBoundaryKey is required")]
    public required TerraformProperty<string> AppBoundaryKey
    {
        set => SetProperty("app_boundary_key", value);
    }

    /// <summary>
    /// The tag_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValues is required")]
    public List<TerraformProperty<string>>? TagValues
    {
        set => SetProperty("tag_values", value);
    }

}

/// <summary>
/// Manages a aws_devopsguru_resource_collection resource.
/// </summary>
public class AwsDevopsguruResourceCollection : TerraformResource
{
    public AwsDevopsguruResourceCollection(string name) : base("aws_devopsguru_resource_collection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("region");
        SetOutput("type");
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for cloudformation.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruResourceCollectionCloudformationBlock>? Cloudformation
    {
        set => SetProperty("cloudformation", value);
    }

    /// <summary>
    /// Block for tags.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruResourceCollectionTagsBlock>? Tags
    {
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
