using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_netblock_ip_ranges.
/// </summary>
public class GoogleNetblockIpRangesDataSource : TerraformDataSource
{
    public GoogleNetblockIpRangesDataSource(string name) : base("google_netblock_ip_ranges", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cidr_blocks");
        this.DeclareOutput("cidr_blocks_ipv4");
        this.DeclareOutput("cidr_blocks_ipv6");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The range_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RangeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("range_type");
        set => this.WithProperty("range_type", value);
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformExpression CidrBlocks => this["cidr_blocks"];

    /// <summary>
    /// The cidr_blocks_ipv4 attribute.
    /// </summary>
    public TerraformExpression CidrBlocksIpv4 => this["cidr_blocks_ipv4"];

    /// <summary>
    /// The cidr_blocks_ipv6 attribute.
    /// </summary>
    public TerraformExpression CidrBlocksIpv6 => this["cidr_blocks_ipv6"];

}
