using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_preview_next_cidr resource.
/// </summary>
public class AwsVpcIpamPreviewNextCidr : TerraformResource
{
    public AwsVpcIpamPreviewNextCidr(string name) : base("aws_vpc_ipam_preview_next_cidr", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cidr");
        SetOutput("disallowed_cidrs");
        SetOutput("id");
        SetOutput("ipam_pool_id");
        SetOutput("netmask_length");
        SetOutput("region");
    }

    /// <summary>
    /// The disallowed_cidrs attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DisallowedCidrs
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("disallowed_cidrs");
        set => SetProperty("disallowed_cidrs", value);
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
    /// The cidr attribute.
    /// </summary>
    public TerraformExpression Cidr => this["cidr"];

}
