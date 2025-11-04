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
        this.DeclareOutput("create_time");
        this.DeclareOutput("data_source");
        this.DeclareOutput("data_source_configuration");
        this.DeclareOutput("description");
        this.DeclareOutput("index_arn");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    public string? IndexName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("index_name")?.Value;
        set => this.WithProperty("index_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
