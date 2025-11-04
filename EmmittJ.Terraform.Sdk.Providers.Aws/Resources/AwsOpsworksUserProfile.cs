using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opsworks_user_profile resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsOpsworksUserProfile : TerraformResource
{
    public AwsOpsworksUserProfile(string name) : base("aws_opsworks_user_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allow_self_management attribute.
    /// </summary>
    public bool? AllowSelfManagement
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_self_management")?.Value;
        set => this.WithProperty("allow_self_management", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ssh_public_key attribute.
    /// </summary>
    public string? SshPublicKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssh_public_key")?.Value;
        set => this.WithProperty("ssh_public_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ssh_username attribute.
    /// </summary>
    public string? SshUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssh_username")?.Value;
        set => this.WithProperty("ssh_username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_arn attribute.
    /// </summary>
    public string? UserArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_arn")?.Value;
        set => this.WithProperty("user_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
