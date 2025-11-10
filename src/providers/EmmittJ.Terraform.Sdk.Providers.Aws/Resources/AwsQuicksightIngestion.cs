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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("ingestion_status");
        SetOutput("aws_account_id");
        SetOutput("data_set_id");
        SetOutput("ingestion_id");
        SetOutput("ingestion_type");
        SetOutput("region");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformProperty<string> DataSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_set_id");
        set => SetProperty("data_set_id", value);
    }

    /// <summary>
    /// The ingestion_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionId is required")]
    public required TerraformProperty<string> IngestionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ingestion_id");
        set => SetProperty("ingestion_id", value);
    }

    /// <summary>
    /// The ingestion_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionType is required")]
    public required TerraformProperty<string> IngestionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ingestion_type");
        set => SetProperty("ingestion_type", value);
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
