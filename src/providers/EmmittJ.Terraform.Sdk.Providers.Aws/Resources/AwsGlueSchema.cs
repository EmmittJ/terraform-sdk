using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_schema resource.
/// </summary>
public class AwsGlueSchema : TerraformResource
{
    public AwsGlueSchema(string name) : base("aws_glue_schema", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("latest_schema_version");
        SetOutput("next_schema_version");
        SetOutput("registry_name");
        SetOutput("schema_checkpoint");
        SetOutput("compatibility");
        SetOutput("data_format");
        SetOutput("description");
        SetOutput("id");
        SetOutput("region");
        SetOutput("registry_arn");
        SetOutput("schema_definition");
        SetOutput("schema_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The compatibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compatibility is required")]
    public required TerraformProperty<string> Compatibility
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compatibility");
        set => SetProperty("compatibility", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFormat is required")]
    public required TerraformProperty<string> DataFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_format");
        set => SetProperty("data_format", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    public TerraformProperty<string> RegistryArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("registry_arn");
        set => SetProperty("registry_arn", value);
    }

    /// <summary>
    /// The schema_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaDefinition is required")]
    public required TerraformProperty<string> SchemaDefinition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema_definition");
        set => SetProperty("schema_definition", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaName is required")]
    public required TerraformProperty<string> SchemaName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema_name");
        set => SetProperty("schema_name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The latest_schema_version attribute.
    /// </summary>
    public TerraformExpression LatestSchemaVersion => this["latest_schema_version"];

    /// <summary>
    /// The next_schema_version attribute.
    /// </summary>
    public TerraformExpression NextSchemaVersion => this["next_schema_version"];

    /// <summary>
    /// The registry_name attribute.
    /// </summary>
    public TerraformExpression RegistryName => this["registry_name"];

    /// <summary>
    /// The schema_checkpoint attribute.
    /// </summary>
    public TerraformExpression SchemaCheckpoint => this["schema_checkpoint"];

}
