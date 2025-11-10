using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    public required TerraformProperty<string> AddressFamily
    {
        get => GetRequiredProperty<TerraformProperty<string>>("address_family");
        set => this.WithProperty("address_family", value);
    }

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double>? AllocationDefaultNetmaskLength
    {
        get => GetProperty<TerraformProperty<double>>("allocation_default_netmask_length");
        set => this.WithProperty("allocation_default_netmask_length", value);
    }

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double>? AllocationMaxNetmaskLength
    {
        get => GetProperty<TerraformProperty<double>>("allocation_max_netmask_length");
        set => this.WithProperty("allocation_max_netmask_length", value);
    }

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double>? AllocationMinNetmaskLength
    {
        get => GetProperty<TerraformProperty<double>>("allocation_min_netmask_length");
        set => this.WithProperty("allocation_min_netmask_length", value);
    }

    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AllocationResourceTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("allocation_resource_tags");
        set => this.WithProperty("allocation_resource_tags", value);
    }

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoImport
    {
        get => GetProperty<TerraformProperty<bool>>("auto_import");
        set => this.WithProperty("auto_import", value);
    }

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    public TerraformProperty<string>? AwsService
    {
        get => GetProperty<TerraformProperty<string>>("aws_service");
        set => this.WithProperty("aws_service", value);
    }

    /// <summary>
    /// The cascade attribute.
    /// </summary>
    public TerraformProperty<bool>? Cascade
    {
        get => GetProperty<TerraformProperty<bool>>("cascade");
        set => this.WithProperty("cascade", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The ipam_scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamScopeId is required")]
    public required TerraformProperty<string> IpamScopeId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ipam_scope_id");
        set => this.WithProperty("ipam_scope_id", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformProperty<string>? Locale
    {
        get => GetProperty<TerraformProperty<string>>("locale");
        set => this.WithProperty("locale", value);
    }

    /// <summary>
    /// The public_ip_source attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpSource
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_source");
        set => this.WithProperty("public_ip_source", value);
    }

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAdvertisable
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_advertisable");
        set => this.WithProperty("publicly_advertisable", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceIpamPoolId
    {
        get => GetProperty<TerraformProperty<string>>("source_ipam_pool_id");
        set => this.WithProperty("source_ipam_pool_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcIpamPoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcIpamPoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
