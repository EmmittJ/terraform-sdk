using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eip.
/// </summary>
public class AwsEipDataSource : TerraformDataSource
{
    public AwsEipDataSource(string name) : base("aws_eip", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("association_id");
        this.DeclareOutput("carrier_ip");
        this.DeclareOutput("customer_owned_ip");
        this.DeclareOutput("customer_owned_ipv4_pool");
        this.DeclareOutput("domain");
        this.DeclareOutput("instance_id");
        this.DeclareOutput("ipam_pool_id");
        this.DeclareOutput("network_interface_id");
        this.DeclareOutput("network_interface_owner_id");
        this.DeclareOutput("private_dns");
        this.DeclareOutput("private_ip");
        this.DeclareOutput("ptr_record");
        this.DeclareOutput("public_dns");
        this.DeclareOutput("public_ipv4_pool");
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
    /// The public_ip attribute.
    /// </summary>
    public string? PublicIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip")?.Value;
        set => this.WithProperty("public_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    public TerraformExpression CarrierIp => this["carrier_ip"];

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    public TerraformExpression CustomerOwnedIp => this["customer_owned_ip"];

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformExpression CustomerOwnedIpv4Pool => this["customer_owned_ipv4_pool"];

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformExpression InstanceId => this["instance_id"];

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformExpression IpamPoolId => this["ipam_pool_id"];

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceId => this["network_interface_id"];

    /// <summary>
    /// The network_interface_owner_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceOwnerId => this["network_interface_owner_id"];

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformExpression PrivateDns => this["private_dns"];

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformExpression PrivateIp => this["private_ip"];

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    public TerraformExpression PtrRecord => this["ptr_record"];

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformExpression PublicDns => this["public_dns"];

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    public TerraformExpression PublicIpv4Pool => this["public_ipv4_pool"];

}
