using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshiftserverless_workgroup Terraform data source.
/// Retrieves information about a aws_redshiftserverless_workgroup.
/// </summary>
public partial class AwsRedshiftserverlessWorkgroupDataSource(string name) : TerraformDataSource("aws_redshiftserverless_workgroup", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformValue<string> WorkgroupName
    {
        get => new TerraformReference<string>(this, "workgroup_name");
        set => SetArgument("workgroup_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoint
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "endpoint").ResolveNodes(ctx));
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformValue<bool> EnhancedVpcRouting
    {
        get => new TerraformReference<bool>(this, "enhanced_vpc_routing");
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    public TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The track_name attribute.
    /// </summary>
    public TerraformValue<string> TrackName
    {
        get => new TerraformReference<string>(this, "track_name");
    }

    /// <summary>
    /// The workgroup_id attribute.
    /// </summary>
    public TerraformValue<string> WorkgroupId
    {
        get => new TerraformReference<string>(this, "workgroup_id");
    }

}
