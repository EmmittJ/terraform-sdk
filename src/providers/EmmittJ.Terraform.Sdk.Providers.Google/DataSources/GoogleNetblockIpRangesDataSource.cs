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
        SetOutput("cidr_blocks");
        SetOutput("cidr_blocks_ipv4");
        SetOutput("cidr_blocks_ipv6");
        SetOutput("id");
        SetOutput("range_type");
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
    /// The range_type attribute.
    /// </summary>
    public TerraformProperty<string> RangeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("range_type");
        set => SetProperty("range_type", value);
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
