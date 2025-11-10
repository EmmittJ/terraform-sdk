using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_workload_identity resource.
/// </summary>
public class AwsBedrockagentcoreWorkloadIdentity : TerraformResource
{
    public AwsBedrockagentcoreWorkloadIdentity(string name) : base("aws_bedrockagentcore_workload_identity", name)
    {
    }

    /// <summary>
    /// The allowed_resource_oauth2_return_urls attribute.
    /// </summary>
    [TerraformPropertyName("allowed_resource_oauth2_return_urls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowedResourceOauth2ReturnUrls { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The workload_identity_arn attribute.
    /// </summary>
    [TerraformPropertyName("workload_identity_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkloadIdentityArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workload_identity_arn");

}
