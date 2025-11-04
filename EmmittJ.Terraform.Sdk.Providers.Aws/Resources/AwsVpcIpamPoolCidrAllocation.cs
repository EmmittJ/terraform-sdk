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
        this.DeclareOutput("ipam_pool_allocation_id");
        this.DeclareOutput("resource_id");
        this.DeclareOutput("resource_owner");
        this.DeclareOutput("resource_type");
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public string? Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr")?.Value;
        set => this.WithProperty("cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disallowed_cidrs attribute.
    /// </summary>
    public HashSet<string>? DisallowedCidrs
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("disallowed_cidrs")?.Value;
        set => this.WithProperty("disallowed_cidrs", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public string? IpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipam_pool_id")?.Value;
        set => this.WithProperty("ipam_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    public double? NetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("netmask_length")?.Value;
        set => this.WithProperty("netmask_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
