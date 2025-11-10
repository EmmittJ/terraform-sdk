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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("ipam_scope_type");
        SetOutput("pool_depth");
        SetOutput("state");
        SetOutput("address_family");
        SetOutput("allocation_default_netmask_length");
        SetOutput("allocation_max_netmask_length");
        SetOutput("allocation_min_netmask_length");
        SetOutput("allocation_resource_tags");
        SetOutput("auto_import");
        SetOutput("aws_service");
        SetOutput("cascade");
        SetOutput("description");
        SetOutput("id");
        SetOutput("ipam_scope_id");
        SetOutput("locale");
        SetOutput("public_ip_source");
        SetOutput("publicly_advertisable");
        SetOutput("region");
        SetOutput("source_ipam_pool_id");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    public required TerraformProperty<string> AddressFamily
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address_family");
        set => SetProperty("address_family", value);
    }

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double> AllocationDefaultNetmaskLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("allocation_default_netmask_length");
        set => SetProperty("allocation_default_netmask_length", value);
    }

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double> AllocationMaxNetmaskLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("allocation_max_netmask_length");
        set => SetProperty("allocation_max_netmask_length", value);
    }

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double> AllocationMinNetmaskLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("allocation_min_netmask_length");
        set => SetProperty("allocation_min_netmask_length", value);
    }

    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AllocationResourceTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("allocation_resource_tags");
        set => SetProperty("allocation_resource_tags", value);
    }

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    public TerraformProperty<bool> AutoImport
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_import");
        set => SetProperty("auto_import", value);
    }

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    public TerraformProperty<string> AwsService
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_service");
        set => SetProperty("aws_service", value);
    }

    /// <summary>
    /// The cascade attribute.
    /// </summary>
    public TerraformProperty<bool> Cascade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cascade");
        set => SetProperty("cascade", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The ipam_scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamScopeId is required")]
    public required TerraformProperty<string> IpamScopeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipam_scope_id");
        set => SetProperty("ipam_scope_id", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformProperty<string> Locale
    {
        get => GetRequiredOutput<TerraformProperty<string>>("locale");
        set => SetProperty("locale", value);
    }

    /// <summary>
    /// The public_ip_source attribute.
    /// </summary>
    public TerraformProperty<string> PublicIpSource
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_ip_source");
        set => SetProperty("public_ip_source", value);
    }

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    public TerraformProperty<bool> PubliclyAdvertisable
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_advertisable");
        set => SetProperty("publicly_advertisable", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceIpamPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_ipam_pool_id");
        set => SetProperty("source_ipam_pool_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcIpamPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
