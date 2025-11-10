using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_location_place_index.
/// </summary>
public class AwsLocationPlaceIndexDataSource : TerraformDataSource
{
    public AwsLocationPlaceIndexDataSource(string name) : base("aws_location_place_index", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("data_source");
        this.WithOutput("data_source_configuration");
        this.WithOutput("description");
        this.WithOutput("index_arn");
        this.WithOutput("update_time");
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
        get => GetRequiredProperty<TerraformProperty<string>>("index_name");
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
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    public TerraformExpression DataSource => this["data_source"];

    /// <summary>
    /// The data_source_configuration attribute.
    /// </summary>
    public TerraformExpression DataSourceConfiguration => this["data_source_configuration"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The index_arn attribute.
    /// </summary>
    public TerraformExpression IndexArn => this["index_arn"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
