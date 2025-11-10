using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_detail in .
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderLifecyclePolicyPolicyDetailBlock : TerraformBlock
{
}

/// <summary>
/// Block type for resource_selection in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderLifecyclePolicyResourceSelectionBlock : TerraformBlock
{
    /// <summary>
    /// The tag_map attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagMap
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tag_map");
        set => WithProperty("tag_map", value);
    }

}

/// <summary>
/// Manages a aws_imagebuilder_lifecycle_policy resource.
/// </summary>
public class AwsImagebuilderLifecyclePolicy : TerraformResource
{
    public AwsImagebuilderLifecyclePolicy(string name) : base("aws_imagebuilder_lifecycle_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
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
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    public required TerraformProperty<string> ExecutionRole
    {
        get => GetProperty<TerraformProperty<string>>("execution_role");
        set => this.WithProperty("execution_role", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for policy_detail.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsImagebuilderLifecyclePolicyPolicyDetailBlock>? PolicyDetail
    {
        get => GetProperty<HashSet<AwsImagebuilderLifecyclePolicyPolicyDetailBlock>>("policy_detail");
        set => this.WithProperty("policy_detail", value);
    }

    /// <summary>
    /// Block for resource_selection.
    /// Nesting mode: list
    /// </summary>
    public List<AwsImagebuilderLifecyclePolicyResourceSelectionBlock>? ResourceSelection
    {
        get => GetProperty<List<AwsImagebuilderLifecyclePolicyResourceSelectionBlock>>("resource_selection");
        set => this.WithProperty("resource_selection", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
