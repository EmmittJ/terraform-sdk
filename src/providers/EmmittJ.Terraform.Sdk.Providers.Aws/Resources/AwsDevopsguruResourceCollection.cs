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
        get => GetProperty<List<TerraformProperty<string>>>("stack_names");
        set => WithProperty("stack_names", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("app_boundary_key");
        set => WithProperty("app_boundary_key", value);
    }

    /// <summary>
    /// The tag_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValues is required")]
    public List<TerraformProperty<string>>? TagValues
    {
        get => GetProperty<List<TerraformProperty<string>>>("tag_values");
        set => WithProperty("tag_values", value);
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
        this.DeclareOutput("id");
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for cloudformation.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruResourceCollectionCloudformationBlock>? Cloudformation
    {
        get => GetProperty<List<AwsDevopsguruResourceCollectionCloudformationBlock>>("cloudformation");
        set => this.WithProperty("cloudformation", value);
    }

    /// <summary>
    /// Block for tags.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruResourceCollectionTagsBlock>? Tags
    {
        get => GetProperty<List<AwsDevopsguruResourceCollectionTagsBlock>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
