using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_detective_invitation_accepter resource.
/// </summary>
public partial class AwsDetectiveInvitationAccepter : TerraformResource
{
    public AwsDetectiveInvitationAccepter(string name) : base("aws_detective_invitation_accepter", name)
    {
    }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GraphArn is required")]
    [TerraformProperty("graph_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GraphArn { get; set; }

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

}
