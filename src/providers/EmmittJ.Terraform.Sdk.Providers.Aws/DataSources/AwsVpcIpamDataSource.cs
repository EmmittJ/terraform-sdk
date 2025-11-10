using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_ipam.
/// </summary>
public class AwsVpcIpamDataSource : TerraformDataSource
{
    public AwsVpcIpamDataSource(string name) : base("aws_vpc_ipam", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("default_resource_discovery_association_id");
        SetOutput("default_resource_discovery_id");
        SetOutput("description");
        SetOutput("enable_private_gua");
        SetOutput("ipam_region");
        SetOutput("metered_account");
        SetOutput("operating_regions");
        SetOutput("owner_id");
        SetOutput("private_default_scope_id");
        SetOutput("public_default_scope_id");
        SetOutput("resource_discovery_association_count");
        SetOutput("scope_count");
        SetOutput("state");
        SetOutput("state_message");
        SetOutput("tags");
        SetOutput("tier");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The enable_private_gua attribute.
    /// </summary>
    public TerraformExpression EnablePrivateGua => this["enable_private_gua"];

    /// <summary>
    /// The ipam_region attribute.
    /// </summary>
    public TerraformExpression IpamRegion => this["ipam_region"];

    /// <summary>
    /// The metered_account attribute.
    /// </summary>
    public TerraformExpression MeteredAccount => this["metered_account"];

    /// <summary>
    /// The operating_regions attribute.
    /// </summary>
    public TerraformExpression OperatingRegions => this["operating_regions"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    public TerraformExpression PrivateDefaultScopeId => this["private_default_scope_id"];

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    public TerraformExpression PublicDefaultScopeId => this["public_default_scope_id"];

    /// <summary>
    /// The resource_discovery_association_count attribute.
    /// </summary>
    public TerraformExpression ResourceDiscoveryAssociationCount => this["resource_discovery_association_count"];

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    public TerraformExpression ScopeCount => this["scope_count"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The state_message attribute.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformExpression Tier => this["tier"];

}
