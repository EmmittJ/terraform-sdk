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
        set => SetProperty("message", value);
    }

    /// <summary>
    /// The signature attribute.
    /// </summary>
    public TerraformProperty<string>? Signature
    {
        set => SetProperty("signature", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("ipam_pool_cidr_id");
        SetOutput("cidr");
        SetOutput("id");
        SetOutput("ipam_pool_id");
        SetOutput("netmask_length");
        SetOutput("region");
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public TerraformProperty<string> Cidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cidr");
        set => SetProperty("cidr", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    public required TerraformProperty<string> IpamPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipam_pool_id");
        set => SetProperty("ipam_pool_id", value);
    }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    public TerraformProperty<double> NetmaskLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("netmask_length");
        set => SetProperty("netmask_length", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for cidr_authorization_context.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrAuthorizationContext block(s) allowed")]
    public List<AwsVpcIpamPoolCidrCidrAuthorizationContextBlock>? CidrAuthorizationContext
    {
        set => SetProperty("cidr_authorization_context", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcIpamPoolCidrTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The ipam_pool_cidr_id attribute.
    /// </summary>
    public TerraformExpression IpamPoolCidrId => this["ipam_pool_cidr_id"];

}
