using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_ingestion resource.
/// </summary>
public partial class AwsQuicksightIngestion : TerraformResource
{
    public AwsQuicksightIngestion(string name) : base("aws_quicksight_ingestion", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    [TerraformProperty("data_set_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataSetId { get; set; }

    /// <summary>
    /// The ingestion_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionId is required")]
    [TerraformProperty("ingestion_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IngestionId { get; set; }

    /// <summary>
    /// The ingestion_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionType is required")]
    [TerraformProperty("ingestion_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IngestionType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The ingestion_status attribute.
    /// </summary>
    [TerraformProperty("ingestion_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IngestionStatus { get; }

}
