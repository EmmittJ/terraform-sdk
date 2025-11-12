using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOpensearchInboundConnectionAccepterTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_opensearch_inbound_connection_accepter resource.
/// </summary>
public partial class AwsOpensearchInboundConnectionAccepter : TerraformResource
{
    public AwsOpensearchInboundConnectionAccepter(string name) : base("aws_opensearch_inbound_connection_accepter", name)
    {
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformProperty("connection_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsOpensearchInboundConnectionAccepterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    [TerraformProperty("connection_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectionStatus { get; }

}
