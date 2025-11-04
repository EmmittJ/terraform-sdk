using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_nat_gateway resource.
/// </summary>
public class AwsNatGateway : TerraformResource
{
    public AwsNatGateway(string name) : base("aws_nat_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("association_id");
        this.DeclareOutput("network_interface_id");
        this.DeclareOutput("public_ip");
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public string? AllocationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("allocation_id")?.Value;
        set => this.WithProperty("allocation_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    public string? ConnectivityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connectivity_type")?.Value;
        set => this.WithProperty("connectivity_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The private_ip attribute.
    /// </summary>
    public string? PrivateIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_ip")?.Value;
        set => this.WithProperty("private_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secondary_allocation_ids attribute.
    /// </summary>
    public HashSet<string>? SecondaryAllocationIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("secondary_allocation_ids")?.Value;
        set => this.WithProperty("secondary_allocation_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    public double? SecondaryPrivateIpAddressCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("secondary_private_ip_address_count")?.Value;
        set => this.WithProperty("secondary_private_ip_address_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    public HashSet<string>? SecondaryPrivateIpAddresses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("secondary_private_ip_addresses")?.Value;
        set => this.WithProperty("secondary_private_ip_addresses", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceId => this["network_interface_id"];

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformExpression PublicIp => this["public_ip"];

}
