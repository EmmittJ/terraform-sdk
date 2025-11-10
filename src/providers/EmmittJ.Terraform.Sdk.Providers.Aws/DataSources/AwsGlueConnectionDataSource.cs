using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_connection.
/// </summary>
public class AwsGlueConnectionDataSource : TerraformDataSource
{
    public AwsGlueConnectionDataSource(string name) : base("aws_glue_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("athena_properties");
        this.WithOutput("catalog_id");
        this.WithOutput("connection_properties");
        this.WithOutput("connection_type");
        this.WithOutput("description");
        this.WithOutput("match_criteria");
        this.WithOutput("name");
        this.WithOutput("physical_connection_requirements");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The athena_properties attribute.
    /// </summary>
    public TerraformExpression AthenaProperties => this["athena_properties"];

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformExpression CatalogId => this["catalog_id"];

    /// <summary>
    /// The connection_properties attribute.
    /// </summary>
    public TerraformExpression ConnectionProperties => this["connection_properties"];

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformExpression ConnectionType => this["connection_type"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The match_criteria attribute.
    /// </summary>
    public TerraformExpression MatchCriteria => this["match_criteria"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The physical_connection_requirements attribute.
    /// </summary>
    public TerraformExpression PhysicalConnectionRequirements => this["physical_connection_requirements"];

}
