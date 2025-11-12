using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for accepter in .
/// Nesting mode: list
/// </summary>
public partial class AwsVpcPeeringConnectionOptionsAccepterBlock() : TerraformBlock("accepter")
{
    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    [TerraformProperty("allow_remote_vpc_dns_resolution")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowRemoteVpcDnsResolution { get; set; }

}

/// <summary>
/// Block type for requester in .
/// Nesting mode: list
/// </summary>
public partial class AwsVpcPeeringConnectionOptionsRequesterBlock() : TerraformBlock("requester")
{
    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    [TerraformProperty("allow_remote_vpc_dns_resolution")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowRemoteVpcDnsResolution { get; set; }

}

/// <summary>
/// Manages a aws_vpc_peering_connection_options resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsVpcPeeringConnectionOptions : TerraformResource
{
    public AwsVpcPeeringConnectionOptions(string name) : base("aws_vpc_peering_connection_options", name)
    {
    }

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
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcPeeringConnectionId is required")]
    [TerraformProperty("vpc_peering_connection_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpcPeeringConnectionId { get; set; }

    /// <summary>
    /// Block for accepter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Accepter block(s) allowed")]
    [TerraformProperty("accepter")]
    public TerraformList<AwsVpcPeeringConnectionOptionsAccepterBlock> Accepter { get; set; } = new();

    /// <summary>
    /// Block for requester.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requester block(s) allowed")]
    [TerraformProperty("requester")]
    public TerraformList<AwsVpcPeeringConnectionOptionsRequesterBlock> Requester { get; set; } = new();

}
