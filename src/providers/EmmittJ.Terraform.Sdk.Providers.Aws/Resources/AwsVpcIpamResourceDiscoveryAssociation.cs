using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamResourceDiscoveryAssociationTimeoutsBlock : TerraformBlock
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
/// Manages a aws_vpc_ipam_resource_discovery_association resource.
/// </summary>
public class AwsVpcIpamResourceDiscoveryAssociation : TerraformResource
{
    public AwsVpcIpamResourceDiscoveryAssociation(string name) : base("aws_vpc_ipam_resource_discovery_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("ipam_arn");
        this.WithOutput("ipam_region");
        this.WithOutput("is_default");
        this.WithOutput("owner_id");
        this.WithOutput("state");
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
    /// The ipam_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamId is required")]
    public required TerraformProperty<string> IpamId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ipam_id");
        set => this.WithProperty("ipam_id", value);
    }

    /// <summary>
    /// The ipam_resource_discovery_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamResourceDiscoveryId is required")]
    public required TerraformProperty<string> IpamResourceDiscoveryId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ipam_resource_discovery_id");
        set => this.WithProperty("ipam_resource_discovery_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcIpamResourceDiscoveryAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcIpamResourceDiscoveryAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ipam_arn attribute.
    /// </summary>
    public TerraformExpression IpamArn => this["ipam_arn"];

    /// <summary>
    /// The ipam_region attribute.
    /// </summary>
    public TerraformExpression IpamRegion => this["ipam_region"];

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
