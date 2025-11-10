using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamPoolDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_vpc_ipam_pool.
/// </summary>
public class AwsVpcIpamPoolDataSource : TerraformDataSource
{
    public AwsVpcIpamPoolDataSource(string name) : base("aws_vpc_ipam_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address_family");
        this.DeclareOutput("allocation_default_netmask_length");
        this.DeclareOutput("allocation_max_netmask_length");
        this.DeclareOutput("allocation_min_netmask_length");
        this.DeclareOutput("arn");
        this.DeclareOutput("auto_import");
        this.DeclareOutput("aws_service");
        this.DeclareOutput("description");
        this.DeclareOutput("ipam_scope_id");
        this.DeclareOutput("ipam_scope_type");
        this.DeclareOutput("locale");
        this.DeclareOutput("pool_depth");
        this.DeclareOutput("publicly_advertisable");
        this.DeclareOutput("source_ipam_pool_id");
        this.DeclareOutput("state");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? IpamPoolId
    {
        get => GetProperty<TerraformProperty<string>>("ipam_pool_id");
        set => this.WithProperty("ipam_pool_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpcIpamPoolDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsVpcIpamPoolDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcIpamPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcIpamPoolDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    public TerraformExpression AddressFamily => this["address_family"];

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    public TerraformExpression AllocationDefaultNetmaskLength => this["allocation_default_netmask_length"];

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    public TerraformExpression AllocationMaxNetmaskLength => this["allocation_max_netmask_length"];

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    public TerraformExpression AllocationMinNetmaskLength => this["allocation_min_netmask_length"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    public TerraformExpression AutoImport => this["auto_import"];

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    public TerraformExpression AwsService => this["aws_service"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The ipam_scope_id attribute.
    /// </summary>
    public TerraformExpression IpamScopeId => this["ipam_scope_id"];

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    public TerraformExpression IpamScopeType => this["ipam_scope_type"];

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformExpression Locale => this["locale"];

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    public TerraformExpression PoolDepth => this["pool_depth"];

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    public TerraformExpression PubliclyAdvertisable => this["publicly_advertisable"];

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    public TerraformExpression SourceIpamPoolId => this["source_ipam_pool_id"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
