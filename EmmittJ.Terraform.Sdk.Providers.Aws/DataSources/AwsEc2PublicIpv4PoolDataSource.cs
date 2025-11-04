using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_public_ipv4_pool.
/// </summary>
public class AwsEc2PublicIpv4PoolDataSource : TerraformDataSource
{
    public AwsEc2PublicIpv4PoolDataSource(string name) : base("aws_ec2_public_ipv4_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("network_border_group");
        this.DeclareOutput("pool_address_ranges");
        this.DeclareOutput("total_address_count");
        this.DeclareOutput("total_available_address_count");
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
    /// The pool_id attribute.
    /// </summary>
    public string? PoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pool_id")?.Value;
        set => this.WithProperty("pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    public TerraformExpression NetworkBorderGroup => this["network_border_group"];

    /// <summary>
    /// The pool_address_ranges attribute.
    /// </summary>
    public TerraformExpression PoolAddressRanges => this["pool_address_ranges"];

    /// <summary>
    /// The total_address_count attribute.
    /// </summary>
    public TerraformExpression TotalAddressCount => this["total_address_count"];

    /// <summary>
    /// The total_available_address_count attribute.
    /// </summary>
    public TerraformExpression TotalAvailableAddressCount => this["total_available_address_count"];

}
