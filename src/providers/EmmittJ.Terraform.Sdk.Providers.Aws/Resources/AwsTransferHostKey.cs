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
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The host_key_body attribute.
    /// </summary>
    public TerraformValue<string>? HostKeyBody
    {
        get => GetArgument<TerraformValue<string>>("host_key_body");
        set => SetArgument("host_key_body", value);
    }

    /// <summary>
    /// The host_key_body_wo attribute.
    /// </summary>
    public TerraformValue<string>? HostKeyBodyWo
    {
        get => GetArgument<TerraformValue<string>>("host_key_body_wo");
        set => SetArgument("host_key_body_wo", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("server_id");
        set => SetArgument("server_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> HostKeyFingerprint
        => CreateReference("host_key_fingerprint");

    /// <summary>
    /// The host_key_id attribute.
    /// </summary>
    public TerraformValue<string> HostKeyId
        => CreateReference("host_key_id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

}
