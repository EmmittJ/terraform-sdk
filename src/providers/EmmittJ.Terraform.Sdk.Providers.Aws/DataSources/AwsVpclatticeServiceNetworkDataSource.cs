using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpclattice_service_network.
/// </summary>
public class AwsVpclatticeServiceNetworkDataSource : TerraformDataSource
{
    public AwsVpclatticeServiceNetworkDataSource(string name) : base("aws_vpclattice_service_network", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The service_network_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNetworkIdentifier is required")]
    [TerraformPropertyName("service_network_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceNetworkIdentifier { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [TerraformPropertyName("auth_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AuthType => new TerraformReference(this, "auth_type");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedAt => new TerraformReference(this, "last_updated_at");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The number_of_associated_services attribute.
    /// </summary>
    [TerraformPropertyName("number_of_associated_services")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumberOfAssociatedServices => new TerraformReference(this, "number_of_associated_services");

    /// <summary>
    /// The number_of_associated_vpcs attribute.
    /// </summary>
    [TerraformPropertyName("number_of_associated_vpcs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumberOfAssociatedVpcs => new TerraformReference(this, "number_of_associated_vpcs");

}
