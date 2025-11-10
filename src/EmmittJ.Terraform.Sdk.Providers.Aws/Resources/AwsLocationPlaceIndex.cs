using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsLocationPlaceIndexDataSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The intended_use attribute.
    /// </summary>
    public TerraformProperty<string>? IntendedUse
    {
        get => GetProperty<TerraformProperty<string>>("intended_use");
        set => WithProperty("intended_use", value);
    }

}

/// <summary>
/// Manages a aws_location_place_index resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLocationPlaceIndex : TerraformResource
{
    public AwsLocationPlaceIndex(string name) : base("aws_location_place_index", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("index_arn");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSource is required")]
    public required TerraformProperty<string> DataSource
    {
        get => GetProperty<TerraformProperty<string>>("data_source");
        set => this.WithProperty("data_source", value);
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
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformProperty<string> IndexName
    {
        get => GetProperty<TerraformProperty<string>>("index_name");
        set => this.WithProperty("index_name", value);
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
    /// Block for data_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSourceConfiguration block(s) allowed")]
    public List<AwsLocationPlaceIndexDataSourceConfigurationBlock>? DataSourceConfiguration
    {
        get => GetProperty<List<AwsLocationPlaceIndexDataSourceConfigurationBlock>>("data_source_configuration");
        set => this.WithProperty("data_source_configuration", value);
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The index_arn attribute.
    /// </summary>
    public TerraformExpression IndexArn => this["index_arn"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
