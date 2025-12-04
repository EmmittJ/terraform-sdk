using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ip_ranges Terraform data source.
/// Retrieves information about a aws_ip_ranges.
/// </summary>
public partial class AwsIpRangesDataSource(string name) : TerraformDataSource("aws_ip_ranges", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string>? Regions
    {
        get => GetArgument<TerraformSet<string>>("regions");
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The services attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Services is required")]
    public required TerraformSet<string> Services
    {
        get => GetRequiredArgument<TerraformSet<string>>("services");
        set => SetArgument("services", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> CidrBlocks
        => AsReference("cidr_blocks");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
        => AsReference("create_date");

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> Ipv6CidrBlocks
        => AsReference("ipv6_cidr_blocks");

    /// <summary>
    /// The sync_token attribute.
    /// </summary>
    public TerraformValue<double> SyncToken
        => AsReference("sync_token");

}
