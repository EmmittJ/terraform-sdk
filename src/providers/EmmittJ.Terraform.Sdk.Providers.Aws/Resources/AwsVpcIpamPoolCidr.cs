using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cidr_authorization_context in .
/// Nesting mode: list
/// </summary>
public class AwsVpcIpamPoolCidrCidrAuthorizationContextBlock : TerraformBlock
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    public TerraformProperty<string>? Message
    {
        get => GetProperty<TerraformProperty<string>>("message");
        set => WithProperty("message", value);
    }

    /// <summary>
    /// The signature attribute.
    /// </summary>
    public TerraformProperty<string>? Signature
    {
        get => GetProperty<TerraformProperty<string>>("signature");
        set => WithProperty("signature", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolCidrTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_vpc_ipam_pool_cidr resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVpcIpamPoolCidr : TerraformResource
{
    public AwsVpcIpamPoolCidr(string name) : base("aws_vpc_ipam_pool_cidr", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("ipam_pool_cidr_id");
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public TerraformProperty<string>? Cidr
    {
        get => GetProperty<TerraformProperty<string>>("cidr");
        set => this.WithProperty("cidr", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    public required TerraformProperty<string> IpamPoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ipam_pool_id");
        set => this.WithProperty("ipam_pool_id", value);
    }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    public TerraformProperty<double>? NetmaskLength
    {
        get => GetProperty<TerraformProperty<double>>("netmask_length");
        set => this.WithProperty("netmask_length", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for cidr_authorization_context.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrAuthorizationContext block(s) allowed")]
    public List<AwsVpcIpamPoolCidrCidrAuthorizationContextBlock>? CidrAuthorizationContext
    {
        get => GetProperty<List<AwsVpcIpamPoolCidrCidrAuthorizationContextBlock>>("cidr_authorization_context");
        set => this.WithProperty("cidr_authorization_context", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcIpamPoolCidrTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcIpamPoolCidrTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The ipam_pool_cidr_id attribute.
    /// </summary>
    public TerraformExpression IpamPoolCidrId => this["ipam_pool_cidr_id"];

}
