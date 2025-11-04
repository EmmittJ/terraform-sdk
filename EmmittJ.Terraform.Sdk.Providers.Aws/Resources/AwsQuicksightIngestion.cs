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
    public string? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id")?.Value;
        set => this.WithProperty("aws_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    public string? DataSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_set_id")?.Value;
        set => this.WithProperty("data_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ingestion_id attribute.
    /// </summary>
    public string? IngestionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ingestion_id")?.Value;
        set => this.WithProperty("ingestion_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ingestion_type attribute.
    /// </summary>
    public string? IngestionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ingestion_type")?.Value;
        set => this.WithProperty("ingestion_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
