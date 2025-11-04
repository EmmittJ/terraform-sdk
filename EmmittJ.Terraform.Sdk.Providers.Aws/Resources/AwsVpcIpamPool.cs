using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_pool resource.
/// </summary>
public class AwsVpcIpamPool : TerraformResource
{
    public AwsVpcIpamPool(string name) : base("aws_vpc_ipam_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("ipam_scope_type");
        this.DeclareOutput("pool_depth");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    public string? AddressFamily
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_family")?.Value;
        set => this.WithProperty("address_family", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    public double? AllocationDefaultNetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocation_default_netmask_length")?.Value;
        set => this.WithProperty("allocation_default_netmask_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    public double? AllocationMaxNetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocation_max_netmask_length")?.Value;
        set => this.WithProperty("allocation_max_netmask_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    public double? AllocationMinNetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocation_min_netmask_length")?.Value;
        set => this.WithProperty("allocation_min_netmask_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    public Dictionary<string, string>? AllocationResourceTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("allocation_resource_tags")?.Value;
        set => this.WithProperty("allocation_resource_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    public bool? AutoImport
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_import")?.Value;
        set => this.WithProperty("auto_import", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    public string? AwsService
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_service")?.Value;
        set => this.WithProperty("aws_service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cascade attribute.
    /// </summary>
    public bool? Cascade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cascade")?.Value;
        set => this.WithProperty("cascade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ipam_scope_id attribute.
    /// </summary>
    public string? IpamScopeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipam_scope_id")?.Value;
        set => this.WithProperty("ipam_scope_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public string? Locale
    {
        get => GetProperty<TerraformLiteralProperty<string>>("locale")?.Value;
        set => this.WithProperty("locale", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_ip_source attribute.
    /// </summary>
    public string? PublicIpSource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip_source")?.Value;
        set => this.WithProperty("public_ip_source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    public bool? PubliclyAdvertisable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_advertisable")?.Value;
        set => this.WithProperty("publicly_advertisable", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    public string? SourceIpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_ipam_pool_id")?.Value;
        set => this.WithProperty("source_ipam_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    public TerraformExpression IpamScopeType => this["ipam_scope_type"];

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    public TerraformExpression PoolDepth => this["pool_depth"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
