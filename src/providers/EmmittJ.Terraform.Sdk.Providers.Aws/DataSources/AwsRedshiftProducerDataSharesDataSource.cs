using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_producer_data_shares Terraform data source.
/// Retrieves information about a aws_redshift_producer_data_shares.
/// </summary>
public partial class AwsRedshiftProducerDataSharesDataSource(string name) : TerraformDataSource("aws_redshift_producer_data_shares", name)
{
    /// <summary>
    /// The producer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProducerArn is required")]
    public required TerraformValue<string> ProducerArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("producer_arn");
        set => SetArgument("producer_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The data_shares attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataShares
        => CreateReference("data_shares");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

}
