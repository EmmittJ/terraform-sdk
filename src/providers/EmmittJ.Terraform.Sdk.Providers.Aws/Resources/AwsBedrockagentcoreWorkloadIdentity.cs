using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_workload_identity resource.
/// </summary>
public partial class AwsBedrockagentcoreWorkloadIdentity : TerraformResource
{
    public AwsBedrockagentcoreWorkloadIdentity(string name) : base("aws_bedrockagentcore_workload_identity", name)
    {
    }

    /// <summary>
    /// The allowed_resource_oauth2_return_urls attribute.
    /// </summary>
    [TerraformProperty("allowed_resource_oauth2_return_urls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AllowedResourceOauth2ReturnUrls { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The workload_identity_arn attribute.
    /// </summary>
    [TerraformProperty("workload_identity_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkloadIdentityArn { get; }

}
