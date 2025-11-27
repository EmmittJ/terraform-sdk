using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsCloudhsmV2Cluster.
/// Nesting mode: single
/// </summary>
public class AwsCloudhsmV2ClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_cloudhsm_v2_cluster Terraform resource.
/// Manages a aws_cloudhsm_v2_cluster resource.
/// </summary>
public partial class AwsCloudhsmV2Cluster(string name) : TerraformResource("aws_cloudhsm_v2_cluster", name)
{
    /// <summary>
    /// The hsm_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmType is required")]
    public required TerraformValue<string> HsmType
    {
        get => new TerraformReference<string>(this, "hsm_type");
        set => SetArgument("hsm_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
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
    /// The source_backup_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SourceBackupIdentifier
    {
        get => new TerraformReference<string>(this, "source_backup_identifier");
        set => SetArgument("source_backup_identifier", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The cluster_certificates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterCertificates
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cluster_certificates").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
    }

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    public TerraformValue<string> ClusterState
    {
        get => new TerraformReference<string>(this, "cluster_state");
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupId
    {
        get => new TerraformReference<string>(this, "security_group_id");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudhsmV2ClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudhsmV2ClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
