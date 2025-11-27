using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for replica in AwsSecretsmanagerSecret.
/// Nesting mode: set
/// </summary>
public class AwsSecretsmanagerSecretReplicaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replica";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The last_accessed_date attribute.
    /// </summary>
    public TerraformValue<string> LastAccessedDate
    {
        get => new TerraformReference<string>(this, "last_accessed_date");
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
    {
        get => new TerraformReference<string>(this, "status_message");
    }

}


/// <summary>
/// Represents a aws_secretsmanager_secret Terraform resource.
/// Manages a aws_secretsmanager_secret resource.
/// </summary>
public partial class AwsSecretsmanagerSecret(string name) : TerraformResource("aws_secretsmanager_secret", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The force_overwrite_replica_secret attribute.
    /// </summary>
    public TerraformValue<bool>? ForceOverwriteReplicaSecret
    {
        get => new TerraformReference<bool>(this, "force_overwrite_replica_secret");
        set => SetArgument("force_overwrite_replica_secret", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// The recovery_window_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RecoveryWindowInDays
    {
        get => new TerraformReference<double>(this, "recovery_window_in_days");
        set => SetArgument("recovery_window_in_days", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Replica block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecretsmanagerSecretReplicaBlock>? Replica
    {
        get => GetArgument<TerraformSet<AwsSecretsmanagerSecretReplicaBlock>>("replica");
        set => SetArgument("replica", value);
    }

}
