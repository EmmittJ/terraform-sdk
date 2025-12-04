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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetRequiredArgument<TerraformValue<string>>("hsm_type");
        set => SetArgument("hsm_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode") ?? AsReference("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_backup_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SourceBackupIdentifier
    {
        get => GetArgument<TerraformValue<string>>("source_backup_identifier");
        set => SetArgument("source_backup_identifier", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The cluster_certificates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterCertificates
        => AsReference("cluster_certificates");

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterId
        => AsReference("cluster_id");

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    public TerraformValue<string> ClusterState
        => AsReference("cluster_state");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupId
        => AsReference("security_group_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudhsmV2ClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudhsmV2ClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
