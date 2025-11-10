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
        set => SetProperty("component_id", value);
    }

    /// <summary>
    /// The readiness_scopes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ReadinessScopes
    {
        set => SetProperty("readiness_scopes", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceArn
    {
        set => SetProperty("resource_arn", value);
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
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_route53recoveryreadiness_resource_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRoute53recoveryreadinessResourceSet : TerraformResource
{
    public AwsRoute53recoveryreadinessResourceSet(string name) : base("aws_route53recoveryreadiness_resource_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("resource_set_name");
        SetOutput("resource_set_type");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The resource_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetName is required")]
    public required TerraformProperty<string> ResourceSetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_set_name");
        set => SetProperty("resource_set_name", value);
    }

    /// <summary>
    /// The resource_set_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetType is required")]
    public required TerraformProperty<string> ResourceSetType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_set_type");
        set => SetProperty("resource_set_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Resources block(s) required")]
    public List<AwsRoute53recoveryreadinessResourceSetResourcesBlock>? Resources
    {
        set => SetProperty("resources", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53recoveryreadinessResourceSetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
