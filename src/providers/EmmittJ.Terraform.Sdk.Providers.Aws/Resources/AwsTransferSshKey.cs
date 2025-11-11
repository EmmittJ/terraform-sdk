using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_ssh_key resource.
/// </summary>
public partial class AwsTransferSshKey : TerraformResource
{
    public AwsTransferSshKey(string name) : base("aws_transfer_ssh_key", name)
    {
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Body is required")]
    [TerraformProperty("body")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Body { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformProperty("server_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The ssh_key_id attribute.
    /// </summary>
    [TerraformProperty("ssh_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SshKeyId { get; }

}
