using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for operating_regions in .
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamOperatingRegionsBlock : TerraformBlock
{
    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformProperty<string> RegionName
    {
        get => GetProperty<TerraformProperty<string>>("region_name");
        set => WithProperty("region_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamTimeoutsBlock : TerraformBlock
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
/// Manages a aws_vpc_ipam resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVpcIpam : TerraformResource
{
    public AwsVpcIpam(string name) : base("aws_vpc_ipam", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("default_resource_discovery_association_id");
        this.DeclareOutput("default_resource_discovery_id");
        this.DeclareOutput("private_default_scope_id");
        this.DeclareOutput("public_default_scope_id");
        this.DeclareOutput("scope_count");
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
    /// The enable_private_gua attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePrivateGua
    {
        get => GetProperty<TerraformProperty<bool>>("enable_private_gua");
        set => this.WithProperty("enable_private_gua", value);
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
    /// The metered_account attribute.
    /// </summary>
    public TerraformProperty<string>? MeteredAccount
    {
        get => GetProperty<TerraformProperty<string>>("metered_account");
        set => this.WithProperty("metered_account", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// Block for operating_regions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OperatingRegions block(s) required")]
    public HashSet<AwsVpcIpamOperatingRegionsBlock>? OperatingRegions
    {
        get => GetProperty<HashSet<AwsVpcIpamOperatingRegionsBlock>>("operating_regions");
        set => this.WithProperty("operating_regions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcIpamTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcIpamTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    public TerraformExpression DefaultResourceDiscoveryAssociationId => this["default_resource_discovery_association_id"];

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    public TerraformExpression DefaultResourceDiscoveryId => this["default_resource_discovery_id"];

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    public TerraformExpression PrivateDefaultScopeId => this["private_default_scope_id"];

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    public TerraformExpression PublicDefaultScopeId => this["public_default_scope_id"];

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    public TerraformExpression ScopeCount => this["scope_count"];

}
