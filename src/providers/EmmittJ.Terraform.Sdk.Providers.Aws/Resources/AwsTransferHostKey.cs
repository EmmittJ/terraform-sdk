using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_transfer_host_key Terraform resource.
/// Manages a aws_transfer_host_key resource.
/// </summary>
public partial class AwsTransferHostKey(string name) : TerraformResource("aws_transfer_host_key", name)
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
    /// The host_key_body attribute.
    /// </summary>
    public TerraformValue<string>? HostKeyBody
    {
        get => new TerraformReference<string>(this, "host_key_body");
        set => SetArgument("host_key_body", value);
    }

    /// <summary>
    /// The host_key_body_wo attribute.
    /// </summary>
    public TerraformValue<string>? HostKeyBodyWo
    {
        get => new TerraformReference<string>(this, "host_key_body_wo");
        set => SetArgument("host_key_body_wo", value);
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
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> HostKeyFingerprint
    {
        get => new TerraformReference<string>(this, "host_key_fingerprint");
    }

    /// <summary>
    /// The host_key_id attribute.
    /// </summary>
    public TerraformValue<string> HostKeyId
    {
        get => new TerraformReference<string>(this, "host_key_id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

}
