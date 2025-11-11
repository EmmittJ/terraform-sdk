using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codestarconnections_connection.
/// </summary>
public class AwsCodestarconnectionsConnectionDataSource : TerraformDataSource
{
    public AwsCodestarconnectionsConnectionDataSource(string name) : base("aws_codestarconnections_connection", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    [TerraformPropertyName("connection_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectionStatus => new TerraformReference(this, "connection_status");

    /// <summary>
    /// The host_arn attribute.
    /// </summary>
    [TerraformPropertyName("host_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostArn => new TerraformReference(this, "host_arn");

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [TerraformPropertyName("provider_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProviderType => new TerraformReference(this, "provider_type");

}
