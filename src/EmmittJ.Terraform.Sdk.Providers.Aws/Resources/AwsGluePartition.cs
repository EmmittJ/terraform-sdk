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
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMapProperty<string>? Parameters
    {
        get => GetProperty<TerraformMapProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The partition_values attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PartitionValues
    {
        get => GetProperty<TerraformProperty<List<string>>>("partition_values");
        set => this.WithProperty("partition_values", value);
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
    /// The table_name attribute.
    /// </summary>
    public TerraformProperty<string>? TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
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
