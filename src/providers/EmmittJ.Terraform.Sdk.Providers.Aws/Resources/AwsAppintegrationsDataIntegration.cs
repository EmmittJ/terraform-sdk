using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for schedule_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppintegrationsDataIntegrationScheduleConfigBlock : TerraformBlock
{
    /// <summary>
    /// The first_execution_from attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstExecutionFrom is required")]
    public required TerraformProperty<string> FirstExecutionFrom
    {
        get => GetRequiredProperty<TerraformProperty<string>>("first_execution_from");
        set => WithProperty("first_execution_from", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Object is required")]
    public required TerraformProperty<string> Object
    {
        get => GetRequiredProperty<TerraformProperty<string>>("object");
        set => WithProperty("object", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformProperty<string> ScheduleExpression
    {
        get => GetRequiredProperty<TerraformProperty<string>>("schedule_expression");
        set => WithProperty("schedule_expression", value);
    }

}

/// <summary>
/// Manages a aws_appintegrations_data_integration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppintegrationsDataIntegration : TerraformResource
{
    public AwsAppintegrationsDataIntegration(string name) : base("aws_appintegrations_data_integration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformProperty<string> KmsKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kms_key");
        set => this.WithProperty("kms_key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The source_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUri is required")]
    public required TerraformProperty<string> SourceUri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_uri");
        set => this.WithProperty("source_uri", value);
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
    /// Block for schedule_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScheduleConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleConfig block(s) allowed")]
    public List<AwsAppintegrationsDataIntegrationScheduleConfigBlock>? ScheduleConfig
    {
        get => GetProperty<List<AwsAppintegrationsDataIntegrationScheduleConfigBlock>>("schedule_config");
        set => this.WithProperty("schedule_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
