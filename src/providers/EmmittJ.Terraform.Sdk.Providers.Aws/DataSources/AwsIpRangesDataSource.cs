using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ip_ranges.
/// </summary>
public class AwsIpRangesDataSource : TerraformDataSource
{
    public AwsIpRangesDataSource(string name) : base("aws_ip_ranges", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("cidr_blocks");
        this.WithOutput("create_date");
        this.WithOutput("ipv6_cidr_blocks");
        this.WithOutput("sync_token");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Regions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("regions");
        set => this.WithProperty("regions", value);
    }

    /// <summary>
    /// The services attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Services is required")]
    public HashSet<TerraformProperty<string>>? Services
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("services");
        set => this.WithProperty("services", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => this.WithProperty("url", value);
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformExpression CidrBlocks => this["cidr_blocks"];

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformExpression CreateDate => this["create_date"];

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    public TerraformExpression Ipv6CidrBlocks => this["ipv6_cidr_blocks"];

    /// <summary>
    /// The sync_token attribute.
    /// </summary>
    public TerraformExpression SyncToken => this["sync_token"];

}
