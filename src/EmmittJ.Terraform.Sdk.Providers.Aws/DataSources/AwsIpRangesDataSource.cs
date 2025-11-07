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
        this.DeclareOutput("cidr_blocks");
        this.DeclareOutput("create_date");
        this.DeclareOutput("ipv6_cidr_blocks");
        this.DeclareOutput("sync_token");
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
    /// The regions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Regions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("regions");
        set => this.WithProperty("regions", value);
    }

    /// <summary>
    /// The services attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Services
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("services");
        set => this.WithProperty("services", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Url
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url");
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
