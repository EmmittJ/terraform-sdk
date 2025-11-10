using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_pool_cidr_allocation resource.
/// </summary>
public class AwsVpcIpamPoolCidrAllocation : TerraformResource
{
    public AwsVpcIpamPoolCidrAllocation(string name) : base("aws_vpc_ipam_pool_cidr_allocation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("ipam_pool_allocation_id");
        SetOutput("resource_id");
        SetOutput("resource_owner");
        SetOutput("resource_type");
        SetOutput("cidr");
        SetOutput("description");
        SetOutput("disallowed_cidrs");
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
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The ipam_pool_allocation_id attribute.
    /// </summary>
    public TerraformExpression IpamPoolAllocationId => this["ipam_pool_allocation_id"];

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    public TerraformExpression ResourceOwner => this["resource_owner"];

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

}
