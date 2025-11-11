using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identity_provider_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsTransferWebAppIdentityProviderDetailsBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_transfer_web_app resource.
/// </summary>
public partial class AwsTransferWebApp : TerraformResource
{
    public AwsTransferWebApp(string name) : base("aws_transfer_web_app", name)
    {
    }

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    [TerraformProperty("access_endpoint")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AccessEndpoint { get; set; }

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
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The web_app_endpoint_policy attribute.
    /// </summary>
    [TerraformProperty("web_app_endpoint_policy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> WebAppEndpointPolicy { get; set; }

    /// <summary>
    /// The web_app_units attribute.
    /// </summary>
    [TerraformProperty("web_app_units")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<object> WebAppUnits { get; set; }

    /// <summary>
    /// Block for identity_provider_details.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("identity_provider_details")]
    public TerraformList<TerraformBlock<AwsTransferWebAppIdentityProviderDetailsBlock>>? IdentityProviderDetails { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    [TerraformProperty("web_app_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WebAppId { get; }

}
