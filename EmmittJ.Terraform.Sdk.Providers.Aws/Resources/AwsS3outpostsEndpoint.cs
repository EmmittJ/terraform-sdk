using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3outposts_endpoint resource.
/// </summary>
public class AwsS3outpostsEndpoint : TerraformResource
{
    public AwsS3outpostsEndpoint(string name) : base("aws_s3outposts_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cidr_block");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("network_interfaces");
    }

    /// <summary>
    /// The access_type attribute.
    /// </summary>
    public string? AccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_type")?.Value;
        set => this.WithProperty("access_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public string? CustomerOwnedIpv4Pool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_owned_ipv4_pool")?.Value;
        set => this.WithProperty("customer_owned_ipv4_pool", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The outpost_id attribute.
    /// </summary>
    public string? OutpostId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outpost_id")?.Value;
        set => this.WithProperty("outpost_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public string? SecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_group_id")?.Value;
        set => this.WithProperty("security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformExpression CidrBlock => this["cidr_block"];

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The network_interfaces attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaces => this["network_interfaces"];

}
