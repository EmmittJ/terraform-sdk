using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_partition resource.
/// </summary>
public class AwsGluePartition : TerraformResource
{
    public AwsGluePartition(string name) : base("aws_glue_partition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_time");
        this.DeclareOutput("last_accessed_time");
        this.DeclareOutput("last_analyzed_time");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public string? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id")?.Value;
        set => this.WithProperty("catalog_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The partition_values attribute.
    /// </summary>
    public List<string>? PartitionValues
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("partition_values")?.Value;
        set => this.WithProperty("partition_values", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public string? TableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_name")?.Value;
        set => this.WithProperty("table_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The last_accessed_time attribute.
    /// </summary>
    public TerraformExpression LastAccessedTime => this["last_accessed_time"];

    /// <summary>
    /// The last_analyzed_time attribute.
    /// </summary>
    public TerraformExpression LastAnalyzedTime => this["last_analyzed_time"];

}
