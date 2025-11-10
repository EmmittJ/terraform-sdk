using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eip_association resource.
/// </summary>
public class AwsEipAssociation : TerraformResource
{
    public AwsEipAssociation(string name) : base("aws_eip_association", name)
    {
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformPropertyName("allocation_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AllocationId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "allocation_id");

    /// <summary>
    /// The allow_reassociation attribute.
    /// </summary>
    [TerraformPropertyName("allow_reassociation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowReassociation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_id");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkInterfaceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_interface_id");

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ip_address");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformPropertyName("public_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PublicIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ip");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

}
