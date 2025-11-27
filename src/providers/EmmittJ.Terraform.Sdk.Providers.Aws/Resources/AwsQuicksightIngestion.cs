using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_quicksight_ingestion Terraform resource.
/// Manages a aws_quicksight_ingestion resource.
/// </summary>
public partial class AwsQuicksightIngestion(string name) : TerraformResource("aws_quicksight_ingestion", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformValue<string> DataSetId
    {
        get => new TerraformReference<string>(this, "data_set_id");
        set => SetArgument("data_set_id", value);
    }

    /// <summary>
    /// The ingestion_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionId is required")]
    public required TerraformValue<string> IngestionId
    {
        get => new TerraformReference<string>(this, "ingestion_id");
        set => SetArgument("ingestion_id", value);
    }

    /// <summary>
    /// The ingestion_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionType is required")]
    public required TerraformValue<string> IngestionType
    {
        get => new TerraformReference<string>(this, "ingestion_type");
        set => SetArgument("ingestion_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The ingestion_status attribute.
    /// </summary>
    public TerraformValue<string> IngestionStatus
    {
        get => new TerraformReference<string>(this, "ingestion_status");
    }

}
