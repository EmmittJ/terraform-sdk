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
        SetOutput("cidr_blocks");
        SetOutput("create_date");
        SetOutput("ipv6_cidr_blocks");
        SetOutput("sync_token");
        SetOutput("id");
        SetOutput("regions");
        SetOutput("services");
        SetOutput("url");
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
    /// The regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Regions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("regions");
        set => SetProperty("regions", value);
    }

    /// <summary>
    /// The services attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Services is required")]
    public HashSet<TerraformProperty<string>> Services
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("services");
        set => SetProperty("services", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string> Url
    {
        get => GetRequiredOutput<TerraformProperty<string>>("url");
        set => SetProperty("url", value);
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
