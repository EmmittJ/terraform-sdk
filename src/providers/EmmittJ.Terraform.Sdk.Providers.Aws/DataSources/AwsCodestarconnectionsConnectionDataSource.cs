using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codestarconnections_connection.
/// </summary>
public partial class AwsCodestarconnectionsConnectionDataSource : TerraformDataSource
{
    public AwsCodestarconnectionsConnectionDataSource(string name) : base("aws_codestarconnections_connection", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    [TerraformProperty("connection_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConnectionStatus { get; }

    /// <summary>
    /// The host_arn attribute.
    /// </summary>
    [TerraformProperty("host_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostArn { get; }

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [TerraformProperty("provider_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProviderType { get; }

}
