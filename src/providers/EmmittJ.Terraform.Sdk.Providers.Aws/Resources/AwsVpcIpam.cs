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
        set => SetProperty("region_name", value);
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
        SetOutput("arn");
        SetOutput("default_resource_discovery_association_id");
        SetOutput("default_resource_discovery_id");
        SetOutput("private_default_scope_id");
        SetOutput("public_default_scope_id");
        SetOutput("scope_count");
        SetOutput("cascade");
        SetOutput("description");
        SetOutput("enable_private_gua");
        SetOutput("id");
        SetOutput("metered_account");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tier");
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
    /// The enable_private_gua attribute.
    /// </summary>
    public TerraformProperty<bool> EnablePrivateGua
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_private_gua");
        set => SetProperty("enable_private_gua", value);
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
    /// The metered_account attribute.
    /// </summary>
    public TerraformProperty<string> MeteredAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metered_account");
        set => SetProperty("metered_account", value);
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
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// Block for operating_regions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatingRegions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OperatingRegions block(s) required")]
    public HashSet<AwsVpcIpamOperatingRegionsBlock>? OperatingRegions
    {
        set => SetProperty("operating_regions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcIpamTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
