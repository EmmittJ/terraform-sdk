using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codestarconnections_connection resource.
/// </summary>
public partial class AwsCodestarconnectionsConnection : TerraformResource
{
    public AwsCodestarconnectionsConnection(string name) : base("aws_codestarconnections_connection", name)
    {
    }

    /// <summary>
    /// The host_arn attribute.
    /// </summary>
    [TerraformProperty("host_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [TerraformProperty("provider_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProviderType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    [TerraformProperty("connection_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectionStatus { get; }

}
