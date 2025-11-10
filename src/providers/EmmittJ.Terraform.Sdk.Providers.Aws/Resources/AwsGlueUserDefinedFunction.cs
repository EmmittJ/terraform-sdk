using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_uris in .
/// Nesting mode: set
/// </summary>
public class AwsGlueUserDefinedFunctionResourceUrisBlock : TerraformBlock
{
    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_type");
        set => WithProperty("resource_type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

}

/// <summary>
/// Manages a aws_glue_user_defined_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueUserDefinedFunction : TerraformResource
{
    public AwsGlueUserDefinedFunction(string name) : base("aws_glue_user_defined_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("create_time");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The class_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassName is required")]
    public required TerraformProperty<string> ClassName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("class_name");
        set => this.WithProperty("class_name", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The owner_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerName is required")]
    public required TerraformProperty<string> OwnerName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("owner_name");
        set => this.WithProperty("owner_name", value);
    }

    /// <summary>
    /// The owner_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerType is required")]
    public required TerraformProperty<string> OwnerType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("owner_type");
        set => this.WithProperty("owner_type", value);
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
    /// Block for resource_uris.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 ResourceUris block(s) allowed")]
    public HashSet<AwsGlueUserDefinedFunctionResourceUrisBlock>? ResourceUris
    {
        get => GetProperty<HashSet<AwsGlueUserDefinedFunctionResourceUrisBlock>>("resource_uris");
        set => this.WithProperty("resource_uris", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

}
