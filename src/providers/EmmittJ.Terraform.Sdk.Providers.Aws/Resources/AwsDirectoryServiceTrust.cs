using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_directory_service_trust resource.
/// </summary>
public partial class AwsDirectoryServiceTrust : TerraformResource
{
    public AwsDirectoryServiceTrust(string name) : base("aws_directory_service_trust", name)
    {
    }

    /// <summary>
    /// The conditional_forwarder_ip_addrs attribute.
    /// </summary>
    [TerraformProperty("conditional_forwarder_ip_addrs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ConditionalForwarderIpAddrs { get; set; }

    /// <summary>
    /// The delete_associated_conditional_forwarder attribute.
    /// </summary>
    [TerraformProperty("delete_associated_conditional_forwarder")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DeleteAssociatedConditionalForwarder { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformProperty("directory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DirectoryId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The remote_domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteDomainName is required")]
    [TerraformProperty("remote_domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RemoteDomainName { get; set; }

    /// <summary>
    /// The selective_auth attribute.
    /// </summary>
    [TerraformProperty("selective_auth")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SelectiveAuth { get; set; }

    /// <summary>
    /// The trust_direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustDirection is required")]
    [TerraformProperty("trust_direction")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TrustDirection { get; set; }

    /// <summary>
    /// The trust_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustPassword is required")]
    [TerraformProperty("trust_password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TrustPassword { get; set; }

    /// <summary>
    /// The trust_type attribute.
    /// </summary>
    [TerraformProperty("trust_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TrustType { get; set; }

    /// <summary>
    /// The created_date_time attribute.
    /// </summary>
    [TerraformProperty("created_date_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedDateTime { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The last_updated_date_time attribute.
    /// </summary>
    [TerraformProperty("last_updated_date_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdatedDateTime { get; }

    /// <summary>
    /// The state_last_updated_date_time attribute.
    /// </summary>
    [TerraformProperty("state_last_updated_date_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateLastUpdatedDateTime { get; }

    /// <summary>
    /// The trust_state attribute.
    /// </summary>
    [TerraformProperty("trust_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TrustState { get; }

    /// <summary>
    /// The trust_state_reason attribute.
    /// </summary>
    [TerraformProperty("trust_state_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TrustStateReason { get; }

}
