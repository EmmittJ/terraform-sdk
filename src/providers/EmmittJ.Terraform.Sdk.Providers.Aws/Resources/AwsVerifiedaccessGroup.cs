using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sse_configuration in AwsVerifiedaccessGroup.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessGroupSseConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sse_configuration";

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomerManagedKeyEnabled
    {
        get => new TerraformReference<bool>(this, "customer_managed_key_enabled");
        set => SetArgument("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}


/// <summary>
/// Represents a aws_verifiedaccess_group Terraform resource.
/// Manages a aws_verifiedaccess_group resource.
/// </summary>
public partial class AwsVerifiedaccessGroup(string name) : TerraformResource("aws_verifiedaccess_group", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The policy_document attribute.
    /// </summary>
    public TerraformValue<string>? PolicyDocument
    {
        get => new TerraformReference<string>(this, "policy_document");
        set => SetArgument("policy_document", value);
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
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    public required TerraformValue<string> VerifiedaccessInstanceId
    {
        get => new TerraformReference<string>(this, "verifiedaccess_instance_id");
        set => SetArgument("verifiedaccess_instance_id", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The deletion_time attribute.
    /// </summary>
    public TerraformValue<string> DeletionTime
    {
        get => new TerraformReference<string>(this, "deletion_time");
    }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
    {
        get => new TerraformReference<string>(this, "last_updated_time");
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
    }

    /// <summary>
    /// The verifiedaccess_group_arn attribute.
    /// </summary>
    public TerraformValue<string> VerifiedaccessGroupArn
    {
        get => new TerraformReference<string>(this, "verifiedaccess_group_arn");
    }

    /// <summary>
    /// The verifiedaccess_group_id attribute.
    /// </summary>
    public TerraformValue<string> VerifiedaccessGroupId
    {
        get => new TerraformReference<string>(this, "verifiedaccess_group_id");
    }

    /// <summary>
    /// SseConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseConfiguration block(s) allowed")]
    public TerraformList<AwsVerifiedaccessGroupSseConfigurationBlock>? SseConfiguration
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessGroupSseConfigurationBlock>>("sse_configuration");
        set => SetArgument("sse_configuration", value);
    }

}
