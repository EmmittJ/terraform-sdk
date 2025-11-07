using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_ingestion resource.
/// </summary>
public class AwsQuicksightIngestion : TerraformResource
{
    public AwsQuicksightIngestion(string name) : base("aws_quicksight_ingestion", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("ingestion_status");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataSetId
    {
        get => GetProperty<TerraformProperty<string>>("data_set_id");
        set => this.WithProperty("data_set_id", value);
    }

    /// <summary>
    /// The ingestion_id attribute.
    /// </summary>
    public TerraformProperty<string>? IngestionId
    {
        get => GetProperty<TerraformProperty<string>>("ingestion_id");
        set => this.WithProperty("ingestion_id", value);
    }

    /// <summary>
    /// The ingestion_type attribute.
    /// </summary>
    public TerraformProperty<string>? IngestionType
    {
        get => GetProperty<TerraformProperty<string>>("ingestion_type");
        set => this.WithProperty("ingestion_type", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The ingestion_status attribute.
    /// </summary>
    public TerraformExpression IngestionStatus => this["ingestion_status"];

}
