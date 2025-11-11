using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshift_data_shares.
/// </summary>
public class AwsRedshiftDataSharesDataSource : TerraformDataSource
{
    public AwsRedshiftDataSharesDataSource(string name) : base("aws_redshift_data_shares", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The data_shares attribute.
    /// </summary>
    [TerraformPropertyName("data_shares")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataShares => new TerraformReference(this, "data_shares");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
