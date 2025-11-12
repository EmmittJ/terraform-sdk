using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ingress_vpc_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApprunnerVpcIngressConnectionIngressVpcConfigurationBlock() : TerraformBlock("ingress_vpc_configuration")
{
    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcEndpointId { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcId { get; set; }

}

/// <summary>
/// Manages a aws_apprunner_vpc_ingress_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApprunnerVpcIngressConnection : TerraformResource
{
    public AwsApprunnerVpcIngressConnection(string name) : base("aws_apprunner_vpc_ingress_connection", name)
    {
    }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceArn is required")]
    [TerraformProperty("service_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceArn { get; set; }

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
    /// Block for ingress_vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngressVpcConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IngressVpcConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressVpcConfiguration block(s) allowed")]
    [TerraformProperty("ingress_vpc_configuration")]
    public required TerraformList<AwsApprunnerVpcIngressConnectionIngressVpcConfigurationBlock> IngressVpcConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainName { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
