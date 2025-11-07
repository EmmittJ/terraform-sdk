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
    public TerraformLiteralProperty<string>? AddressFamily
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_family");
        set => this.WithProperty("address_family", value);
    }

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AllocationDefaultNetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocation_default_netmask_length");
        set => this.WithProperty("allocation_default_netmask_length", value);
    }

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AllocationMaxNetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocation_max_netmask_length");
        set => this.WithProperty("allocation_max_netmask_length", value);
    }

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AllocationMinNetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocation_min_netmask_length");
        set => this.WithProperty("allocation_min_netmask_length", value);
    }

    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? AllocationResourceTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("allocation_resource_tags");
        set => this.WithProperty("allocation_resource_tags", value);
    }

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoImport
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_import");
        set => this.WithProperty("auto_import", value);
    }

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AwsService
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_service");
        set => this.WithProperty("aws_service", value);
    }

    /// <summary>
    /// The cascade attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Cascade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cascade");
        set => this.WithProperty("cascade", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The ipam_scope_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IpamScopeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipam_scope_id");
        set => this.WithProperty("ipam_scope_id", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Locale
    {
        get => GetProperty<TerraformLiteralProperty<string>>("locale");
        set => this.WithProperty("locale", value);
    }

    /// <summary>
    /// The public_ip_source attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PublicIpSource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip_source");
        set => this.WithProperty("public_ip_source", value);
    }

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PubliclyAdvertisable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_advertisable");
        set => this.WithProperty("publicly_advertisable", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceIpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_ipam_pool_id");
        set => this.WithProperty("source_ipam_pool_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
