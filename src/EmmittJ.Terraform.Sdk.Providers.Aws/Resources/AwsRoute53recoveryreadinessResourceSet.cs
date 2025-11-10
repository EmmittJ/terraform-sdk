using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resources in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53recoveryreadinessResourceSetResourcesBlock : TerraformBlock
{
    /// <summary>
    /// The component_id attribute.
    /// </summary>
    public TerraformProperty<string>? ComponentId
    {
        get => GetProperty<TerraformProperty<string>>("component_id");
        set => WithProperty("component_id", value);
    }

    /// <summary>
    /// The readiness_scopes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ReadinessScopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("readiness_scopes");
        set => WithProperty("readiness_scopes", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceArn
    {
        get => GetProperty<TerraformProperty<string>>("resource_arn");
        set => WithProperty("resource_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53recoveryreadinessResourceSetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_route53recoveryreadiness_resource_set resource.
/// </summary>
public class AwsRoute53recoveryreadinessResourceSet : TerraformResource
{
    public AwsRoute53recoveryreadinessResourceSet(string name) : base("aws_route53recoveryreadiness_resource_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetName is required")]
    public required TerraformProperty<string> ResourceSetName
    {
        get => GetProperty<TerraformProperty<string>>("resource_set_name");
        set => this.WithProperty("resource_set_name", value);
    }

    /// <summary>
    /// The resource_set_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetType is required")]
    public required TerraformProperty<string> ResourceSetType
    {
        get => GetProperty<TerraformProperty<string>>("resource_set_type");
        set => this.WithProperty("resource_set_type", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Resources block(s) required")]
    public List<AwsRoute53recoveryreadinessResourceSetResourcesBlock>? Resources
    {
        get => GetProperty<List<AwsRoute53recoveryreadinessResourceSetResourcesBlock>>("resources");
        set => this.WithProperty("resources", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53recoveryreadinessResourceSetTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53recoveryreadinessResourceSetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
