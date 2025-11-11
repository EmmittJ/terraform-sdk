using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identity_provider_details in .
/// Nesting mode: list
/// </summary>
public class AwsTransferWebAppIdentityProviderDetailsBlock
{
}

/// <summary>
/// Manages a aws_transfer_web_app resource.
/// </summary>
public class AwsTransferWebApp : TerraformResource
{
    public AwsTransferWebApp(string name) : base("aws_transfer_web_app", name)
    {
    }

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("access_endpoint")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccessEndpoint { get; set; } = default!;

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
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The web_app_endpoint_policy attribute.
    /// </summary>
    [TerraformPropertyName("web_app_endpoint_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WebAppEndpointPolicy { get; set; } = default!;

    /// <summary>
    /// The web_app_units attribute.
    /// </summary>
    [TerraformPropertyName("web_app_units")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<object> WebAppUnits { get; set; } = default!;

    /// <summary>
    /// Block for identity_provider_details.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("identity_provider_details")]
    public TerraformList<TerraformBlock<AwsTransferWebAppIdentityProviderDetailsBlock>>? IdentityProviderDetails { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    [TerraformPropertyName("web_app_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebAppId => new TerraformReference(this, "web_app_id");

}
